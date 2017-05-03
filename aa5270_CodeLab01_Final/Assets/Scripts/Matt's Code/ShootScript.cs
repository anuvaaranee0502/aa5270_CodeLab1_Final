using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour {
	

	public float moveSpeed = 100;
	GameObject player;



	// Use this for initialization
	void Start () {
		
		Rigidbody rb = GetComponent<Rigidbody>();

		transform.position = player.transform.position + new Vector3(0, 1, 0);
		rb.velocity = Vector3.zero;
		rb.AddForce(Vector3.up * moveSpeed);

		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Space)){ 
			GameObject bullet = ObjectPool.GetFromPool(Poolable.types.BULLET);
		}
	}
}
