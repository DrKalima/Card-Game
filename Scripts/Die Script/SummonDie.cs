using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SummonDie : DiceController
{
    private bool die1 = true;
    public bool pass1 = false;

    public Text summonDie1Text;
    
    private new void Start()
    {
        if (die1) 
        {
            a = 1;
            b = 1;
            c = 1;
            d = 1;
            e = 1;
            f = 1;
        }
        
        summonDie1Text.text = "";

        Button btn = summonDieButton.GetComponent<Button>();
        btn.onClick.AddListener(SummonDieButtonClicked);
    }

    private void Update()
    {
        if (pass)
        {
            pass1 = true;
            summonDie1Text.text = "Match";
            if (Input.GetMouseButtonDown(0))
            {
                rolled = false;
                pass = false;
            }
        }
        else if (rolled && !pass)
        {
            summonDie1Text.text = "Fail";
            if (Input.GetMouseButtonDown(0))
            {
                rolled = false;                
            }
        }
        else if (!rolled && !pass)
        {
            summonDie1Text.text = "";
        }
    }

    private void SummonDieButtonClicked()
    {
        if (pS.sanityCurrent >= 2)
        {
            Debug.Log("The array list is {" + a + ", " + b + ", " + c + ", " + d + ", " + e + ", " + f + " }");
            Roll();
        }
    }

}
