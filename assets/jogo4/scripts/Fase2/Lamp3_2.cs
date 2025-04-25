using UnityEngine;
using System.Collections;

public class Lamp3_2 : MonoBehaviour {

    public Fase2 link;

    public Animator animacao;

    // Use this for initialization
    void Start()
    {

        animacao.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (link.b3)
        {
            animacao.SetBool("Acesa", true);
        }
        else
        {
            animacao.SetBool("Acesa", false);
        }

    }
}
