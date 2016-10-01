using UnityEngine;
using System.Collections;

public class FanController : MonoBehaviour {
    public HighlightObject isPointerIn;
    public Animator animator;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("FanOff") && isPointerIn.isHighlighted && Input.GetButtonDown("Switch1"))
        {
            animator.SetTrigger("FanOnSwitchPressed");
            animator.ResetTrigger("FanOffSwitchPressed");

        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("FanOn") && isPointerIn.isHighlighted && Input.GetButtonDown("Switch1"))
        {
            animator.SetTrigger("FanOffSwitchPressed");
            animator.ResetTrigger("FanOnSwitchPressed");

        }
    }
}
