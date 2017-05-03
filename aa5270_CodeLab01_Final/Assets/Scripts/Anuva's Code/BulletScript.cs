using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	// Use this for initialization
	private void OnEnable () {

		transform.GetComponent<Rigidbody> ().WakeUp ();
		Invoke ("hideBullet", 2f);

	}

	void hideBullet(){
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	private void OnDisable () {

		transform.GetComponent<Rigidbody> ().Sleep();
		CancelInvoke ();
		
	}


	void OnCollisionEnter(Collision col){
		if (col.transform.tag == "Enemy")
		{
			Destroy (col.gameObject);
			gameObject.SetActive (false);
		}
	}
}
