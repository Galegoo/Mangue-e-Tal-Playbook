using UnityEngine;
using System.Collections;

public class ControlaFase : MonoBehaviour {

    public string CenaJogo1;
    public string CenaJogo2;
    public string CenaJogo3;
    public string sena;
    public int random;

    public GameObject carregamento;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void abreF1()
    {
        random = Random.Range(1, 4);
        if (random == 1)
        {
            carregamento.SetActive(true);
            Application.LoadLevel("CenaJogo1");
        }
        else if (random == 2)
        {
            carregamento.SetActive(true);
            Application.LoadLevel("CenaJogo2");
        }
        else if (random == 3)
        {
            carregamento.SetActive(true);
            Application.LoadLevel("CenaJogo3");
        }
    }

    public void abreF2()
    {
        carregamento.SetActive(true);
        Application.LoadLevel("memoria");
    }

    public void abreF3()
    {
        carregamento.SetActive(true);
        Application.LoadLevel("sena");
    }
    public void abreF5()
    {
        carregamento.SetActive(true);
        Application.LoadLevel("Game");
    }
}
