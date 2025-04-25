using UnityEngine;
using System.Collections;

public class WinLoose : MonoBehaviour {

    public string FaseAtual;
    public string ProxFase;
    public string LivroAberto;

    public GameObject popseguranca;
    public GameObject popseguranca2;
	public GameObject loading;


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
        Application.LoadLevel(FaseAtual);
    }

    public void VoltaLivro()
    {
		loading.SetActive (true);
        Application.LoadLevel("LivroAberto");
    }

    public void ProximaFase()
    {
		loading.SetActive (true);
        Application.LoadLevel(ProxFase);
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
