﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelHealth : MonoBehaviour
{

    public Slider healthSlider;
    bool invincible = false;
    Animator anim;
    PlayerMovement2D sel;
    GameObject arm;
    SpriteRenderer body;
    SpriteRenderer armG;
 
    // Use this for initialization
    void Start()
    {
        healthSlider = GameObject.Find("Canvas/HUD/Health").GetComponent<Slider>();
        anim = GetComponentInChildren<Animator>();
        sel = FindObjectOfType<PlayerMovement2D>();
        arm = GameObject.Find("Sel/Graphics/Arm");
        body = GetComponentInChildren<SpriteRenderer>();
        armG = this.transform.Find("Graphics/Arm").gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        armG.color = body.color;
        if (healthSlider.value <= 0)
        {
            anim.SetBool("Dead", true);
            sel.canMove = false;
            arm.SetActive(false);
            body.color = Color.white;
            StopCoroutine("Flashing");
        }
    }

    public void TakeDamage (int damageTaken)
    {
        if (invincible == false)
        {
            healthSlider.value = healthSlider.value - damageTaken;
            invincible = true;
            StartCoroutine("Flashing");
            Invoke("ResetInvincibility", 2.5f);
        }
    }
    IEnumerator Flashing()
    {
        for (int i = 0; i < 30; i++)
        {
            body.color = new Color(255, 255, 255, 0);
            yield return new WaitForSeconds(.1f);
            body.color = Color.white;
            yield return new WaitForSeconds(.1f);
        }
    }
    void ResetInvincibility()
    {
        invincible = false;
        StopCoroutine("Flashing");
        body.color = Color.white;
    }
}
