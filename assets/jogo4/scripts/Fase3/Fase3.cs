using UnityEngine;
using System.Collections;

public class Fase3 : MonoBehaviour {

    public bool b1;
    public bool b2;
    public bool b3;
    public bool b4;
    public bool b5;

    public TextMesh LimiteToque;

    public bool venceu;

    public GameObject menuDerrota;

    public int limiteToque;

	// Use this for initialization
	void Start () {

        venceu = false;

        LimiteToque.text = ("Toques restantes: " + limiteToque);
    }
	
	// Update is called once per frame
	void Update () {


        if (b1 && b2 && b3 && b4 && b5)
        {
            venceu = true;
        }
        else if(limiteToque <= 0)
        {
            menuDerrota.SetActive(true);
        }
        LimiteToque.text = ("" + limiteToque);
    }
}
