using UnityEngine;
using System.Collections;

public class Botao5_3 : MonoBehaviour {
    public Fase3 link;

    public Animator animacao;

    public Botao4_3 B4_3link;

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
        if (link.b4 == true && link.b5 == true)
        {
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B4_3link.animacao.SetTrigger("Descendo");
            B4_3link.animacao.SetTrigger("Baixo");
        }
        if (link.b4 == false && link.b5 == true)
        {
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B4_3link.animacao.SetTrigger("Subindo");
            B4_3link.animacao.SetTrigger("Cima");

        }
        if (link.b4 == true && link.b5 == false)
        {
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B4_3link.animacao.SetTrigger("Descendo");
            B4_3link.animacao.SetTrigger("Baixo");
        }
        if (link.b4 == false && link.b5 == false)
        {
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B4_3link.animacao.SetTrigger("Subindo");
            B4_3link.animacao.SetTrigger("Cima");
        }

        link.limiteToque--;
        link.b4 = !link.b4;
        link.b5 = !link.b5;
    }
}
