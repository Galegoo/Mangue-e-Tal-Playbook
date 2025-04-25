using UnityEngine;
using System.Collections;

public class MenuDerrota : MonoBehaviour {

    public string Fase1;
    public string SelecFase;
    public string LivroAberto;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Recomeçar()
    {
        Application.LoadLevel("Fase1");
    }

    public void SelectFase()
    {
        Application.LoadLevel("SelecFase");
    }

    public void VoltaLivro()
    {
        Application.LoadLevel("LivroAberto");
    }
}
