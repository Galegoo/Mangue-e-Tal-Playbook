using UnityEngine;
using System.Collections;

public class Botao5_4 : MonoBehaviour {
    public Fase4 link;

    public Animator animacao;

    public Botao4_4 B4_4link;
    public Botao6_4 B6_4link;

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
        if (link.b4 == true && link.b5 == true && link.b6 == true)
        {
            B4_4link.animacao.SetTrigger("Descendo");
            B4_4link.animacao.SetTrigger("Baixo");
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B6_4link.animacao.SetTrigger("Descendo");
            B6_4link.animacao.SetTrigger("Baixo");
        }
        if (link.b4 == false && link.b5 == true && link.b6 == true)
        {
            B4_4link.animacao.SetTrigger("Subindo");
            B4_4link.animacao.SetTrigger("Cima");
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B6_4link.animacao.SetTrigger("Descendo");
            B6_4link.animacao.SetTrigger("Baixo");

        }
        if (link.b4 == true && link.b5 == false && link.b6 == true)
        {
            B4_4link.animacao.SetTrigger("Descendo");
            B4_4link.animacao.SetTrigger("Baixo");
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B6_4link.animacao.SetTrigger("Descendo");
            B6_4link.animacao.SetTrigger("Baixo");
        }
        if (link.b4 == false && link.b5 == false && link.b6 == true)
        {
            B4_4link.animacao.SetTrigger("Subindo");
            B4_4link.animacao.SetTrigger("Cima");
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B6_4link.animacao.SetTrigger("Descendo");
            B6_4link.animacao.SetTrigger("Baixo");
        }


        if (link.b4 == true && link.b5 == true && link.b6 == false)
        {
            B4_4link.animacao.SetTrigger("Descendo");
            B4_4link.animacao.SetTrigger("Baixo");
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B6_4link.animacao.SetTrigger("Subindo");
            B6_4link.animacao.SetTrigger("Cima");
        }
        if (link.b4 == false && link.b5 == true && link.b6 == false)
        {
            B4_4link.animacao.SetTrigger("Subindo");
            B4_4link.animacao.SetTrigger("Cima");
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B6_4link.animacao.SetTrigger("Subindo");
            B6_4link.animacao.SetTrigger("Cima");

        }
        if (link.b4 == true && link.b5 == false && link.b6 == false)
        {
            B4_4link.animacao.SetTrigger("Descendo");
            B4_4link.animacao.SetTrigger("Baixo");
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B6_4link.animacao.SetTrigger("Subindo");
            B6_4link.animacao.SetTrigger("Cima");
        }
        if (link.b4 == false && link.b5 == false && link.b6 == false)
        {
            B4_4link.animacao.SetTrigger("Subindo");
            B4_4link.animacao.SetTrigger("Cima");
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B6_4link.animacao.SetTrigger("Subindo");
            B6_4link.animacao.SetTrigger("Cima");
        }

        link.limiteToque--;
        link.b4 = !link.b4;
        link.b5 = !link.b5;
        link.b6 = !link.b6;
    }
}
