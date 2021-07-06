using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour{

    public float movementSpeed = 100;
    public float jumpForce = 300;
    Animator anim;
    public Rigidbody rb;
    public GameObject player;
    public bool isPlayersPet;
    
    void Start(){
        player = GameObject.Find("Player");
        anim = GetComponent<Animator>();
    }
    public void FollowPlayer(){
        if(player != null){
            Vector3 lookDirection = (player.transform.position - transform.position).normalized;
            rb.AddForce(lookDirection.normalized * movementSpeed);
        }else{
            Debug.Log("Null");
        }
    }
}