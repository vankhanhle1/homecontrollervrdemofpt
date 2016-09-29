using UnityEngine;
using System.Collections;

public class ControllerTest : MonoBehaviour {
    public GameObject lampLight;
    public bool lampLightSwitch;

    public GameObject teevee;
    public bool teeveeSwitch;

    public GameObject fanOff;
    public GameObject fanOn;
    public bool fanSwitch;

    public GameObject ceilingLights;
    public bool ceilingLightsSwitch;
    // Use this for initialization
    void Start() {
        //lampLight.SetActive(false);
        //teevee.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        if (lampLightSwitch)
        {
            lampLight.SetActive(true);
        }
        else if (!lampLightSwitch)
        {
            lampLight.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            lampLightSwitch = !lampLightSwitch;
        }
        /*if (teeveeSwitch)
        {
            teevee.SetActive(true);
        }
        else if (!teeveeSwitch)
        {
            teevee.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            teeveeSwitch = !teeveeSwitch;
        }*/
        if (fanSwitch)
        {
            fanOff.SetActive(false);
            fanOn.SetActive(true);
        }
        if (!fanSwitch)
        {
            fanOn.SetActive(false);
            fanOff.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            fanSwitch = !fanSwitch;
        }
        if (ceilingLightsSwitch)
        {
            ceilingLights.SetActive(true);
        }
        if (!ceilingLightsSwitch)
        {
            ceilingLights.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            ceilingLightsSwitch = !ceilingLightsSwitch;
        }
    }
}
