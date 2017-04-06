using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookBack : MonoBehaviour {

	public Transform vrCamera; 
	public Transform moveCamera; 
	public float toggleAngle = -30.0f; 
	public float speed = 3.0f; 
	public int posX = 0;
	public int posY = 3; 
	public int posZ = 0; 

	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (vrCamera.eulerAngles.x > -30.0f && vrCamera.eulerAngles.x < -90.0f) {
			Debug.Log ("Movement");
			moveCamera.transform.position = new Vector3(posX, posY, posZ); 
		}
	}
}
