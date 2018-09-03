using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leveltransitiontimething : MonoBehaviour {
    public float Timer;
    public float CountDownf;
    public int CountDown;
    public bool EnterLevel;
    public float Minutes;
    public int Seconds;

    private int deathtime;

    public Text timethingthongthang;

    public string MinutesText;
    public string SecondsText;

    private bool l;

	// Use this for initialization
	void Start () {
		CountDownf = 30f;
        l = NooksBuksController.isDead;
	}

    // Update is called once per frame
    void Update()
    {
        if (EnterLevel && !NooksBuksController.isDead )
        {
            CountDownf = CountDownf - Time.deltaTime;
            CountDown = Mathf.RoundToInt(CountDownf);
            Seconds = CountDown;
            SecondsText = Seconds.ToString();

            timethingthongthang.text = SecondsText;
            if (!NooksBuksController.isDead && Seconds <= 0)
            {
                timethingthongthang.text = "you Win !!";

            }
        }

        if(NooksBuksController.isDead)
        { 


            
                Debug.Log("met");
                deathtime = Seconds;
            timethingthongthang.text = "you loose";
            Debug.Log("seconds=" + Seconds);
         
        }
       
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "square")
        {
            EnterLevel = true;
        }
    }
}
