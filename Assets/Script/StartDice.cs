using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartDice : MonoBehaviour {
    public GameObject cv;
    public Text ThongBao;
    public GameObject DiceObj;
    public static float TimeChooseButton { get; set; }
    bool run;
	// Use this for initialization
	void Start () {
        TimeChooseButton = 0;
        run = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(run)
        {
            Debug.Log("Run true");            
            Debug.Log(Time.time - TimeChooseButton);
            if (Time.time - TimeChooseButton > 10 && Time.time - TimeChooseButton < 11)
            {
                Debug.Log("Dem nguoc xem mat xuc xac");
                DiceObj.GetComponent<Dice>().GetPosition();
                run = false;
            }
            
        }
	}

    public void clickBtn()
    {
        
        if (Controller.ChooseDice != 6)
        {
                Time.timeScale = 1;
                run = true;
                TimeChooseButton = Time.time;
                DiceObj.GetComponent<Rigidbody>().useGravity = true;
                ThongBao.text = "";              
        }
        else
        {

                ThongBao.text = "Bạn chưa chọn cửa";

        }
    }
}
