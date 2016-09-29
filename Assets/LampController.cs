using UnityEngine;
using System.Collections;

public class LampController : MonoBehaviour {
    public DetectClick lampClick;
    public Animator animator;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (lampClick.turnedOn || (animator.GetCurrentAnimatorStateInfo(0).IsName("LampOff") && Input.GetKeyDown(KeyCode.Space)))
        {
            animator.SetTrigger("LampOnSwitchPressed");
            animator.ResetTrigger("LampOffSwitchPressed");

        }
        if (lampClick.turnedOff || (animator.GetCurrentAnimatorStateInfo(0).IsName("LampOn") && Input.GetKeyDown(KeyCode.Space)))
        {
            animator.SetTrigger("LampOffSwitchPressed");
            animator.ResetTrigger("LampOnSwitchPressed");

        }
    }
}
