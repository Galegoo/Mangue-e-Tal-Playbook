using UnityEngine;
using System.Collections;

public class Lamp4_3 : MonoBehaviour {

    public Fase3 link;

    public Animator animacao;

    // Use this for initialization
    void Start()
    {

        animacao.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (link.b4)
        {
            animacao.SetBool("Acesa", true);
        }
        else
        {
            animacao.SetBool("Acesa", false);
        }

    }
}
