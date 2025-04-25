using UnityEngine;
using System.Collections;

public class MainScript {

    private static MainScript _mainScript = null;

    int num;

    public static MainScript Instance
    {
        get
        {
            if(_mainScript == null)
            {
                _mainScript = new MainScript();
            }
            return _mainScript;
        }
    }

    public void ReceiveInt(int numt)
    {
        num = numt;
    }

    public int num1()
    {
        return num;
    }

}
