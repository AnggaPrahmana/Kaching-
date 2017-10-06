using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropPointScript : MonoBehaviour {

	Vector3 thisPosition;
	public gameManager gM;
	// Use this for initialization
	void Start () {
		thisPosition = transform.position;
	}
	
	// Update is called once per frame

	void OnMouseDown(){
		gM.dropCoin(thisPosition);
	}
}
