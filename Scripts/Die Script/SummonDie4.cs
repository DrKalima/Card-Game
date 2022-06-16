using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SummonDie4 : DiceController
{
    private bool die4 = true;
    public bool pass4 = false;

    public Text summonDie4Text;
    private new void Start()
    {
        if (die4)
        {
            a = 1;
            b = 1;
            c = 1;
            d = 1;
            e = 1;
            f = 1;
        }

        summonDie4Text.text = "";
        
    }

    private void Update()
    {
        if (pass)
        {
            pass4 = true;            
            summonDie4Text.text = "Match";
            if (Input.GetMouseButtonDown(0))
            {
                rolled = false;
                pass = false;
            }
        }
        else if (rolled && !pass)
        {
            summonDie4Text.text = "Fail";
            if (Input.GetMouseButtonDown(0))
            {
                rolled = false;
            }
        }
        else if (!rolled && !pass)
        {
            summonDie4Text.text = "";
        }
    }

    public void eliteDie()
    {
        if (pS.sanityCurrent >= 2)
        {
            Debug.Log("The array list is {" + a + ", " + b + ", " + c + ", " + d + ", " + e + ", " + f + " }");
            Roll();
        }
    }
}
