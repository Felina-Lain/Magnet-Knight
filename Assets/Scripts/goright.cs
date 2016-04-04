using UnityEngine;
using System.Collections;

public class goright : MonoBehaviour {

	public int moveright;

	// Use this for initialization
	void Start () {

		moveright = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")){
			moveright =1;
		}

		if (moveright%2 == 1){
			transform.position += Vector3.right * Time.deltaTime;
		}

	}
}
