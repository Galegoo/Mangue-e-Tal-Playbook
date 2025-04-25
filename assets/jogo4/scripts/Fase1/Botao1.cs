using UnityEngine;
using System.Collections;

public class Botao1 : MonoBehaviour {

    public Fase1 link;
    
    public Animator animacao;

    public Botao2 B2link;

	// Use this for initialization
	void Start () {

        animacao = GetComponent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        

        if (link.b1 == true && link.b2 == true)
        {
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B2link.animacao.SetTrigger("Descendo");
            B2link.animacao.SetTrigger("Baixo");

        }
        if (link.b1 == false && link.b2 == true)
        {
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B2link.animacao.SetTrigger("Descendo");
            B2link.animacao.SetTrigger("Baixo");        

        }
        if (link.b1 == true && link.b2 == false)
        {
            animacao.SetTrigger("Descendo");
            animacao.SetTrigger("Baixo");
            B2link.animacao.SetTrigger("Subindo");
            B2link.animacao.SetTrigger("Cima");
        }
        if (link.b1 == false && link.b2 == false)
        {
            animacao.SetTrigger("Subindo");
            animacao.SetTrigger("Cima");
            B2link.animacao.SetTrigger("Subindo");
            B2link.animacao.SetTrigger("Cima");
        }

        link.limiteToque--;
        link.b1 = !link.b1;
        link.b2 = !link.b2;
    }
}
