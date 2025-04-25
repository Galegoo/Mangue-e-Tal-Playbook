using UnityEngine;
using System.Collections;

public class HudScript : MonoBehaviour {

    public string Galeria;
    public string About;

    public GameObject popSeguranca;
    public GameObject JogosBotao;
    public GameObject VideosBotao;
	public GameObject JogosMaisBotao;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void abreGaleria()
    {
        Application.LoadLevel(Galeria);
    }

    public void abreAbout()
    {
        Application.LoadLevel(About);
    }

    public void AbrePop()
    {
        popSeguranca.SetActive(true);
    }
    public void FechaPop()
    {
        popSeguranca.SetActive(false);
    }

    public void FechaJogo()
    {
        Application.Quit();
    }

    public void Jogos()
    {
        JogosBotao.SetActive(true);
    }

    public void Videos()
    {
        VideosBotao.SetActive(true);
    }

	public void JogosMais()
	{
		JogosMaisBotao.SetActive(true);
	}
}
