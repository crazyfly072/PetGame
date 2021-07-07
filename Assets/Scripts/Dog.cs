using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal{

	void Start(){
        player = GameObject.Find("Player");
        rb = GetComponent<Rigidbody>();
    }

    // Polymorphism
    public override void FollowPlayer(){
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        rb.AddForce(lookDirection.normalized * movementSpeed);
    }

    void Update(){
        Vector3 LookAt = new Vector3(player.transform.position.x, player.transform.position.y - 1, player.transform.position.z);
        if(isPlayersPet){
            transform.LookAt(LookAt);
            
            if(Vector3.Distance(transform.position, player.transform.position) < 4){
                FollowPlayer();
                // Inheritance
            }
        }
        if(Random.Range(1, 100) == 100){
            Talk("Woof");
        }
    }
}
