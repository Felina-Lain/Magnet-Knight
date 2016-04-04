using UnityEngine;
using System.Collections;

public class magnets : MonoBehaviour {

	public GameObject Target;
	public bool magnetoff;
	public float speed;
	public Transform snappoint;
	public GameObject Decoy;
	public bool inRange;
	public Material OffMat;
	public Material OnMat;

	// Use this for initialization
	void Start(){

		Target = GameObject.FindWithTag("Player");
	}

	void Update () {
		if (magnetoff){gameObject.transform.parent.GetComponent<Renderer>().material = OffMat;}else{gameObject.transform.parent.GetComponent<Renderer>().material = OnMat;}

		if (magnetoff == false && inRange){
			Target.GetComponent<Rigidbody>().isKinematic = true;
			Magnetizer ();
		}else{
			Target.GetComponent<Rigidbody>().isKinematic = false;}


	
	}

	void OnTriggerStay (Collider col_){
		if (col_.tag == "Player") {
			Target = col_.gameObject;
			inRange = true;
			//Target.GetComponent<Rigidbody>().useGravity = false;
		}
	}

	void OnTriggerExit (Collider col_){
		if (col_.tag == "Player") {
			inRange = false;
			//Target.GetComponent<Rigidbody>().useGravity = true;
			Target = Decoy;
		}
	}
	
	// Update is called once per frame
	void OnMouseOver() {
		if (Input.GetMouseButtonDown (1)) {	magnetoff = !magnetoff;	}
			
		}

	void Magnetizer () {

		float step = speed * Time.deltaTime;
		Target.transform.position = Vector3.MoveTowards(Target.transform.position, snappoint.transform.position, step);

	}

}