using UnityEngine;
using System.Collections;

public class MenuPause1 : MonoBehaviour {

    public GameObject painel;
    public string sena;
    public string menuPrincipal;

    public GameObject popseguranca;
    public GameObject popseguranca2;
	public GameObject loading;


    void Start()
    {
        Time.timeScale = 0f;
    }

    public void retornar()
    {
        Time.timeScale = 1f;
        painel.SetActive(false);
    }

    public void recomeçar()
    {
        Application.LoadLevel(sena);
        }
    public void menu()
    {
		loading.SetActive (true);
        Application.LoadLevel(menuPrincipal);
        Time.timeScale = 1f;
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
