using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Animal : MonoBehaviour{

    public float movementSpeed;
    public float jumpForce;
    Animator anim;
    public Rigidbody rb;
    public GameObject player;
    public bool isPlayersPet;
    private int m_Age = 3;
    TextMeshPro talkText;

    // Encapsulation
    public int age{
        get { return m_Age; }
        set {
            if (value < 0.0f){
                Debug.LogError("Can't Set to Negative Age");
            }else{
                m_Age = value;
            }
        }
    }
    
    void Start(){
        talkText = gameObject.GetComponent<TextMeshPro>();
        player = GameObject.Find("Player");
        anim = GetComponent<Animator>();
    }
    // Abstraction
    public virtual void FollowPlayer(){
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        rb.AddForce(lookDirection.normalized * movementSpeed);
    }
    public virtual void Talk(string Text){
        talkText.SetText(Text);
    }
}