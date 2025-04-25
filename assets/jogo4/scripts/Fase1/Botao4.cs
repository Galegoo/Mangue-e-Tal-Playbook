using UnityEngine;
using System.Collections;

public class Botao4 : MonoBehaviour {

    public Fase1 link;

    public Animator animacao;

    public Botao3 B3link;

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
            if (link.b3 == true && link.b4 == true)
            {
                animacao.SetTrigger("Descendo");
                animacao.SetTrigger("Baixo");
                B3link.animacao.SetTrigger("Descendo");
                B3link.animacao.SetTrigger("Baixo");
        }
            if (link.b3 == false && link.b4 == true)
            {
                animacao.SetTrigger("Descendo");
                animacao.SetTrigger("Baixo");
                B3link.animacao.SetTrigger("Subindo");
                B3link.animacao.SetTrigger("Cima");

        }
            if (link.b3 == true && link.b4 == false)
            {
                animacao.SetTrigger("Subindo");
                animacao.SetTrigger("Cima");
                B3link.animacao.SetTrigger("Descendo");
                B3link.animacao.SetTrigger("Baixo");
        }
            if (link.b3 == false && link.b4 == false)
            {
                animacao.SetTrigger("Subindo");
                animacao.SetTrigger("Cima");
                B3link.animacao.SetTrigger("Subindo");
                B3link.animacao.SetTrigger("Cima");
        }
            link.limiteToque--;
            link.b3 = !link.b3;
            link.b4 = !link.b4;
    }
}
