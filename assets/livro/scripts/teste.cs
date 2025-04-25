using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class teste : MonoBehaviour {

    public Book link;
    public GameObject botao1;
    public GameObject botao2;
    public GameObject botao3;
    public GameObject botao4;
    public GameObject botao5;
    public GameObject botaoZoom;
    public GameObject PreloadJ1;
    public GameObject PreloadJ2;
    public GameObject PreloadJ3;
    public GameObject PreloadJ4;
    public GameObject PreloadJ5;

    public GameObject YouT;
    public GameObject FB;

    public GameObject HudGaleria;
    public GameObject HudAbout;
    public GameObject HudSair;
    public GameObject HudGaleria2;
    public GameObject HudAbout2;
    public GameObject HudSair2;
    public GameObject HudJogos;
    public GameObject HudJogos2;
    public GameObject HudMaisJogos;
    public GameObject HudMaisJogos2;
    public GameObject HudVideos;
    public GameObject HudVideos2;

    public float Score1;
    public float Score2;
    public float Score3;
    public float Score4;
    public float Score5;

    public float pontuacao1;
    public float pontuacao2;
    public float pontuacao3;

    public Text Score1Text;
    public Text Score2Text;
    public Text Score3Text;
    public Text Score4Text;
    public Text Score5Text;

    public Text pontuacao1Text;
    public Text pontuacao2Text;
    public Text pontuacao3Text;

    public string sena;

    public int xxx;

	// Use this for initialization
	void Start () {

        Time.timeScale = 1;

        if (PlayerPrefs.GetFloat("Score1") != null)
        {
            Score1 = PlayerPrefs.GetFloat("Score1");
        }
        if (PlayerPrefs.GetFloat("Score2") != null)
        {
            Score2 = PlayerPrefs.GetFloat("Score2");
        }
        if (PlayerPrefs.GetFloat("Score3") != null)
        {
            Score3 = PlayerPrefs.GetFloat("Score3");
        }
        if (PlayerPrefs.GetFloat("Score4") != null)
        {
            Score4 = PlayerPrefs.GetFloat("Score4");
        }
        if (PlayerPrefs.GetFloat("Score5") != null)
        {
            Score5 = PlayerPrefs.GetFloat("Score5");
        }

        Score1Text.text = "1º lugar: " + Mathf.Round(Score1);
        Score2Text.text = "2º lugar: " + Mathf.Round(Score2);
        Score3Text.text = "3º lugar: " + Mathf.Round(Score3);
        Score4Text.text = "4º lugar: " + Mathf.Round(Score4);
        Score5Text.text = "5º lugar: " + Mathf.Round(Score5);


        if (PlayerPrefs.GetFloat("pontuacao1") != null)
        {
            pontuacao1 = PlayerPrefs.GetFloat("pontuacao1");
        }
        if (PlayerPrefs.GetFloat("pontuacao2") != null)
        {
            pontuacao2 = PlayerPrefs.GetFloat("pontuacao2");
        }
        if (PlayerPrefs.GetFloat("pontuacao3") != null)
        {
            pontuacao3 = PlayerPrefs.GetFloat("pontuacao3");
        }

        pontuacao1Text.text = "1º lugar: " + Mathf.Round(pontuacao1);
        pontuacao2Text.text = "2º lugar: " + Mathf.Round(pontuacao2);
        pontuacao3Text.text = "3º lugar: " + Mathf.Round(pontuacao3);
    }
    
	// Update is called once per frame
	void Update () {

       

        xxx = MainScript.Instance.num1();

        if (link.currentPage == 14)
        {
            FB.SetActive(true);
            YouT.SetActive(true);
        }

        else
        {
            FB.SetActive(false);
            YouT.SetActive(false);
        }

        if (link.currentPage == 0 || link.currentPage == 16)
        {
            
            botaoZoom.SetActive(false);
        }
        else
        {
            botaoZoom.SetActive(true);
        }

        if(link.currentPage == 0)
        {
            HudGaleria.SetActive(true);
            HudAbout.SetActive(true);
            HudSair.SetActive(true);
            HudJogos.SetActive(true);
            HudMaisJogos.SetActive(true);
            HudVideos.SetActive(true);
        }
        else
        {
            HudGaleria.SetActive(false);
            HudAbout.SetActive(false);
            HudSair.SetActive(false);
            HudJogos.SetActive(false);
            HudMaisJogos.SetActive(false);
            HudVideos.SetActive(false);
        }

        if (link.currentPage == 16)
        {
            HudGaleria2.SetActive(true);
            HudAbout2.SetActive(true);
            HudSair2.SetActive(true);
            HudJogos2.SetActive(true);
            HudMaisJogos2.SetActive(true);
            HudVideos2.SetActive(true);
        }
        else
        {
            HudGaleria2.SetActive(false);
            HudAbout2.SetActive(false);
            HudSair2.SetActive(false);
            HudJogos2.SetActive(false);
            HudMaisJogos2.SetActive(false);
            HudVideos2.SetActive(false);
        }

        if (link.currentPage == 2)
        {
            botao1.SetActive(true);
        }
        else
        {
            botao1.SetActive(false);
            
        }

        if (link.currentPage == 4)
        {
            botao2.SetActive(true);
            botao3.SetActive(true);
        }
        else
        {
            botao2.SetActive(false);
            botao3.SetActive(false);
        }

        if (link.currentPage == 10)
        {
            botao4.SetActive(true);
            botao5.SetActive(true);
        }
        else
        {
            botao4.SetActive(false);
            botao5.SetActive(false);
        }

        

        if (link.pageDragging)
        {
            botao1.SetActive(false);
            botao2.SetActive(false);
            botao3.SetActive(false);
            botao4.SetActive(false);
            botao5.SetActive(false);
        }
	}
    public void botaoF1()
    {
        PreloadJ1.SetActive(true);
    }

    public void botaoF2()
    {
        PreloadJ2.SetActive(true);
    }

    public void botaoF3()
    {
        PreloadJ3.SetActive(true);
    }
    public void botaoF4()
    {
        PreloadJ4.SetActive(true);
    }

        public void botaoF5()
    {
        PreloadJ5.SetActive(true);
    }

        public void botaoFB()
    {
        Application.OpenURL("https://www.facebook.com/turmamangueetal");
    }

        public void botaoYouT()
    {
        Application.OpenURL("https://www.youtube.com/secretariademeioambientedorecife");
    }
}

