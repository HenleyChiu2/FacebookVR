using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour {
	public Transform vrCamera;
	public static float speed = 3.0f;
	public bool moveForward; 
	private static CharacterController cc;
	

	void Start () {
		cc = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () { 
			
	}
	public static void move() {
		Vector3 yellowcylindar = new Vector3 (-16, 2, 10);
		cc.SimpleMove (yellowcylindar * speed);
	}
}
