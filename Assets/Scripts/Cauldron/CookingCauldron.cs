using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingCauldron : MonoBehaviour
{
    public bool isCooking;

    private Animator anim;

    public void startCooking()
    {
        isCooking = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //isCooking = Input.GetKey(KeyCode.F);
        anim.SetBool("IsCooking", isCooking);
    }
}
