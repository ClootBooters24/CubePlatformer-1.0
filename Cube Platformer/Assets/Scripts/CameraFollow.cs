﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

   public Transform player;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (player == null)
			return;
		transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
	}
}
