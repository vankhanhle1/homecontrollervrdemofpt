using UnityEngine;
using System.Collections;

public class CeilingLightsController : MonoBehaviour {
    public DetectClick lightsClick;
    public Animator animator;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (lightsClick.turnedOn || (animator.GetCurrentAnimatorStateInfo(0).IsName("CeilingLightsOff") && Input.GetKeyDown(KeyCode.C)))
        {
            animator.SetTrigger("CeilingLightsOn");
            animator.ResetTrigger("CeilingLightsOff");

        }
        if (lightsClick.turnedOff || (animator.GetCurrentAnimatorStateInfo(0).IsName("CeilingLightsOn") && Input.GetKeyDown(KeyCode.C)))
        {
            animator.SetTrigger("CeilingLightsOff");
            animator.ResetTrigger("CeilingLightsOn");

        }
    }
}
