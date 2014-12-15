using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private GameObject cochon;
	private float nextCochon ;

	// Use this for initialization
	void Start () {
		cochon = Resources.Load ("ultimateCochon") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		nextCochon -= Time.deltaTime;
		if (nextCochon < 0) {
			Debug.Log ("Next COCHON");
			nextCochon = 2;
			lancerLeCochon();
		}
	}

	void lancerLeCochon(){
		GameObject go = Instantiate (cochon, new Vector3 (-3.225112f, -0.3524987f, -0.7468691f), Quaternion.identity) as GameObject;
		go.SetActive (true);

		Rigidbody rigidbody = go.AddComponent<Rigidbody> ();
		//Rigidbody rigidbody = go.GetComponent<Rigidbody> ();
		rigidbody.AddForce (new Vector3 (150,200,150));

	}
}
