using UnityEngine;
using System.Collections;

public class Position : MonoBehaviour {

	public GameObject bug;
	public float howOftenSeen;
	
	void Start(){
		SpawnBugImage();
	}

	void OnDrawGizmos(){
		Gizmos.DrawWireSphere(transform.position, 0.5f);
	}
	
	void SpawnBugImage(){
		GameObject spawnedBug = Instantiate(bug, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
		spawnedBug.transform.parent = transform;
		spawnedBug.transform.position = transform.position;
	}
	
	public void DestroyPosition(){
	if(gameObject.transform.childCount == 0){
		Destroy(gameObject);
		}
	}
}
