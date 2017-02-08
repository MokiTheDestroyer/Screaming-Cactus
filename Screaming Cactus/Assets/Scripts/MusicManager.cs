using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public static MusicManager instance = null;
	
	// Use this for initialization
	void Awake(){
		if(instance != null){
			Destroy(gameObject);
		}else{
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
}
