using UnityEngine;
using System.Collections;

public class FanController : MonoBehaviour {
    public DetectClick fanClick;
    public Animator animator;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (fanClick.turnedOn || (animator.GetCurrentAnimatorStateInfo(0).IsName("FanOff") && Input.GetKeyDown(KeyCode.F)))
        {
            animator.SetTrigger("FanOnSwitchPressed");
            animator.ResetTrigger("FanOffSwitchPressed");

        }
        if (fanClick.turnedOff || (animator.GetCurrentAnimatorStateInfo(0).IsName("FanOn") && Input.GetKeyDown(KeyCode.F)))
        {
            animator.SetTrigger("FanOffSwitchPressed");
            animator.ResetTrigger("FanOnSwitchPressed");

        }
    }
}
