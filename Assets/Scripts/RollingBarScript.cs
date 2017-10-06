using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBarScript : MonoBehaviour {

	// Use this for initialization
	public int type;
	int randomSpeed;
	void Start () {
		randomSpeed = Random.Range(2,4);
	}
	
	// Update is called once per frame
	void Update () {
		if(type == 1){
		transform.Rotate(0,0,randomSpeed);
		}
		if(type == 2){
		transform.Rotate(0,0,-randomSpeed);
		}
	}
}
