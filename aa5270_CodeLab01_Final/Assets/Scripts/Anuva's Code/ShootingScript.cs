using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour {

	public float bulletSpeed = 100;
	public GameObject bullet;
	GameObject player;

	List<GameObject> bulletList;

	// Use this for initialization
	void Start () {
		bulletList = new List<GameObject> ();
		for (int i = 0; i < 20; i++){
			GameObject bullet = Instantiate(Resources.Load("Prefab/Bullet")) as GameObject;
			bullet.SetActive (false);
			bulletList.Add (bullet);
			}
		
	}

	void Fire(){

		for (int i = 0; i < bulletList.Count; i++) {
			if (!bulletList [i].activeInHierarchy) {
				bulletList [i].transform.position = transform.position + new Vector3(0,0.25f,0);
				bulletList [i].transform.rotation = transform.rotation;
				bulletList [i].SetActive (true);
		
				Rigidbody rb = bulletList [i].GetComponent<Rigidbody> ();
				rb.velocity = Vector3.zero;
				rb.AddForce (Vector3.up * bulletSpeed);
				break;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			Fire ();
			//GetComponent<BasicGun>().Fire(Vector3.left, Vector3.zero);
		}
	}
}
