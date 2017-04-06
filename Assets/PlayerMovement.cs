using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : WedgeInteraction1 {
	//this.clicked = clicked; 
	public float speed = 3.0f;
	public static Rigidbody rbody;


	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		rbody.velocity = Vector3.zero;
		rbody.angularVelocity = Vector3.zero;
	}

	void FixedUpdate () {
		if (WedgeInteraction1.clicked) {
			Vector3 cylindarpos = new Vector3 (-16, 2, 10);
			rbody.MovePosition (cylindarpos); 
		}
	}
}
