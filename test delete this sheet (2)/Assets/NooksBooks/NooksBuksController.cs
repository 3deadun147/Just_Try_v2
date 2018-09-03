using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NooksBuksController : MonoBehaviour
{
    public Animator anim;
    public float speed = 8f;
    private float jump = 20f;
    public Rigidbody2D Player;
    private float Timer;
    public GameObject Ananas;
  static public   bool isDead;
    public GameObject cow;
    public GameObject nyannyancat;
    public GameObject nyannyancat2;
    public GameObject square;
    public GameObject Boss1;
    public GameObject Boss2;

   
    // Use this for initialization
    void Start()
    {
  
        anim = GetComponent<Animator>();
        Player = GetComponent<Rigidbody2D>();
       
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        Timer += Time.deltaTime;
        float x = Input.GetAxis("Horizontal");
        anim.SetFloat("speed", Mathf.Abs(x));

        if (isDead == true && (Input.GetKeyDown(KeyCode.R)))
        {
            restartCurrentScene();
            return;
            
            
        }
            
        if (x > 0 && !isDead)
        {
            speed = 6f;
            transform.Translate(Vector3.right * speed * Time.deltaTime );
            transform.eulerAngles = new Vector2(0, 0);
        }
        if (x < 0 && !isDead)
        {
            speed = 6f;
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 180);
        }
        if (x == 0)
        {
            speed = 0;
        }
       
        if (Input.GetKeyDown(KeyCode.Space) && Timer>0.3f && !isDead)
        {
            //Add UP force to the bird
            Player.AddForce(Vector2.up * jump , ForceMode2D.Impulse);
            Timer = 0f;
            anim.SetTrigger("Jump");
        }
        if (transform.position.x < 3.22)
        {
            Ananas.SetActive(true);
            
        }
        anim.SetFloat("speed", speed);

        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag== "deadly")
        {
            GetComponent<Animator>().SetBool("Dies", true);
            anim.SetBool("Dies", true);
            isDead = true;
             
            


        }
        if (col.gameObject.tag == "Cow")
        {
            Debug.Log("aaaaa");
            cow.SetActive(true);
        }
       
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag== "nyannyancat")
        {
            Debug.Log("aaaaa");
            nyannyancat.SetActive(true);
        }
        if (collision.gameObject.tag == "nyannycat2")
        {
            Debug.Log("aaaaa");
            nyannyancat2.SetActive(true);
        }
        if (collision.gameObject.tag == "square")
        {
            square.SetActive(true);
        }
        if (collision.gameObject.tag == "boss")
        {
            Boss1.SetActive(true);
            Boss2.SetActive(true);
        }

    }

    public void restartCurrentScene()
{
        isDead = false;
    Scene scene = SceneManager.GetActiveScene();
    SceneManager.LoadScene(scene.name);
}
}



  

