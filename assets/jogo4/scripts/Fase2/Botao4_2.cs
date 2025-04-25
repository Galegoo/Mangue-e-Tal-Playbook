using UnityEngine;
using System.Collections;

public class Botao4_2 : MonoBehaviour {

    public Fase2 link;

    public Animator animacao;

    public Botao3_2 B3_2link;
    public Botao5_2 B5_2link;

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
        if (link.b3 == true && link.b4 == true && link.b5 == true)
        {
            B3_2link.animacao.SetTrigger("Descendo");
            B3_2link.animacao.SetTrigger("Baixo");
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B5_2link.animacao.SetTrigger("Descendo");
            B5_2link.animacao.SetTrigger("Baixo");
        }
        if (link.b3 == false && link.b4 == true && link.b5 == true)
        {
            B3_2link.animacao.SetTrigger("Subindo");
            B3_2link.animacao.SetTrigger("Cima");
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B5_2link.animacao.SetTrigger("Descendo");
            B5_2link.animacao.SetTrigger("Baixo");

        }
        if (link.b3 == true && link.b4 == false && link.b5 == true)
        {
            B3_2link.animacao.SetTrigger("Descendo");
            B3_2link.animacao.SetTrigger("Baixo");
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B5_2link.animacao.SetTrigger("Descendo");
            B5_2link.animacao.SetTrigger("Baixo");
        }
        if (link.b3 == false && link.b4 == false && link.b5 == true)
        {
            B3_2link.animacao.SetTrigger("Subindo");
            B3_2link.animacao.SetTrigger("Cima");
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B5_2link.animacao.SetTrigger("Descendo");
            B5_2link.animacao.SetTrigger("Baixo");
        }


        if (link.b3 == true && link.b4 == true && link.b5 == false)
        {
            B3_2link.animacao.SetTrigger("Descendo");
            B3_2link.animacao.SetTrigger("Baixo");
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B5_2link.animacao.SetTrigger("Subindo");
            B5_2link.animacao.SetTrigger("Cima");
        }
        if (link.b3 == false && link.b4 == true && link.b5 == false)
        {
            B3_2link.animacao.SetTrigger("Subindo");
            B3_2link.animacao.SetTrigger("Cima");
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B5_2link.animacao.SetTrigger("Subindo");
            B5_2link.animacao.SetTrigger("Cima");

        }
        if (link.b3 == true && link.b4 == false && link.b5 == false)
        {
            B3_2link.animacao.SetTrigger("Descendo");
            B3_2link.animacao.SetTrigger("Baixo");
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B5_2link.animacao.SetTrigger("Subindo");
            B5_2link.animacao.SetTrigger("Cima");
        }
        if (link.b3 == false && link.b4 == false && link.b5 == false)
        {
            B3_2link.animacao.SetTrigger("Subindo");
            B3_2link.animacao.SetTrigger("Cima");
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B5_2link.animacao.SetTrigger("Subindo");
            B5_2link.animacao.SetTrigger("Cima");
        }
            link.limiteToque--;
            link.b3 = !link.b3;
            link.b4 = !link.b4;
            link.b5 = !link.b5;
    }
}
