﻿using UnityEngine;
using System.Collections;

public class SnappingCrane: MonoBehaviour {
	public bool Snatch;
	 // Reference to the animator bool to trigger the state.

	private Animator anim;		// Reference to the animator component.
	private GameObject player;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		anim = GetComponent<Animator>();
	}

	void OnTriggerEnter (Collider other){
		anim.SetBool("Snatch", true);
			}

	void OnTriggerExit (Collider other){
		anim.SetBool ("Snatch", false);
			}


}
