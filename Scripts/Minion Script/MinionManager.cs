using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionManager : MonoBehaviour
{
    public GameObject minorMinion;
    public GameObject majorMinion;
    public GameObject eliteMinion;

    private GameObject tileParent;
   
    public Stats pS;
    public TileScript tS;
    public DiceController dC;
    public SummonDie sD;
    public SummonDie2 sD2;
    public SummonDie3 sD3;
    public SummonDie4 sD4;    

    // Update is called once per frame
    void Update()
    {
        if (sD.pass1 && sD2.pass2)
        {
            //Debug.Log("dice pass 1 & 2");
            tS.selectable = true;
            summonMinorMinion();
        }
        else if (sD.pass1 && sD3.pass3)
        {
            //Debug.Log("dice pass 1 & pass 3");
            tS.selectable = true;
            summonMinorMinion();
        }
        else if (sD2.pass2 && sD3.pass3)
        {
            //Debug.Log("dice pass 2 & 3");
            tS.selectable = true;
            summonMinorMinion();
        }
        else if(sD.pass1 && sD2.pass2 && sD3.pass3)
        {
            sD4.eliteDie();
            if (sD4.rolled && sD4.pass4)
            {
                summonEliteMinion();
            }
            else if(sD4.rolled && !sD4.pass4)
            {
                summonMajorMinion();
            }
        }
    }

    protected void summonMinorMinion()
    {
        //Debug.Log("Inside summon()"); 
        
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Player 1 Summon Tile")
                {
                    tileParent = hit.collider.gameObject;
                    
                    Debug.Log("The transform location of hit tile is " + tileParent.transform);
                    tS.target = true;
                    Instantiate(minorMinion, tileParent.transform.position + new Vector3 (0, 1, 0) , Quaternion.identity, tileParent.transform);                    
                }
                tS.target = false;
                tileParent = null;
            }

            sD.pass1 = false;
            sD2.pass2 = false;
            sD3.pass3 = false;
            sD4.pass4 = false;            
        }
    }

    protected void BattleMode()
    {
        
    }

    protected void summonMajorMinion()
    {
        throw new NotImplementedException();
    }

    protected void summonEliteMinion()
    {
        throw new NotImplementedException();
    }    
}
