using UnityEngine;
using System.Collections;

public class SelecaoFase : MonoBehaviour {

    public string Fase1;
    public string Fase12;
    public string Fase13;
    public string Fase2;
    public string Fase3;
    public string Fase4;
    public string LivroAberto;

    public GameObject carregando;
    public int random;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void F1()
    {
        carregando.SetActive(true);
        Application.LoadLevel("Fase1");
    }
    public void F2()
    {
        carregando.SetActive(true);
        Application.LoadLevel("Fase2");
    }
    public void F3()
    {
        carregando.SetActive(true);
        Application.LoadLevel("Fase3");
    }
    public void F4()
    {
        carregando.SetActive(true);
        Application.LoadLevel("Fase4");
    }

    public void F5()
    {
        carregando.SetActive(true);
        Application.LoadLevel("Fase5");
    }

    public void F6()
    {
        carregando.SetActive(true);
        Application.LoadLevel("Fase6");
    }

    public void F7()
    {
        carregando.SetActive(true);
        Application.LoadLevel("Fase7");
    }

    public void F8()
    {
        carregando.SetActive(true);
        Application.LoadLevel("Fase8");
    }
    public void VoltarLivro()
    {
        carregando.SetActive(true);
        Application.LoadLevel("LivroAberto");
    }
}
