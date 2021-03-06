﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour {

    private AudioSource AS;
    public AudioClip BladeSound;

	// Use this for initialization
	void Start () {
        AS = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider col)
    {
        switch (col.gameObject.tag)
        {
            case "Enemy":
                AS.PlayOneShot(BladeSound);

                print("EnemyHit");
                break;
        }
    }

}
