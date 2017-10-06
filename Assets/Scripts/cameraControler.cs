using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControler : MonoBehaviour {

	// Use this for initialization
	public Camera CameraMain;
	Vector3 topPos,downPos;
	float speed;
	int state;
	void Start () {
		speed = 0f;
		state = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(state==1){
			//float goDown = CameraMain.transform.position.x;
			//goDown -= speed;
			CameraMain.transform.position = new Vector3(CameraMain.transform.position.x,12f,CameraMain.transform.position.z);
			//if(CameraMain.transform.position.y<=12){
			//	speed = 0f;
			//}
		}
		if(state==2){
			//float goTop = CameraMain.transform.position.x;
			//goTop += speed;
			CameraMain.transform.position = new Vector3(CameraMain.transform.position.x,18f,CameraMain.transform.position.z);
			//if(CameraMain.transform.position.y>=18){
			//	speed = 0f;
			//}
		}
	}

	public void changeState(int val){
		state = val;
	}

	public void changeSpeed(float val){
		speed = val;
	}
}
