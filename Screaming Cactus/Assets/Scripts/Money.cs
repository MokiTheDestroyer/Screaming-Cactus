using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Money : MonoBehaviour {

	private LevelManager levelManager;
	private BugSpawner bugSpawner;
	private GameObject winLabel;
	private Text moneyText;
	public static int money;
	public int moneyToWin;

	void Start(){
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		bugSpawner = GameObject.FindObjectOfType<BugSpawner>();
		winLabel = GameObject.Find("YouWin");
		winLabel.SetActive(false);
		moneyText = GetComponent<Text>();
		UpdateMoney();
		
	}

	public void AddMoney(int amount){
		money += amount;
		UpdateMoney();
		if(money >= moneyToWin){
			winLabel.SetActive(true);
			bugSpawner.DestroyBugSpawner();
			Invoke("NextLevel", 3.5f);
		}
	}
	
	public void UpdateMoney(){
		moneyText.text = "$" + money.ToString();
	}
	
	public void ResetMoney(){
		money = 0;
		
	}
	
	public void NextLevel(){
		levelManager.LoadNextLevel();
	}
}
