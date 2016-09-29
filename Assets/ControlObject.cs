using UnityEngine;
using System.Collections;

public class ControlObject : MonoBehaviour {
    public DetectClick detectClick;
    public GameObject toEnable;
    public GameObject toDisable;

    void ControlObjectOnOff()
    {
        if (detectClick.turnedOn)
        {
            toEnable.SetActive(true);
            if (toDisable != null)
            {
                toDisable.SetActive(false);
            }
        }
        if (!detectClick.turnedOn)
        {
            toEnable.SetActive(false);
            if (toDisable != null)
            {
                toDisable.SetActive(true);
            }
        }
    }
}
