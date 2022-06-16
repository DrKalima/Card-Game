using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public mMP2Stats MMp2Stats;
    public mMP1Stats MMp1Stats;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.forward, out hit, 1))
        {
            if (hit.collider.CompareTag("Minor Minion P2"))
            {
                combatPhasemMP2();
                dufonCheck();
            }
        }
    }

    private void dufonCheck()
    {
        MMp1Stats.mMP1dufon();
        MMp2Stats.mMP2dufon();
    }

    private void combatPhasemMP2()
    {
        MMp2Stats.mMP2DefCurrent -= MMp1Stats.mMP1ToughCurrent;
    }
}
