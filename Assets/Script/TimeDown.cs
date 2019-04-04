using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDown : MonoBehaviour {
    private static float timer { get; set; }
    private float oldTime;
    public Text TimeTxt;
	// Use this for initialization
	void Start () {
        oldTime = 0;
        timer = 15;
	}
	
	// Update is called once per frame
	void Update () {
        demNguoc();
        //Debug.Log(timer);
        TimeTxt.text = timer.ToString();
	}

    public void demNguoc()
    {        
        if(Time.time - oldTime > 1)
        {
            timer--;
            oldTime = Time.time;
        }        
        if(timer == 0)
        {
            timer = 15;
        }
    }
}
