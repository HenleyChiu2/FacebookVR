using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WedgeInteraction1 : MonoBehaviour {

	public float timer;
	public float gazeTime = 2f; 
	public bool gazedAt; 
	public bool clicked; 


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



				timer = 0f; 
				GetComponent<Collider> ().enabled = false; 

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
		Debug.Log ("Pointer Click");
		clicked = true;
		Vector3 cylindarpos = new Vector3 (-16, 2, 10);
		PlayerMovement.rbody.MovePosition (cylindarpos);


	}
}
