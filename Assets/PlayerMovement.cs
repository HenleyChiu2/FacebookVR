using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed = 3.0f;
	Rigidbody rbody;


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
		if(Input.touchCount>0||Input.GetMouseButton(0))
			rbody.MovePosition(transform.position+transform.forward*Time.deltaTime*speed);
	}
}
