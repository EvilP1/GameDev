using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class LaptopController : MonoBehaviour {

    public Text timeText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeText.text = string.Format("{0}:{1:00}", (int)Time.timeSinceLevelLoad / 60, (int)Time.timeSinceLevelLoad % 60);


    }
}
