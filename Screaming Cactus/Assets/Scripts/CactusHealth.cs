using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CactusHealth : MonoBehaviour {

	private GameObject loseLabel;
	private LevelManager levelManager;

	private Text healthText;
	public static int health = 100;
	
	void Start(){
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		loseLabel = GameObject.Find("YouLose");
		loseLabel.SetActive(false);
		healthText = GetComponent<Text>();
		UpdateHealth();
	}
	
	void Update(){
		if(health <= 0){
			Dead();
		}else{
			UpdateHealth();
		}
	}
	
	public void UpdateHealth(){
		healthText.text = health.ToString();
	}
	
	public void KillCactus(int damage){
		health -= damage;
		if(health <= 0){
			loseLabel.SetActive(true);
			Invoke("LevelLoad", 3.5f);
			Dead();
			return;
		}
		UpdateHealth();
	}
	
	public void AddHealth(){
		health += 10;
		
	}
	
	void LevelLoad(){
		levelManager.LoadLevel("LoseScreen");
	}
	
	public void Dead(){
		healthText.text = "DEAD!";
	}
	
	public void ResetHealth(){
		health = 100;
		
	}
	
}
