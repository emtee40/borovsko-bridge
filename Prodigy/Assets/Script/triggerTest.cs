﻿using UnityEngine;
using System.Collections;

/**
 * 	Testing event triggers.
 * 
 */
public class TriggerTest : MonoBehaviour {

	/*
		obj = object being entering the trigger zone. (ie. the camera in our case)
	 */
	void OnTriggerEnter(Collider obj) {
		Debug.Log ("Entering THE DANGER ZONE!!!");
		DroneEvent.triggerDrone();
	}

	void OnTriggerStay (Collider obj){
		Debug.Log ("IT'S DANGEROUS!!");
	}

	void OnTriggerExit (Collider obj){
		Debug.Log ("Leaving THE DANGER ZONE!!!");
	}
}
