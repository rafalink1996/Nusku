﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]


public class CaraAmir : MonoBehaviour {

	Image imageComponent;
	public Sprite Sad;
	public Sprite Yay; 

	// Use this for initialization
	void Start () {
		imageComponent = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (ScoreManager.score < Leaderboard.scoreAmir) {
			imageComponent.sprite = Yay;
		} else {
			imageComponent.sprite = Sad; 
		}
	}
}
