using UnityEngine;
using System.Collections;

public class LampController : MonoBehaviour {
    public DetectClick lampClick;
    public Animator animator;
    public HighlightObject isPointerIn;
    public bool turnedOn;
    public GameObject pointLight;
    public TestController vol;
    public float lightIntensity = 2f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isPointerIn.isHighlighted)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("LampOff") && Input.GetButtonDown("Switch1"))
            {
                animator.SetTrigger("LampOnSwitchPressed");
                animator.ResetTrigger("LampOffSwitchPressed");
                turnedOn = true;
            }
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("LampOn") && Input.GetButtonDown("Switch1"))

            {
                animator.SetTrigger("LampOffSwitchPressed");
                animator.ResetTrigger("LampOnSwitchPressed");
                turnedOn = false;
            }
            if (vol.volumeUp)
            {
                lightIntensity += 4f * Time.deltaTime;
            }
            if (vol.volumeDown)
            {
                lightIntensity -= 4f * Time.deltaTime;
            }
            pointLight.GetComponent<Light>().intensity = lightIntensity;

        }
    }
}
