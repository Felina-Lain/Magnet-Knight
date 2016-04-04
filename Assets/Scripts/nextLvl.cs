using UnityEngine;
using System.Collections;

public class nextLvl : MonoBehaviour {

	public 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnCollisionEnter () {
		int i = Application.loadedLevel;
		Application.LoadLevel(i + 1);

	}
}
