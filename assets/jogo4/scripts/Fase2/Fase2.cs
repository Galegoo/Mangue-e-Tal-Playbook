using UnityEngine;
using System.Collections;

public class Fase2 : MonoBehaviour {

    public bool b1;
    public bool b2;
    public bool b3;
    public bool b4;
    public bool b5;

    public bool venceu;

    public GameObject painelDerrota;

    public TextMesh LimiteToque;

    public int limiteToque;

	// Use this for initialization
	void Start () {

       

        limiteToque = 6;

        LimiteToque.text = ("Toques restantes: " + limiteToque);
        venceu = false;
    }
	
	// Update is called once per frame
	void Update () {

        if (b1 && b2 && b3 && b4 && b5)
        {
            venceu = true;
        }

        else if (limiteToque <= 0)
        {
            painelDerrota.SetActive(true);
        }
       
        LimiteToque.text = ("" + limiteToque);
    }
}
