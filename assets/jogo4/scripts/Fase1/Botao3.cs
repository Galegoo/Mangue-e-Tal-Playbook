using UnityEngine;
using System.Collections;

public class Botao3 : MonoBehaviour {

    public Fase1 link;

    public Animator animacao;

    public Botao2 B2link;
    public Botao4 B4link;


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
        if (link.b2 == true && link.b3 == true && link.b4 == true)
        {
            B2link.animacao.SetTrigger("Descendo");
            B2link.animacao.SetTrigger("Baixo");
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B4link.animacao.SetTrigger("Descendo");
            B4link.animacao.SetTrigger("Baixo");
        }
        if (link.b2== false && link.b3 == true && link.b4 == true)
        {
            B2link.animacao.SetTrigger("Subindo");
            B2link.animacao.SetTrigger("Cima");
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B4link.animacao.SetTrigger("Descendo");
            B4link.animacao.SetTrigger("Baixo");
        }
        if (link.b2 == true && link.b3 == false && link.b4 == true)
        {
            B2link.animacao.SetTrigger("Descendo");
            B2link.animacao.SetTrigger("Baixo");
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B4link.animacao.SetTrigger("Descendo");
            B4link.animacao.SetTrigger("Baixo");
        }
        if (link.b2 == false && link.b3 == false && link.b4 == true)
        {
            B2link.animacao.SetTrigger("Subindo");
            B2link.animacao.SetTrigger("Cima");
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B4link.animacao.SetTrigger("Descendo");
            B4link.animacao.SetTrigger("Baixo");
        }


        if (link.b2 == true && link.b3 == true && link.b4 == false)
        {
            B2link.animacao.SetTrigger("Descendo");
            B2link.animacao.SetTrigger("Baixo");
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B4link.animacao.SetTrigger("Subindo");
            B4link.animacao.SetTrigger("Cima");
        }
        if (link.b2 == false && link.b3 == true && link.b4 == false)
        {
            B2link.animacao.SetTrigger("Subindo");
            B2link.animacao.SetTrigger("Cima");
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B4link.animacao.SetTrigger("Subindo");
            B4link.animacao.SetTrigger("Cima");

        }
        if (link.b2 == true && link.b3 == false && link.b4 == false)
        {
            B2link.animacao.SetTrigger("Descendo");
            B2link.animacao.SetTrigger("Baixo");
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B4link.animacao.SetTrigger("Subindo");
            B4link.animacao.SetTrigger("Cima");
        }
        if (link.b2 == false && link.b3 == false && link.b4 == false)
        {
            B2link.animacao.SetTrigger("Subindo");
            B2link.animacao.SetTrigger("Cima");
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B4link.animacao.SetTrigger("Subindo");
            B4link.animacao.SetTrigger("Cima");
        }


        link.limiteToque--;
        link.b2 = !link.b2;
        link.b3 = !link.b3;
        link.b4 = !link.b4;
    }
}
