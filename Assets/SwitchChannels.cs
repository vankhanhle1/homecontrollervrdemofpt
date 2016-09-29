using UnityEngine;
using System.Collections;

public class SwitchChannels : MonoBehaviour {
    public Animator animator;
    public DetectClick teeveeClick;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if ((animator.GetCurrentAnimatorStateInfo(0).IsName("Off") && Input.GetKeyDown(KeyCode.T)) || teeveeClick.turnedOn)
        {
            animator.SetTrigger("TurnOnPressed");
            animator.ResetTrigger("TurnOffPressed");
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("SwitchedOn") && Input.GetKeyDown("right"))
        {
            animator.SetTrigger("NextChannelPressed");
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel1") && Input.GetKeyDown("right"))
        {
            animator.SetTrigger("NextChannelPressed");
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel2") && Input.GetKeyDown("right"))
        {
            animator.SetTrigger("NextChannelPressed");
        }
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
        if ((animator.GetCurrentAnimatorStateInfo(0).IsName("Channel3") && Input.GetKeyDown(KeyCode.T)) || teeveeClick.turnedOff)
        {
            animator.SetTrigger("TurnOffPressed");
            animator.ResetTrigger("TurnOnPressed");

        }
        if ((animator.GetCurrentAnimatorStateInfo(0).IsName("Channel1") && Input.GetKeyDown(KeyCode.T)) || teeveeClick.turnedOff)
        {
            animator.SetTrigger("TurnOffPressed");
            animator.ResetTrigger("TurnOnPressed");

        }
        if ((animator.GetCurrentAnimatorStateInfo(0).IsName("Channel2") && Input.GetKeyDown(KeyCode.T)) || teeveeClick.turnedOff)
        {
            animator.SetTrigger("TurnOffPressed");
            animator.ResetTrigger("TurnOnPressed");

        }
        if ((animator.GetCurrentAnimatorStateInfo(0).IsName("SwitchedOn") && Input.GetKeyDown(KeyCode.T)) || teeveeClick.turnedOff)
        {
            animator.SetTrigger("TurnOffPressed");
            animator.ResetTrigger("TurnOnPressed");

        }
    }
}
