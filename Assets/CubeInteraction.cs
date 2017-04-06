using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CubeInteraction : MonoBehaviour {

	private float timer;
	public float gazeTime = 2f; 
	private bool gazedAt; 

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

				Transform child = transform.GetChild (0);
				Vector3 newScale = new Vector3(2,2,2);
				child.localScale = newScale; 

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
	}
}
