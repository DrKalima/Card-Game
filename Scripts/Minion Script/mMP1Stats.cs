using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mMP1Stats : MonoBehaviour
{
    public int mMP1ToughMax;
    public int mMP1ToughCurrent;

    public int mMP1DefMax;
    public int mMP1DefCurrent;
    
    // Start is called before the first frame update
    void Start()
    {
        mMP1ToughMax = 1;
        mMP1DefMax = 1;

        mMP1ToughCurrent = mMP1ToughMax;
        mMP1DefCurrent = mMP1DefMax;
    }

    // Update is called once per frame
    public void mMP1dufon()
    {
        if (mMP1DefCurrent == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
