using UnityEngine;
using System.Collections;

public class Botao2_3 : MonoBehaviour {

    public Fase3 link;

    public Animator animacao;

    public Botao1_3 B1link;
    public Botao3_3 B3link;

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

            if (link.b1 == true && link.b2 == true && link.b3 == true)
            {
                B1link.animacao.SetTrigger("Descendo");
                B1link.animacao.SetTrigger("Baixo");
                animacao.SetTrigger("Descendo");
                animacao.SetTrigger("Baixo");
                B3link.animacao.SetTrigger("Descendo");
                B3link.animacao.SetTrigger("Baixo");
            }
            if (link.b1 == false && link.b2 == true && link.b3 == true)
            {
                B1link.animacao.SetTrigger("Subindo");
                B1link.animacao.SetTrigger("Cima");
                animacao.SetTrigger("Descendo");
                animacao.SetTrigger("Baixo");
                B3link.animacao.SetTrigger("Descendo");
                B3link.animacao.SetTrigger("Baixo");

            }
            if (link.b1 == true && link.b2 == false && link.b3 == true)
            {
                B1link.animacao.SetTrigger("Descendo");
                B1link.animacao.SetTrigger("Baixo");
                animacao.SetTrigger("Subindo");
                animacao.SetTrigger("Cima");
                B3link.animacao.SetTrigger("Descendo");
                B3link.animacao.SetTrigger("Baixo");
        }
            if (link.b1 == false && link.b2 == false && link.b3 == true)
            {
                B1link.animacao.SetTrigger("Subindo");
                B1link.animacao.SetTrigger("Cima");
                animacao.SetTrigger("Subindo");
                animacao.SetTrigger("Cima");
                B3link.animacao.SetTrigger("Descendo");
                B3link.animacao.SetTrigger("Baixo");
        }


        if (link.b1 == true && link.b2 == true && link.b3 == false)
        {
            B1link.animacao.SetTrigger("Descendo");
            B1link.animacao.SetTrigger("Baixo");
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B3link.animacao.SetTrigger("Subindo");
            B3link.animacao.SetTrigger("Cima");
        }
        if (link.b1 == false && link.b2 == true && link.b3 == false)
        {
            B1link.animacao.SetTrigger("Subindo");
            B1link.animacao.SetTrigger("Cima");
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B3link.animacao.SetTrigger("Subindo");
            B3link.animacao.SetTrigger("Cima");

        }
        if (link.b1 == true && link.b2 == false && link.b3 == false)
        {
            B1link.animacao.SetTrigger("Descendo");
            B1link.animacao.SetTrigger("Baixo");
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B3link.animacao.SetTrigger("Subindo");
            B3link.animacao.SetTrigger("Cima");
        }
        if (link.b1 == false && link.b2 == false && link.b3 == false)
        {
            B1link.animacao.SetTrigger("Subindo");
            B1link.animacao.SetTrigger("Cima");
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B3link.animacao.SetTrigger("Subindo");
            B3link.animacao.SetTrigger("Cima");
        }
        link.limiteToque--;
        link.b1 = !link.b1;
        link.b2 = !link.b2;
        link.b3 = !link.b3;
    }
}
