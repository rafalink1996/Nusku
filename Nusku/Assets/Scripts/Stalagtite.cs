﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stalagtite : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void NotFalling (){
        this.gameObject.tag = "Untagged";
    }
}
