using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SummonDie2 : DiceController
{
    private bool die2 = true;
    public bool pass2 = false;

    public Text summonDie2Text;
    private new void Start()
    {
        if (die2)
        {
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            e = 0;
            f = 0;
        }

        summonDie2Text.text = "";

        Button btn = summonDieButton.GetComponent<Button>();
        btn.onClick.AddListener(SummonDieButtonClicked);
    }

    private void Update()
    {
        if (pass)
        {
            pass2 = true;
            summonDie2Text.text = "Match";
            if (Input.GetMouseButtonDown(0))
            {
                rolled = false;
                pass = false;
            }
        }
        else if (rolled && !pass)
        {
            summonDie2Text.text = "Fail";
            if (Input.GetMouseButtonDown(0))
            {
                rolled = false;
            }
        }
        else if (!rolled && !pass)
        {
            summonDie2Text.text = "";
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
