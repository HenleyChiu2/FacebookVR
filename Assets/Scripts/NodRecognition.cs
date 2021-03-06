﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodRecognition : MonoBehaviour {
	private Vector3[] angles;
	private int index;
	private Vector3 centreAngle; 
	public GameObject responsiveObject; 

	// Use this for initialization
	void Start () {
		ResetGesture ();
	}
	
	// Update is called once per frame
	void Update () {
		angles [index] = GvrViewer.Instance.HeadPose.Orientation.eulerAngles;
		index++;
		if (index == 80) { //checks the angle every 80 frames?
			CheckMovement ();
			ResetGesture ();
		}
	}

	void CheckMovement() {
		bool right = false, left = false, up = false, down = false; 
		for (int i = 0; i < 80; i++) {
			if (angles [i].x > centreAngle.x + 15.0f && !up) {
				up = true; 
			} else if (angles [i].x < centreAngle.x - 15.0f && !down) {
				down = true; 
			} else if (angles [i].y < centreAngle.y - 15.0f && !left) {
				left = true; 
			} else if (angles [i].y > centreAngle.y + 15.0f && !right) {
				right = true; 
			}
		}
		//nod
		if (down) {
			print ("User nodded"); 
			//for tutorial purposes
			responsiveObject.GetComponent<Renderer>().sharedMaterial.color = Color.green; 
		}

		if (left) {
			print ("User looked left"); 
			//fill in 
			//for tustorial purposes
			responsiveObject.GetComponent<Renderer>().sharedMaterial.color = Color.blue;
		}
		if (up) {
			print ("User looked up"); 
			//fill in
			responsiveObject.GetComponent<Renderer>().sharedMaterial.color = Color.red;
		}
		if  (right) {
			print ("User looked right"); 
			//fill in
			//for tutorial purposes
			responsiveObject.GetComponent<Renderer>().sharedMaterial.color = Color.yellow;
		}

	}

	void ResetGesture(){
		angles = new Vector3[80];
		index = 0;
		centreAngle = GvrViewer.Instance.HeadPose.Orientation.eulerAngles;
	}
		
}
