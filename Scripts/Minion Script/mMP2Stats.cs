using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mMP2Stats : MonoBehaviour
{
    public int mMP2ToughMax;
    public int mMP2ToughCurrent;

    public int mMP2DefMax;
    public int mMP2DefCurrent;

    // Start is called before the first frame update
    void Start()
    {
        mMP2ToughMax = 1;
        mMP2DefMax = 1;

        mMP2ToughCurrent = mMP2ToughMax;
        mMP2DefCurrent = mMP2DefMax;
    }

    // Update is called once per frame
    public void mMP2dufon()
    {
        if(mMP2DefCurrent == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
