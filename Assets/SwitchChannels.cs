using UnityEngine;
using System.Collections;

public class SwitchChannels : MonoBehaviour {
    public Animator animator;
    public HighlightObject isPointerIn;
    public bool turnedon;
    private float vol = 0.2f;
    public GameObject audio0;
    public GameObject audio1;
    public GameObject audio2;
    public GameObject audio3;
    public TestController controller;

    // Use this for initialization
    void Start() {

    }

    /*void TurnTVOff()
    {
        turnedon = false;
        animator.SetTrigger("TurnOffPressed");
        animator.ResetTrigger("TurnOnPressed");
    }*/
    // Update is called once per frame
    void Update()
    {

        if (isPointerIn.isHighlighted)
        {
            if (Input.GetButtonDown("Switch1"))
            {
                turnedon = !turnedon;
            }
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("Off"))
            {
                if (Input.GetButtonDown("Switch1"))
                {
                    turnedon = true;
                }
            }
            if (turnedon)
            {
                animator.SetTrigger("TurnOnPressed");
                animator.ResetTrigger("TurnOffPressed");

                if (Input.GetButtonDown("Switch2"))
                {
                    animator.SetTrigger("NextChannelPressed");
                }
                if (Input.GetButtonDown("Switch3"))
                {
                    animator.SetTrigger("PreviousChannelPressed");
                }
                if (controller.volumeDown)
                {
                    vol -= 0.7f * Time.deltaTime;                    
                }
                if (controller.volumeUp)
                {
                    vol += 0.7f * Time.deltaTime;
                }

                audio0.GetComponent<AudioSource>().volume = vol;
                audio1.GetComponent<AudioSource>().volume = vol;
                audio2.GetComponent<AudioSource>().volume = vol;
                audio3.GetComponent<AudioSource>().volume = vol;
                

            }
            if (!turnedon)
            {
                animator.SetTrigger("TurnOffPressed");
                animator.ResetTrigger("TurnOnPressed");
            }

        }




        /*if (animator.GetCurrentAnimatorStateInfo(0).IsName("Off") && isPointerIn.isHighlighted && Input.GetButtonDown("Switch1"))

        {
            turnedon = true;
            animator.SetTrigger("TurnOnPressed");
            animator.ResetTrigger("TurnOffPressed");
        }


        if (animator.GetCurrentAnimatorStateInfo(0).IsName("SwitchedOn") && isPointerIn.isHighlighted && Input.GetButtonDown("Switch2"))
        {
            animator.SetTrigger("NextChannelPressed");
        }


        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel1") && isPointerIn.isHighlighted && Input.GetButtonDown("Switch2"))
        {
            animator.SetTrigger("NextChannelPressed");
        }


        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel2") && isPointerIn.isHighlighted && Input.GetButtonDown("Switch2"))
        {
            animator.SetTrigger("NextChannelPressed");
        }


        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel3") && isPointerIn.isHighlighted && Input.GetButtonDown("Switch2"))
        {
            animator.SetTrigger("NextChannelPressed");
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("SwitchedOn") && isPointerIn.isHighlighted && Input.GetButtonDown("Switch3"))
        {
            animator.SetTrigger("PreviousChannelPressed");
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel3") && isPointerIn.isHighlighted && Input.GetButtonDown("Switch3"))
        {
            animator.SetTrigger("PreviousChannelPressed");
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel1") && isPointerIn.isHighlighted && Input.GetButtonDown("Switch3"))
        {
            animator.SetTrigger("PreviousChannelPressed");
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel2") && isPointerIn.isHighlighted && Input.GetButtonDown("Switch3"))
        {
            animator.SetTrigger("PreviousChannelPressed");
        }


        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel1") && isPointerIn.isHighlighted && Input.GetButtonDown("Switch1"))
        {
            TurnTVOff();


        }


        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel2") && isPointerIn.isHighlighted && Input.GetButtonDown("Switch1"))
        {
            TurnTVOff();


        }


        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Channel3") && isPointerIn.isHighlighted && Input.GetButtonDown("Switch1"))
        {
            TurnTVOff();

        }


        if (animator.GetCurrentAnimatorStateInfo(0).IsName("SwitchedOn") && isPointerIn.isHighlighted && Input.GetButtonDown("Switch1"))
        {
            TurnTVOff();
        }
    }*/
    }
   
}
