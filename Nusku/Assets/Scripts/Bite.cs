﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bite : MonoBehaviour {

    public float speed;
    float scale = 0.04f;

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 2f);
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(speed * Time.deltaTime, 0, 0);
        transform.localScale += new Vector3(scale, scale, scale);
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Invoke("DisableCollider", 0.1f); 
        }
    }
    void DisableCollider ()
    {
        GetComponent<BoxCollider2D>().enabled = false;
    }
}
