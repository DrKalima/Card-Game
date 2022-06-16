using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class DiceController : MonoBehaviour
{
    public Stats pS;
    public SummonDie sD;
    public SummonDie2 sD2;
    public SummonDie3 sD3;
    public SummonDie4 sD4;

    public bool pass = false;
    public bool rolled = false;

    //var for dice list
    public int a, b, c, d, e, f;

    public int sanityCost = 2;

    public Button summonDieButton;
    public Button wildDieButton;
    public void Start()
    {
        Button btn = summonDieButton.GetComponent<Button>();
        btn.onClick.AddListener(SummonDieButtonClicked);        
    }

    protected void Roll()
    {
        var r = new System.Random();
        var myList = new List<int> { a, b, c, d, e, f };
        var myListResult = myList.OrderBy(item => r.Next());

        int count = myListResult.Count();
        int IndexVal = r.Next(count);
        int Result = myList[IndexVal];

        Debug.Log("The var.count pos is " + IndexVal);
        Debug.Log("Roll 1 is " + Result);

        if (Result == 1)
        {
            var myList2 = new List<int> { 0, 1 };

            int count2 = myList2.Count;
            int cC = r.Next(count2);
            int result2 = myList2[cC];

            Debug.Log("Roll 2 is " + result2);

            if (result2 == 1)
            {
                pass = true;
                //Debug.Log("Roll 2 Pass");                
            }
            else
            {
                //Debug.Log("Roll 2 failed");
            }
        }
        else
        {
            //Debug.Log("Roll 1 fail");
        }
    }
    private void SummonDieButtonClicked()
    {
        if (pS.sanityCurrent >= 2)
        {
            rolled = true;
            pS.sanityCurrent -= sanityCost;            
        }
    }
    
}
