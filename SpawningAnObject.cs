// Programmed by Shashank.S - creator of SandS Arts. Mail me at - sandsarts.developer@gmail.com
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningAnObject : MonoBehaviour {
public GameObject playerobj;
public Transform spawnpoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("w"))
		Instantiate(playerobj,spawnpoint.position,spawnpoint.rotation);
	}
}
