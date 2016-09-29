using UnityEngine;
using System.Collections;

public class HighlightObject : MonoBehaviour {

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
	}
    public void Highlight()
    {
        GetComponent<Renderer>().material.shader = Shader.Find("Self-Illumin/Outlined Diffuse");
    }

    public void DeHighlight()
    {
        GetComponent<Renderer>().material.shader = Shader.Find("Diffuse");
    }
}
