using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameManager : MonoBehaviour {

	public Text MoneyBoard;
	public Text CoinBoard;

	public Text HighScoreBoard;
	public GameObject prefabCoin;

	//---------------------
	int Money, Coin, HighScore;
	string highScoreKey = "HighScore";
	// Use this for initialization
	void Start () {
		Money = 0;
		Coin = 5;
		//HighScore = PlayerPrefs.GetInt(highScoreKey,0);
	}
	
	// Update is called once per frame
	void Update () {
		MoneyBoard.text = Money.ToString();
		CoinBoard.text = Coin.ToString();
		//HighScoreBoard = HighScore.ToString();
	}

	public void addMoney(int val){
		Money = Money + val;
	}

	public void addCoin(){
		if(Money>=1000){
			Coin++;
			Money = Money - 1000;
		}
	}

	public void dropCoin(Vector3 dropPoint){
		if(Coin!= 0){
			Coin--;
			GameObject go = (GameObject)Instantiate(prefabCoin);
			go.transform.position = dropPoint;
		}
	}
}
