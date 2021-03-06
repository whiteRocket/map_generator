﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject player;
    int[] spodnjaLeva;
    int[] zgornjaDesna;
    // Use this for initialization
    void Start () {
        spodnjaLeva = new int[2];
        zgornjaDesna = new int[2];

        spodnjaLeva[0] = -5;
        spodnjaLeva[1] = -3;

        zgornjaDesna[0] = 5;
        zgornjaDesna[1] = 3;
    }
	
	// Update is called once per frame
	void LateUpdate () {

        if (player.GetComponent<Transform>().position.x > zgornjaDesna[0])
        {
            GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x + 10.0f, 
                GetComponent<Transform>().position.y, GetComponent<Transform>().position.z);

            zgornjaDesna[0] += 10;
            spodnjaLeva[0] += 10;
        }

        if (player.GetComponent<Transform>().position.x < spodnjaLeva[0])
        {
            GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x - 10.0f,
                GetComponent<Transform>().position.y, GetComponent<Transform>().position.z);

            zgornjaDesna[0] -= 10;
            spodnjaLeva[0] -= 10;
        }

        if (player.GetComponent<Transform>().position.y < spodnjaLeva[1])
        {
            GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x,
               GetComponent<Transform>().position.y - 6.0f, GetComponent<Transform>().position.z);

            zgornjaDesna[1] -= 6;
            spodnjaLeva[1] -= 6;
        }

        if (player.GetComponent<Transform>().position.y > zgornjaDesna[1])
        {
            GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x,
               GetComponent<Transform>().position.y + 6.0f, GetComponent<Transform>().position.z);

            zgornjaDesna[1] += 6;
            spodnjaLeva[1] += 6;
        }
    }
}
