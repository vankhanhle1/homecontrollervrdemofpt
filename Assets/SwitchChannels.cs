using UnityEngine;
using System.Collections;

public class SwitchChannels : MonoBehaviour {
    public Animator animator;
    public HighlightObject isPointerIn;
    public bool turnedon;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        /*//if (animator.GetCurrentAnimatorStateInfo(0).IsName("Off") && isPointerIn.isHighlighted && (Input.GetKeyDown("Switch1") || Input.GetMouseButton(0)))
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Off") && isPointerIn.isHighlighted && Input.GetMouseButton(1))
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Off") && isPointerIn.isHighlighted && Input.GetKeyDown(KeyCode.Space))

        {
            turnedon = true;
            animator.SetTrigger("TurnOnPressed");
            animator.ResetTrigger("TurnOffPressed");
        }
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("SwitchedOn") && (Input.GetKeyDown("Switch3") || Input.GetMouseButton(1)))
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("SwitchedOn") && Input.GetMouseButton(1))
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("SwitchedOn") && Input.GetKeyDown("right"))
        {
            animator.SetTrigger("NextChannelPressed");

        }
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel1") && (Input.GetKeyDown("Switch3") || Input.GetMouseButton(1)))
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel1") && Input.GetMouseButton(1))
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel1") && Input.GetKeyDown("right"))
        {
            animator.SetTrigger("NextChannelPressed");
        }
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel2") && (Input.GetKeyDown("Switch3") || Input.GetMouseButton(1)))
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel2") && Input.GetMouseButton(1))
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel2") && Input.GetKeyDown("right"))
        {
            animator.SetTrigger("NextChannelPressed");
        }
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel3") && (Input.GetKeyDown("Switch3") || Input.GetMouseButton(1)))
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel3") && Input.GetMouseButton(1))
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel3") && Input.GetKeyDown("right"))
        {
            animator.SetTrigger("NextChannelPressed");
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("SwitchedOn") && Input.GetKeyDown("left"))
        {
            animator.SetTrigger("PreviousChannelPressed");
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel3") && Input.GetKeyDown("left"))
        {
            animator.SetTrigger("PreviousChannelPressed");
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel1") && Input.GetKeyDown("left"))
        {
            animator.SetTrigger("PreviousChannelPressed");
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel2") && Input.GetKeyDown("left"))
        {
            animator.SetTrigger("PreviousChannelPressed");
        }
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel1") && isPointerIn.isHighlighted && (Input.GetKeyDown("Switch1") || Input.GetMouseButton(0)))
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel1") && isPointerIn.isHighlighted && Input.GetMouseButton(1))
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel1") && isPointerIn.isHighlighted && Input.GetKeyDown(KeyCode.Space))
        {
            TurnTVOff();


        }
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel2") && isPointerIn.isHighlighted && (Input.GetKeyDown("Switch1") || Input.GetMouseButton(0)))
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel2") && isPointerIn.isHighlighted && Input.GetMouseButton(1))
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel2") && isPointerIn.isHighlighted && Input.GetKeyDown(KeyCode.Space)) {
            TurnTVOff();


        }
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel3") && isPointerIn.isHighlighted && (Input.GetKeyDown("Switch1") || Input.GetMouseButton(0)))
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel3") && isPointerIn.isHighlighted && Input.GetMouseButton(1))
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel3") && isPointerIn.isHighlighted && Input.GetKeyDown(KeyCode.Space))
        {
            TurnTVOff();

        }
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("SwitchedOn") && isPointerIn.isHighlighted && (Input.GetKeyDown("Switch1") || Input.GetMouseButton(0)))
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("SwitchedOn") && isPointerIn.isHighlighted && Input.GetMouseButton(1))
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("SwitchedOn") && isPointerIn.isHighlighted && Input.GetKeyDown(KeyCode.Space))
        {
            TurnTVOff();
        }

        */


        


        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Off") && isPointerIn.isHighlighted && (Input.GetKeyDown("Switch1") || Input.GetMouseButton(0)))
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Off") && isPointerIn.isHighlighted && Input.GetMouseButton(1))
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Off") && isPointerIn.isHighlighted && Input.GetButtonDown("Switch1"))

        {
            turnedon = true;
            animator.SetTrigger("TurnOnPressed");
            animator.ResetTrigger("TurnOffPressed");
        }
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("SwitchedOn") && (Input.GetKeyDown("Switch3") || Input.GetMouseButton(1)))
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("SwitchedOn") && Input.GetMouseButton(1))
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("SwitchedOn") && Input.GetButtonDown("Switch2"))
        {
            animator.SetTrigger("NextChannelPressed");
        }
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel1") && (Input.GetKeyDown("Switch3") || Input.GetMouseButton(1)))
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel1") && Input.GetMouseButton(1))
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel1") && Input.GetButtonDown("Switch2"))
        {
            animator.SetTrigger("NextChannelPressed");
        }
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel2") && (Input.GetKeyDown("Switch3") || Input.GetMouseButton(1)))
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel2") && Input.GetMouseButton(1))
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel2") && Input.GetButtonDown("Switch2"))
        {
            animator.SetTrigger("NextChannelPressed");
        }
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel3") && (Input.GetKeyDown("Switch3") || Input.GetMouseButton(1)))
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel3") && Input.GetMouseButton(1))
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel3") && Input.GetButtonDown("Switch2"))
        {
            animator.SetTrigger("NextChannelPressed");
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("SwitchedOn") && Input.GetButtonDown("Switch3"))
        {
            animator.SetTrigger("PreviousChannelPressed");
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel3") && Input.GetButtonDown("Switch3"))
        {
            animator.SetTrigger("PreviousChannelPressed");
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel1") && Input.GetButtonDown("Switch3"))
        {
            animator.SetTrigger("PreviousChannelPressed");
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel2") && Input.GetButtonDown("Switch3"))
        {
            animator.SetTrigger("PreviousChannelPressed");
        }
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel1") && isPointerIn.isHighlighted && (Input.GetKeyDown("Switch1") || Input.GetMouseButton(0)))
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel1") && isPointerIn.isHighlighted && Input.GetMouseButton(1))
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel1") && isPointerIn.isHighlighted && Input.GetButtonDown("Switch1"))
        {
            TurnTVOff();


        }
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel2") && isPointerIn.isHighlighted && (Input.GetKeyDown("Switch1") || Input.GetMouseButton(0)))
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel2") && isPointerIn.isHighlighted && Input.GetMouseButton(1))
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel2") && isPointerIn.isHighlighted && Input.GetButtonDown("Switch1"))
        {
            TurnTVOff();


        }
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel3") && isPointerIn.isHighlighted && (Input.GetKeyDown("Switch1") || Input.GetMouseButton(0)))
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel3") && isPointerIn.isHighlighted && Input.GetMouseButton(1))
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel3") && isPointerIn.isHighlighted && Input.GetButtonDown("Switch1"))
        {
            TurnTVOff();

        }
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("SwitchedOn") && isPointerIn.isHighlighted && (Input.GetKeyDown("Switch1") || Input.GetMouseButton(0)))
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("SwitchedOn") && isPointerIn.isHighlighted && Input.GetMouseButton(1))
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("SwitchedOn") && isPointerIn.isHighlighted && Input.GetButtonDown("Switch1"))
        {
            TurnTVOff();
        }
    }
    void TurnTVOff()
    {
        turnedon = false;
        animator.SetTrigger("TurnOffPressed");
        animator.ResetTrigger("TurnOnPressed");
    }
}
