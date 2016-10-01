using UnityEngine;
using System.Collections;

public class TestController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButtonDown("Switch1"))
        {
            Debug.Log("Switch1 was pressed");
        }
        if (Input.GetButtonDown("Switch3"))
        {
            Debug.Log("Switch3 was pressed");
        }
        if (Input.anyKeyDown)
        {
            Debug.Log("something was clicked");
        }
	}
}
