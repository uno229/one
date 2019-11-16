﻿using System.Collections;
using UnityEngine;

public class spawner : MonoBehaviour {
	public GameObject obj;
	public float spawnMin = 3f;
	public float spawnMax = 2f;

	// Use this for initialization
	void Start () {
		Spawn ();	
	}
	
	// Update is called once per frame
	void Spawn () {
		float rand = Random.Range (0, 1000);
		if (rand > 700) {
			Instantiate (obj, transform.position, Quaternion.identity);

		}
	Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
	}
}
