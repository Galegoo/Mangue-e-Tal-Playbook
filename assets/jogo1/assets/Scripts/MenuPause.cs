using UnityEngine;
using System.Collections;

public class MenuPause : MonoBehaviour {

    public GameObject painel;
    public string Cena1;
    public string Cena2;
    public string Cena3;
    public string menuPrincipal;

    public GameObject popseguranca;
    public GameObject popseguranca2;
	public GameObject loading;

    public int random;

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
        random = Random.Range(1, 4);
        if (random == 1)
        {
            Application.LoadLevel("CenaJogo1");
        }
        else if (random == 2)
        {
            Application.LoadLevel("CenaJogo2");
                }
        else if (random == 3)
        {
            Application.LoadLevel("CenaJogo3");
        }
        Time.timeScale = 1f;
    }
    public void menu()
    {
		loading.SetActive (true);
        Application.LoadLevel("LivroAberto");
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
