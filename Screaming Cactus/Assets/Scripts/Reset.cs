using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {

	private Money money;
	private CactusHealth cactusHealth;

	// Use this for initialization
	void Start () {
		money = GameObject.FindObjectOfType<Money>();
		cactusHealth = GameObject.FindObjectOfType<CactusHealth>();
		money.ResetMoney();
		cactusHealth.ResetHealth();
	}

}
