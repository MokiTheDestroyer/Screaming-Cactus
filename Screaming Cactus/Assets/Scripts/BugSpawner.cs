using UnityEngine;
using System.Collections;

public class BugSpawner : MonoBehaviour {
	
	public GameObject[] bugArray;
	public float bugSpawnDifficulty = 1;
	
	
	
	void Update () {
	
		foreach(GameObject thisBug in bugArray){
			if(isTimeToSpawn(thisBug)){
				SpawnPosition(thisBug);
			}
		}
	}
	
	
	bool isTimeToSpawn(GameObject bugGameObject){
		Position bug = bugGameObject.GetComponent<Position>();
		
		float meanSpawnDelay = bug.howOftenSeen;
		float spawnsPerSecond = bugSpawnDifficulty / meanSpawnDelay;
		
		if(Time.deltaTime > meanSpawnDelay){
			Debug.LogWarning("Spawn rate capped by frame rate");
		}
		
		float threshold = spawnsPerSecond * Time.deltaTime / 2;
		
		return(Random.value < threshold);
	}
	
 	
 	void SpawnPosition(GameObject bug){
 		float xposition = Random.Range(-1f, 1f);
 		float yposition = Random.Range(-2.5f, 3.5f); 
 		GameObject spawnedPosition = Instantiate(bug, new Vector3(xposition, yposition, 0), Quaternion.identity) as GameObject;
 		spawnedPosition.transform.parent = transform;
 		
 	}
 	
 	public void DestroyBugSpawner(){
 		Destroy(gameObject);
 	}
 	
	
}
