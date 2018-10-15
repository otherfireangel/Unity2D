using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int max = 1000;
        int min = 1;

        Debug.Log("The Number Wizard welcomes you to his tower");
        Debug.Log("He instructs you to think of a number");
        Debug.Log("The largest number you may pick is: " + max);
        Debug.Log("The smallest number you may pick is: " + min);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
