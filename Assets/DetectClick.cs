using UnityEngine;
using System.Collections;

public class DetectClick : MonoBehaviour {
    //public GameObject OnObject;
    //public GameObject OffObject;
    public bool turnedOn;
    public bool turnedOff = true;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    public void TurnOnOff() {
        turnedOn = !turnedOn;
        turnedOff = !turnedOff;
        /*if (Input.GetButton("Switch1") || Input.GetButton("Switch2") || Input.GetButton("Switch3") || Input.GetButton("Switch4"))
        {
            turnedOn = !turnedOn;
            turnedOff = !turnedOff;
        }*/
        /*if (turnedOn)
        {
            OnObject.SetActive(true);
            OffObject.SetActive(false);
            //this.gameObject.transform.Translate(2, 2, 2);
        }*/
        /*if (!turnedOn)
        {
            OffObject.SetActive(true);
            OnObject.SetActive(false);
            //this.gameObject.transform.Translate(-2, -2, -2);
        }*/
        /*toEnable.SetActive(true);
        if (toDisable != null)
        {
            toDisable.SetActive(false);
        }*/
    }
    /*public void TurnOff ()
    {
        turn
        toEnable.SetActive(false);
        if (toDisable != null)
        {
            toDisable.SetActive(true);
        }
    }*/
}
