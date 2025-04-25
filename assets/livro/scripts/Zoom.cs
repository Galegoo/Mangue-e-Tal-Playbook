using UnityEngine;
using System.Collections;

public class Zoom : MonoBehaviour {

    public string pag_2_3;
    public string pag_4_5;
    public string pag_6_7;
    public string pag_8_9;
    public string pag_10_11;
    public string pag_12_13;
    public string pag_14_15;

    public int pagAtual;

    // Use this for initialization
    void Start () {

        pagAtual = MainScript.Instance.num1();

	}
	
	// Update is called once per frame
	void Update () {

        pagAtual = MainScript.Instance.num1();

    }

    public void irPag()
    {
        switch (pagAtual)
        {
            case 2:
            Application.LoadLevel("pag_2_3");
                break;

            case 4:
                Application.LoadLevel("pag_4_5");
                break;

            case 6:
                Application.LoadLevel("pag_6_7");
                break;

            case 8:
                Application.LoadLevel("pag_8_9");
                break;

            case 10:
                Application.LoadLevel("pag_10_11");
                break;

            case 12:
                Application.LoadLevel("pag_12_13");
                break;
            case 14:
                Application.LoadLevel("pag_14_15");
                break;
            default:
                break;
        }
            
    
    }
}
