using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloHelen : MonoBehaviour {

    public Text tt;
    
	// Use this for initialization
	void Start () {
        Debug.Log("this is first push2");
        tt.text = "hello imgyu";
    }
	
	// Update is called once per frame
	void Update () {

        tt.text = "hello imgyu";
    }
}
