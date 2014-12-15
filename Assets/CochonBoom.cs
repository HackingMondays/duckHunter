using UnityEngine;
using System.Collections;

public class CochonBoom : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void FixedUpdate(){
	}
	public void launch(){
		Rigidbody rigidbody = GetComponent<Rigidbody> ();
		rigidbody.AddForce (new Vector3 (150,200,150));

	}

}
