using UnityEngine;
using System.Collections;

public class CeilingLightsController : MonoBehaviour {
    public HighlightObject isPointerIn;
    public Animator animator;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isPointerIn.isHighlighted && animator.GetCurrentAnimatorStateInfo(0).IsName("CeilingLightsOff") && Input.GetButtonDown("Switch1"))
        {
            animator.SetTrigger("CeilingLightsOn");
            animator.ResetTrigger("CeilingLightsOff");

        }
        if (isPointerIn.isHighlighted && animator.GetCurrentAnimatorStateInfo(0).IsName("CeilingLightsOn") && Input.GetButtonDown("Switch1"))
        {
            animator.SetTrigger("CeilingLightsOff");
            animator.ResetTrigger("CeilingLightsOn");

        }
    }
}
