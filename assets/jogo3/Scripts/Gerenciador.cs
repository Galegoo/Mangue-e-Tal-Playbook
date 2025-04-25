using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gerenciador : MonoBehaviour
{

    public float vidas;
    public float pontuacao = 0;
    public float brinquedos = 0;

	public GameObject gameOverMenu;
	public GameObject rankingMenu;
	public GameObject pauseMenu;
    public GameObject winMenu;

    public float Score1;
	public float Score2;
	public float Score3;
	public float Score4;
    public float Score5;
    public float pontuacaofinal;

    public Text textoScore;
    public Text textoScoreWin;

    public Text Score1Text;
	public Text Score2Text;
	public Text Score3Text;
	public Text Score4Text;
	public Text Score5Text;

    public float racoes;
    public float racoesGrandes;

    public Text racoesText;
    public Text racoesTextWin;

    public Text erroText;
    public Text erroTextWin;

    public Text tempoText;
    public Text tempoTextWin;

    public Text pontuacaoText;
    public Text pontuacaoTextWin;

    public float tempo;
    public float erros;

    void Start()
    {
        vidas = 3;
        pontuacao = 0;
        brinquedos = 0;
		if (PlayerPrefs.GetFloat ("Score1") != null) {
			Score1 = PlayerPrefs.GetFloat ("Score1");
		}
		if (PlayerPrefs.GetFloat ("Score2") != null) {
			Score2 = PlayerPrefs.GetFloat ("Score2");
		}
		if (PlayerPrefs.GetFloat ("Score3") != null) {
			Score3 = PlayerPrefs.GetFloat ("Score3");
		}
		if (PlayerPrefs.GetFloat ("Score4") != null) {
			Score4 = PlayerPrefs.GetFloat ("Score4");
		}
		if (PlayerPrefs.GetFloat ("Score5") != null) {
			Score5 = PlayerPrefs.GetFloat ("Score5");
		}
    }
       void Update()
	{
        tempo += Time.deltaTime;
       		if (vidas <= 0) {
			gameOver ();
		}
            if (vidas > 3)
        {
            pontuacao += 100;
            vidas = 3;
        }
		if (pontuacaofinal > Score1) {
			Score1 = pontuacaofinal;
			PlayerPrefs.SetFloat ("Score1", Score1);
		} else if (pontuacaofinal > Score2 && pontuacaofinal < Score1) {
			Score2 = pontuacaofinal;
			PlayerPrefs.SetFloat ("Score2", Score2);
		} else if (pontuacaofinal > Score3 && pontuacaofinal < Score2) {
			Score3 = pontuacaofinal;
			PlayerPrefs.SetFloat ("Score3", Score3);
		} else if (pontuacaofinal > Score4 && pontuacaofinal < Score3) {
			Score4 = pontuacaofinal;
			PlayerPrefs.SetFloat ("Score4", Score4);
		} else if (pontuacaofinal > Score5 && pontuacaofinal < Score4) {
			Score5 =  pontuacaofinal;
			PlayerPrefs.SetFloat ("Score5", Score5);
		}
        if(brinquedos >= 10)
        {
            WinMenu();
        }
	}
    public void WinMenu()
    {
        Time.timeScale = 0;
        winMenu.SetActive(true);
        pontuacaofinal = Mathf.Round((pontuacao * 2) + ((racoesGrandes + racoes) * 5) - (erros * 250) + (tempo * 2));
        textoScoreWin.text = "" + Mathf.Round((pontuacao * 2) + ((racoesGrandes + racoes) * 5) - (erros * 250) + (tempo * 2) );
        racoesTextWin.text = "" + Mathf.Round(racoes+racoesGrandes) ;
        erroTextWin.text = "" + Mathf.Round(erros);
        tempoTextWin.text = "" + Mathf.Round(tempo);
        pontuacaoTextWin.text = "" + Mathf.Round(pontuacao);

    }
	public void gameOver()
	{
		gameOverMenu.SetActive(true);
		Time.timeScale = 0f;
        pontuacaofinal = Mathf.Round((pontuacao * 2) + ((racoesGrandes + racoes) * 5) + (tempo * 2));
        textoScore.text = "" + Mathf.Round((pontuacao * 2) + ((racoesGrandes + racoes) * 5) + (tempo * 2));
        racoesText.text = "" + Mathf.Round(racoes+racoesGrandes);
        erroText.text = "" + Mathf.Round(erros);
        tempoText.text = "" + Mathf.Round(tempo);
        pontuacaoText.text = "" + Mathf.Round(pontuacao);
    }
	public void ranking()
	{
		gameOverMenu.SetActive (false);
		pauseMenu.SetActive (false);
		rankingMenu.SetActive (true);
		Score1Text.text = "1º lugar: " + Mathf.Round(Score1);
		Score2Text.text = "2º lugar: " + Mathf.Round(Score2);
		Score3Text.text = "3º lugar: " + Mathf.Round(Score3);
		Score4Text.text = "4º lugar: " + Mathf.Round(Score4);
		Score5Text.text = "5º lugar: " + Mathf.Round(Score5);
	}
	public void voltarparagameover (){
		rankingMenu.SetActive (false);
		gameOverMenu.SetActive (true);
	}
   }
