using UnityEngine;
using System.Collections;

public class Botao6_4 : MonoBehaviour {
    public Fase4 link;

    public Animator animacao;

    public Botao5_4 B5_4link;

    // Use this for initialization
    void Start()
    {

        animacao = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if (link.b5 == true && link.b6 == true)
        {
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B5_4link.animacao.SetTrigger("Descendo");
            B5_4link.animacao.SetTrigger("Baixo");
        }
        if (link.b5 == false && link.b6 == true)
        {
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B5_4link.animacao.SetTrigger("Subindo");
            B5_4link.animacao.SetTrigger("Cima");

        }
        if (link.b5 == true && link.b6 == false)
        {
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B5_4link.animacao.SetTrigger("Descendo");
            B5_4link.animacao.SetTrigger("Baixo");
        }
        if (link.b5 == false && link.b6 == false)
        {
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B5_4link.animacao.SetTrigger("Subindo");
            B5_4link.animacao.SetTrigger("Cima");
        }

        link.limiteToque--;
        link.b5 = !link.b5;
        link.b6 = !link.b6;
    }
}
