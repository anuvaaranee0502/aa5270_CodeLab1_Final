using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	public Transform enemy;
	public Transform position1;
	public Transform position2;
	public Vector3 newPosition;
	public string currentState;
	public float smooth;
	public float resetTime;

	// Use this for initialization
	void Start () {
		ChangedTarget ();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		enemy.position = Vector3.Lerp (enemy.position, newPosition, smooth * Time.deltaTime);
		
	}

	void ChangedTarget(){
		if(currentState == "Moving to Position 1"){
			currentState = "Moving to Position 2";
			newPosition = position2.position;
			
		}
		else if (currentState == "Moving to Position 2"){
			currentState = "Moving to Position 1";
			newPosition = position1.position;
			
		}
		else if (currentState == ""){
			currentState = "Moving to Position 2";
			newPosition = position2.position;
			
		}

		Invoke ("ChangedTarget", resetTime);
	}
}
