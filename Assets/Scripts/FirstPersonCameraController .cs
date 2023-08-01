using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCameraController : MonoBehaviour
{
    public Transform target;
    public float characterGhostFollowDistance = 1;
    public float cameraDistance = 8;
    public float horizontalSensitivity = 3;
    public float verticalSensitivity = 3;
    public float characterGhostSmoothRate = 0.01f;


    private Vector2 cameraAngleEulerXY = Vector2.zero;
    private Vector3 ghost;
    private Vector3 smoothGhost;
  

    // Start is called before the first frame update
    void Start()
    {
        smoothGhost = ghost = target.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Vertical panning uses INVERTED y-mouse movement but the rotation is on the x-axis.
        cameraAngleEulerXY.x -= Input.GetAxis("Mouse Y") * verticalSensitivity;
        cameraAngleEulerXY.x = Mathf.Clamp(cameraAngleEulerXY.x, -89.99f, 89.99f);
        // Horizontal panning uses x-mouse movement but the rotation is on the y-axis.
        cameraAngleEulerXY.y += Input.GetAxis("Mouse X") * horizontalSensitivity;

        // Update player ghosts
        ghost = ConstrainMaxDistance(ghost, target.position, characterGhostFollowDistance);
        smoothGhost = FollowExponential(smoothGhost, ghost, characterGhostSmoothRate, Time.deltaTime);

        // Look at the (smoothed) ghost at a certain angle.
        transform.rotation = Quaternion.Euler(cameraAngleEulerXY.x, cameraAngleEulerXY.y, 0);
        transform.position = smoothGhost - transform.forward * cameraDistance;
    }

    // Returns where the follower should be in order to stay within a maximum distance from the target.
    private Vector3 ConstrainMaxDistance(Vector3 follower, Vector3 target, float distance)
    {
        Vector3 deltaPos = follower - target;
        if (deltaPos.magnitude > distance)
            return target + deltaPos.normalized * distance;
        else
            return follower;
    }

    // Returns where the follower should be in order to be at a specific distance from the target.
    private Vector3 ConstrainExactDistance(Vector3 follower, Vector3 target, float distance)
    {
        return target + (follower - target).normalized * distance;
    }

    // Follows the target by scaling down the follower-target distance by a factor of "rate" per second.
    // Returns where the follower should be after the timestep.
    // Expects rate to be in the [0, 1) range. A rate of 0 gives unsmoothed follow and a rate of 1 does not follow at all.
    private Vector3 FollowExponential(Vector3 follower, Vector3 target, float rate, float deltaTime)
    {
        return target + (follower - target) * Mathf.Pow(rate, deltaTime);
    }
}
