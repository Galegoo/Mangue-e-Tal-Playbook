using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

    public GameObject menuPause;
    public string fase;


    public GameObject popseguranca;
    public GameObject popseguranca2;
	public GameObject loading;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Recomecar()
    {
        Application.LoadLevel(fase);
    }

    public void Continuar()
    {
        menuPause.SetActive(false);
    }

    public void Sair()
    {
		loading.SetActive (true);
        Application.LoadLevel("LivroAberto");
    }

    public void abrepopSair()
    {
        popseguranca.SetActive(true);
    }

    public void fechapopSair()
    {
        popseguranca.SetActive(false);
    }

    public void abrepopRecomecar()
    {
        popseguranca2.SetActive(true);
    }

    public void fechapopRecomecar()
    {
        popseguranca2.SetActive(false);
    }
}
