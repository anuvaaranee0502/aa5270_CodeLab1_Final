﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalGameManager : MonoBehaviour {

	public static FinalGameManager instance;


	//Create a public const for HEALTH_MIN
	//consts are like variable, but they can't 
	//be changed once created
	private const int HEALTH_MIN = 0;
	//public const for HEALTH_MAX
	public const int HEALTH_MAX = 100;

	//public var damageAmt
	public int damageAmt = 10;

	public int numberOfLevels; 

	private static int levelNum;

	public int LevelNum{
		get{
			return levelNum;
		}
		set{
			levelNum = value;

			if (levelNum > numberOfLevels) {
				levelNum = 0;
			}
		}
		
	}

	public Text healthText;

	//public static in health
	//static means this value is the
	//same for all instances of this class
	private static int health;

	//create a Property Health
	//Properties let you wrap get/set
	//of a var with a function
	public int Health{
		get
		{
			return health;
		}

		set
		{
			//set the var "health" to whatever
			//"Health" was set to
			health = value;

			//Make sure health is never more
			//than HEALTH_MAX
			if(health > HEALTH_MAX)
			{
				health = HEALTH_MAX;
			}

			//Make sure health is never less
			//than HEALTH_MIN
			if(health < HEALTH_MIN)
			{
				health = HEALTH_MIN;
			}
		}
	}
		

//Map a key to cause damage
	public KeyCode damageKey;

// Use this for initialization
	void Awake () 
	{
//		LevelNum = 0;

		if(instance == null)
		{
			instance = this;
			DontDestroyOnLoad(this);
		}
		else
		{
			Destroy(gameObject);
		}
	//print the score from the static instance of Wk3GameManager
	//		Debug.Log("Current Score: " + Wk3GameManager.instance.Score);

	//start with max health
		Health = HEALTH_MAX;

//		ll = levelLoader.GetComponent<LevelLoader> ();
		//GameObject walls = Instantiate (Resources.Load ("Prefab/Walls")) as GameObject;
	}

// Update is called once per frame
	void Update () 
	{
		print (levelNum);
		if (health <= 0){

			LevelNum++;
			//ReloadScene ();
		}

		//healthText.text = health.ToString ();
	//if the damageKey was pressed
		if(Input.GetKeyDown(damageKey)){
			//damage the ship by using the property "Health"
			Health -= damageAmt;
			//Print out the Health after damage was assigned
//			print(name + " Current Health: " + health);
		}

		if (Input.GetKeyDown(KeyCode.B)){
			LevelNum++;
		}
	

	}

//	public void ReloadScene(){
//	SceneManager.LoadScene ("aa5270_CodeLab1_Midterm");
		



}
