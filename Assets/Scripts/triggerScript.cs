using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScript : MonoBehaviour {

	// Use this for initialization
	public int type;
	public cameraControler cC;
	void Start () {
		
	}
	
	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag=="Player"){
			if(type == 1){
				cC.changeSpeed(0.00001f);
				cC.changeState(type);
			}
			if(type == 2){
				cC.changeSpeed(0.00001f);
				cC.changeState(type);
				Destroy(col.gameObject);
			}
		}
	}
}
