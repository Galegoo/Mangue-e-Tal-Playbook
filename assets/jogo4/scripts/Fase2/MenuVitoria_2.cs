using UnityEngine;
using System.Collections;

public class MenuVitoria_2 : MonoBehaviour {

    public string Fase2;
    public string Fase3;
    public string SelecFase;
    public string LivroAberto;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Recomeçar()
    {
        Application.LoadLevel("Fase2");
    }

    public void SelectFase()
    {
        Application.LoadLevel("SelecFase");
    }

    public void VoltaLivro()
    {
        Application.LoadLevel("LivroAberto");
    }

    public void ProxFase()
    {
        Application.LoadLevel("Fase3");
    }
}
