using UnityEngine;
using System.Collections;

public class destroyout : MonoBehaviour {

	public GameObject playerobj;
	public GameObject playerfab;
	public Transform startingpos;
	private GameObject clone;

	// Use this for initialization
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			Destroy(other.gameObject);
		}
	
	}
	
	// Update is called once per frame
	void Update () {

		playerobj = GameObject.FindWithTag ("Player");
		if (playerobj == null) {
		
			clone = Instantiate(playerfab, startingpos.position, startingpos.rotation) as GameObject;
		}
	
	}
}
