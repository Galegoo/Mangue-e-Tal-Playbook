using UnityEngine;
using System.Collections;

public class MenuDerrota_3 : MonoBehaviour {

    public string Fase3;
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
        Application.LoadLevel("Fase3");
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
