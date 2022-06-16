using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsReplenish : MonoBehaviour
{
    public Stats s;

    public bool alive = false;
    public bool coStart = false;

    void Start()
    {
        Debug.Log("Inside StatReplenish");
        alive = true;
             
    }

    public IEnumerator RefillStatsS()
    {
        Debug.Log("Inside IEnumerator");
        //yield on a new YieldInstruction that waits for 2 seconds.


        //After we have waited 5 seconds print the time again.
        //Debug.Log("Finished Coroutine at timestamp : " + Time.time);

        //Debug.Log("inside coroutine");
        //yield on a new YieldInstruction that waits for 2 seconds.
        while (s.sanityCurrent < s.sanityMax)
        {
            s.sanityCurrent += 1;

            yield return new WaitForSeconds(2);

            Debug.Log("inside stats coroutine");
        }        
        
        //After we have waited 5 seconds print the time again.
        //Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    public IEnumerator RefillStatsM()
    {
        while (s.manaCurrent < s.manaMax)
        {
            s.manaCurrent += 1;

            yield return new WaitForSeconds(2);

        }
    }
}
