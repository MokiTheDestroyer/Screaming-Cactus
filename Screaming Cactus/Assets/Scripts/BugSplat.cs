using UnityEngine;
using System.Collections;

public class BugSplat : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("DestroySplat", 2f);
	}
	
	void DestroySplat(){
		Destroy(gameObject);
	}
	
	
}
