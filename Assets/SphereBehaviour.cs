using UnityEngine;
using System.Collections;

public class SphereBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate(){
		Debug.Log ("Fire1" + Input.GetButtonDown ("Fire1"));
		if (Input.GetButtonDown ("Fire1")) {
			Rigidbody rigidbody = GetComponent<Rigidbody> ();
			rigidbody.AddForce (new Vector3 (300,200,100));
		}
	}
}
