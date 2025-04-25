using UnityEngine;
using System.Collections;

public class Botao4_3 : MonoBehaviour {

    public Fase3 link;

    public Animator animacao;

    public Botao3_3 B3_3link;
    public Botao5_3 B5_3link;

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
            B3_3link.animacao.SetTrigger("Descendo");
            B3_3link.animacao.SetTrigger("Baixo");
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B5_3link.animacao.SetTrigger("Descendo");
            B5_3link.animacao.SetTrigger("Baixo");
        }
        if (link.b3 == false && link.b4 == true && link.b5 == true)
        {
            B3_3link.animacao.SetTrigger("Subindo");
            B3_3link.animacao.SetTrigger("Cima");
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B5_3link.animacao.SetTrigger("Descendo");
            B5_3link.animacao.SetTrigger("Baixo");

        }
        if (link.b3 == true && link.b4 == false && link.b5 == true)
        {
            B3_3link.animacao.SetTrigger("Descendo");
            B3_3link.animacao.SetTrigger("Baixo");
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B5_3link.animacao.SetTrigger("Descendo");
            B5_3link.animacao.SetTrigger("Baixo");
        }
        if (link.b3 == false && link.b4 == false && link.b5 == true)
        {
            B3_3link.animacao.SetTrigger("Subindo");
            B3_3link.animacao.SetTrigger("Cima");
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B5_3link.animacao.SetTrigger("Descendo");
            B5_3link.animacao.SetTrigger("Baixo");
        }


        if (link.b3 == true && link.b4 == true && link.b5 == false)
        {
            B3_3link.animacao.SetTrigger("Descendo");
            B3_3link.animacao.SetTrigger("Baixo");
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B5_3link.animacao.SetTrigger("Subindo");
            B5_3link.animacao.SetTrigger("Cima");
        }
        if (link.b3 == false && link.b4 == true && link.b5 == false)
        {
            B3_3link.animacao.SetTrigger("Subindo");
            B3_3link.animacao.SetTrigger("Cima");
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B5_3link.animacao.SetTrigger("Subindo");
            B5_3link.animacao.SetTrigger("Cima");

        }
        if (link.b3 == true && link.b4 == false && link.b5 == false)
        {
            B3_3link.animacao.SetTrigger("Descendo");
            B3_3link.animacao.SetTrigger("Baixo");
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B5_3link.animacao.SetTrigger("Subindo");
            B5_3link.animacao.SetTrigger("Cima");
        }
        if (link.b3 == false && link.b4 == false && link.b5 == false)
        {
            B3_3link.animacao.SetTrigger("Subindo");
            B3_3link.animacao.SetTrigger("Cima");
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B5_3link.animacao.SetTrigger("Subindo");
            B5_3link.animacao.SetTrigger("Cima");
        }
            link.limiteToque--;
            link.b3 = !link.b3;
            link.b4 = !link.b4;
            link.b5 = !link.b5;
    }
}
