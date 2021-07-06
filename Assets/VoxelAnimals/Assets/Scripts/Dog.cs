using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal{

	void Start(){
		player = GameObject.Find("Player");
		rb = GetComponent<Rigidbody>();
	}

    void Update(){
    	Vector3 LookAt = new Vector3(player.transform.position.x, player.transform.position.y - 1, player.transform.position.z);
        if(isPlayersPet){
        	transform.LookAt(LookAt);
        	FollowPlayer();
        }
    }
}
