using UnityEngine;
using System.Collections;

public class LampController : MonoBehaviour {
    public DetectClick lampClick;
    public Animator animator;
    public HighlightObject isPointerIn;
    public bool turnedOn;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("LampOff") && isPointerIn.isHighlighted && Input.GetButtonDown("Switch1"))
        {
            animator.SetTrigger("LampOnSwitchPressed");
            animator.ResetTrigger("LampOffSwitchPressed");
            turnedOn = true;
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("LampOn") && isPointerIn.isHighlighted && Input.GetButtonDown("Switch1"))

        {
            animator.SetTrigger("LampOffSwitchPressed");
            animator.ResetTrigger("LampOnSwitchPressed");
            turnedOn = false;
        }
    }
}
