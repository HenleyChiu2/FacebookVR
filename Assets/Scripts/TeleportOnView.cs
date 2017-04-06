using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TeleportOnView : MonoBehaviour {

	private float timer;
	public float gazeTime = 2f; 
	private bool gazedAt; 
	private CharacterController cc;
	public float speed = 3.0f;
	public Transform vrCamera;
	public GameObject other;
	public int posX = 15;
	public int posY = 10;
	public int posZ = 20;

	void Start () {
		//timer = 0; 
	}

	public void OnGazeEnter(){

	}

	public void OnGazeExit(){

	}


	// Update is called once per frame
	void Update () {
		if (gazedAt == true) {
			timer += Time.deltaTime; 	



			if (timer >= gazeTime) {
				ExecuteEvents.Execute (gameObject, new PointerEventData (EventSystem.current), ExecuteEvents.pointerClickHandler);
				other.transform.position = new Vector3 (posX, posY, posZ);

				timer = 0f; 
//				GetComponent<Collider> ().enabled = false; 

			}
		}



	}

	public void PointerEnter() {
		//Debug.Log ("Pointer Enter");
		gazedAt = true; 
	}
	public void PointerExit() {
		//Debug.Log ("Pointer Exit");
		gazedAt = false; 
	}
	public void PointerClick() {
		//Debug.Log ("Pointer Click");
		//Vector3 forward = vrCamera.TransformDirection(Vector3)
	}

	}

