using UnityEngine;
using System.Collections;

public class TestController : MonoBehaviour {
    public float value;
    public bool volumeUp;
    public bool volumeDown;
	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Switch1"))
        {
            Debug.Log("Switch1 was pressed");
        }
        if (Input.GetButtonDown("Switch3"))
        {
            Debug.Log("Switch3 was pressed");
        }
        if (Input.GetButtonDown("Switch2"))
        {
            Debug.Log("Switch2 was pressed");
        }
        value = Input.GetAxis("Horizontal");
        //Debug.Log(value);
        if (value > 0)
        {
            Debug.Log("volume down");
            volumeUp = false;
            volumeDown = true;
        }
        if (value < 0)
        {
            Debug.Log("volume up");
            volumeUp = true;
            volumeDown = false;
        }
        if (value == 0)
        {
            if (volumeUp)
            {
                volumeUp = false;

            }
            if (volumeDown)
            {
                volumeDown = false;

            }

        }
    }
}
