using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicDancingCauldronController : MonoBehaviour
{

    private Animator anim;
    private bool isDancing = false;

    public void startDancing() { isDancing = true; }
    public void stopDancing() { isDancing = false; }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isDancing = Input.GetKey(KeyCode.F);
        anim.SetBool("IsDancing", isDancing);
    }
}
