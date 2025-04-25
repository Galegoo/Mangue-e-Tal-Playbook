using UnityEngine;
using System.Collections;

public class ScriptMenu : MonoBehaviour {

    public GameObject painel;
    public GameObject Hud;
    public string Cena_game;
    public string menuPrincipal;

    public GameObject pontuacaum;

    public GameObject popseguranca;
    public GameObject popseguranca2;
	public GameObject loading;

    void Start()
    {
        pontuacaum.SetActive(true);
    }

    public void retornar()
    {
        Time.timeScale = 1f;
        painel.SetActive(false);
        Hud.SetActive(true);
    }

    public void recomeçar()
    {
        Application.LoadLevel(Cena_game);
        Time.timeScale = 1f;
    }
    public void menu()
    {
        pontuacaum.SetActive(false);
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
