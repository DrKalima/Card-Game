using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SummonDie3 : DiceController
{
    private bool die3 = true;
    public bool pass3 = false;

    public Text summonDie3Text;
    private new void Start()
    {
        if (die3)
        {
            a = 1;
            b = 1;
            c = 1;
            d = 1;
            e = 1;
            f = 1;
        }

        summonDie3Text.text = "";

        Button btn = summonDieButton.GetComponent<Button>();
        btn.onClick.AddListener(SummonDieButtonClicked);
    }

    private void Update()
    {
        if (pass)
        {
            pass3 = true;
            summonDie3Text.text = "Match";
            if (Input.GetMouseButtonDown(0))
            {
                rolled = false;
                pass = false;
            }
        }
        else if (rolled && !pass)
        {
            summonDie3Text.text = "Fail";
            if (Input.GetMouseButtonDown(0))
            {
                rolled = false;
            }
        }
        else if (!rolled && !pass)
        {
            summonDie3Text.text = "";
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
