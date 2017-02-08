using UnityEngine;
using System.Collections;

public class Bug : MonoBehaviour {

	public int health;
	public int worth;
	public GameObject bugSplat;

	private CactusHealth cactus;
	private Money money;
	private Position position;
	
	void Start(){
		cactus = GameObject.FindObjectOfType<CactusHealth>();
		money = GameObject.FindObjectOfType<Money>();
		position = GameObject.FindObjectOfType<Position>();
	}

	public void BiteCactus(int damage){
		cactus.KillCactus(damage);
	}

	void OnMouseDown(){
		health -= 1;
		if(health == 0){
			Instantiate(bugSplat, transform.position, Quaternion.identity);
			money.AddMoney(worth);
			position.DestroyPosition();
			Destroy(gameObject);
		}
	}
	
}
