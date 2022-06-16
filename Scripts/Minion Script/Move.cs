using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject goal;

    private float currentPosition;
    private float previousPosition;
    
    private int movementSpeed = 1;

    public bool moving = true;


    void Awake()
    {
        moving = true;
        StartCoroutine(MoveCoroutine());        
    }

    IEnumerator MoveCoroutine()
    {

        //Debug.Log("inside coroutine");
        //yield on a new YieldInstruction that waits for 2 seconds.
        while (moving)
        {
            yield return new WaitForSeconds(2);

            previousPosition = Input.GetAxis("Horizontal");
            //checkCurrentTile();
            checkCurrentTile();

            if (moving)
            {
                moveMinion();                
            }
            else
            {
                yield return null;
            }
        }
        yield return null;
        //After we have waited 5 seconds print the time again.
        //Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    void checkCurrentTile()
    {
        //Debug.Log("Checking Tile");
        RaycastHit hit;

        if (Physics.Raycast(transform.position, -Vector3.up, out hit, 1))
        {
            if (hit.collider.CompareTag("Player 2 Summon Tile"))
            {
                Debug.Log("Hit the P2 Summon Tile");
                moving = false;
            }

            else if (hit.collider.CompareTag("Player 2 Trenches Tile"))
            {
                Debug.Log("Hit the P2 Trenches Tile");
            }

            else if (hit.collider.CompareTag("Player 2 Battle Tile"))
            {
                Debug.Log("Hit the P2 Battle Tile");
            }

            else if (hit.collider.CompareTag("Player 1 Summon Tile"))
            {
                Debug.Log("Hit the P1 Summon Tile");
            }

            else if (hit.collider.CompareTag("Player 1 Trenches Tile"))
            {
                Debug.Log("Hit the P1 Trenches Tile");
            }

            else if (hit.collider.CompareTag("Player 1 Battle Tile"))
            {
                Debug.Log("Hit the P1 Battle Tile");
            }
        }
        else
        {
            Debug.Log("Hit nothing");
        }
        
    }

    public void moveMinion()
    {
        // get the Input from Horizontal axis
 
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");

        //update the position
        transform.position = transform.position + new Vector3(0, 0, 1 + horizontalInput * movementSpeed * Time.deltaTime);

        //output to log the position change
        //Debug.Log(transform.position);
    }
}
