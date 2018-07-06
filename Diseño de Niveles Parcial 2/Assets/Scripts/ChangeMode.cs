using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMode : MonoBehaviour {
    public GameObject Probilder;
    public GameObject Level;
    private bool switchState;
	// Use this for initialization
	void Start () {
        Probilder.SetActive(false);
        Level.SetActive(true);
        switchState = false;

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.C) && !switchState)
        {
            Probilder.SetActive(true);
            Level.SetActive(false);
            switchState = true;
        }else 
        if (Input.GetKeyDown(KeyCode.C) && switchState)
        {
            Probilder.SetActive(false);
            Level.SetActive(true);
            switchState = false;
        }
    }
}
