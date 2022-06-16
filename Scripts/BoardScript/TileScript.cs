using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public bool target = false;
    public bool selectable = false;
    public bool isTile = false;

    public Color startColor;
    
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.CompareTag("Player 1 Summon Tile"))
        {
            isTile = true;
            startColor = GetComponent<Renderer>().material.GetColor("_Color");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isTile)
        {
            if (target)
            {
                GetComponent<Renderer>().material.color = Color.red;
            }
            else if (selectable)
            {
                GetComponent<Renderer>().material.color = Color.green;
            }
            else
            {
                GetComponent<Renderer>().material.color = startColor;
            }
        }
    }
}
