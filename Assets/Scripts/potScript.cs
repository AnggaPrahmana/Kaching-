using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potScript : MonoBehaviour {

	public int type;
	public gameManager gM;
	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag=="Player"){
			if(type==1){
				gM.addMoney(100);
			}
			if(type==2){
				gM.addMoney(500);
			}
			if(type==3){
				gM.addMoney(1000);
			}
		}
	}
}
