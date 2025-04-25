using UnityEngine;
using System.Collections;

public class Gerenciadorop2 : MonoBehaviour {
	public Camera cameraa;

	public GameObject[] animais;
	public GameObject[] posicoes;

	public Fade1 links;

	public int i;
	public float velocidade;

	public float tempo;
	public float tempo1;
	public float tempo2;
	public float tempo3;
	public float tempo4;
	public float tempo6 = 0.5f;

	public float pontuacao;

	public GameObject coracao;
	public GameObject coracao1;
	public GameObject coracao2;

	public int jogadas = 3;

	int cpont;
	int cpont1;
	int cpont2;
	int cpont3;
	int cpont4;
	int cpont5;
	int cpont6;
	int cpont7;

	public int contadordospares;
	public int contador;

	public int contador0;
	public int contador1;
	public int contador2;
	public int contador3;
	public int contador4;
	public int contador5;
	public int contador6;
	public int contador7;

	public int contadorcapi;
	public int contadorgato;
	public int contadorsapo;
	public int contadorsagui;

	public GameObject copia0;
	public GameObject copia1;
	public GameObject copia2;
	public GameObject copia3;
	public GameObject copia4;
	public GameObject copia5;
	public GameObject copia6;
	public GameObject copia7;

	public string memoria2;
	public string memoria;

	public GameObject gameOverpopup;
	public GameObject pausepopup;

	public GameObject popSeguranca;
	public GameObject popSeguranca2;

	public GameObject popSeguranca_2;
	public GameObject popSeguranca2_2;

	public GameObject popSeguranca_3;
	public GameObject popSeguranca2_3;

	public GameObject loading;

	public Timer5 timer;

	// Use this for initialization
	void Start()
	{   
		Time.timeScale = 1f;
		Spawn();
		timer = FindObjectOfType(typeof(Timer5)) as Timer5;
	}

    // Update is called once per frame
    void Update()
    {
        if (pontuacao >= 4)
        {
            timer.controle++;
            tempo6 -= Time.deltaTime;
            if (tempo6 <= 0)
            {
                links.fase2 = true;
                //Application.LoadLevel("memoria2");
            }
        }

        if (contador0 >= 1 && contador5 >= 1)
        {
            if (cpont < 1)
            {
                pontuacao++;
                contadordospares++;
                cpont++;
            }
            tempo1 -= Time.deltaTime;
            if (tempo1 <= 0)
            {
                tempo = 0.7f;
                tempo1 = 0;
                cpont4 = 0;
                contador = 0;
                contador0 = 0;
                contador5 = 0;
                copia0.transform.position = new Vector3(copia0.transform.position.x, 4.06f, copia0.transform.position.z);
                copia5.transform.position = new Vector3(copia5.transform.position.x, 0.79f, copia5.transform.position.z);
            }
        }

        if (contador1 >= 1 && contador4 >= 1)
        {
            if (cpont1 < 1)
            {
                pontuacao++;
                contadordospares++;
                cpont1++;
            }
            tempo2 -= Time.deltaTime;
            if (tempo2 <= 0)
            {
                tempo = 0.7f;
                tempo2 = 0;
                cpont4 = 0;
                contador = 0;
                contador1 = 0;
                contador4 = 0;
                copia1.transform.position = new Vector3(copia1.transform.position.x, 4.11f, copia1.transform.position.z);
                copia4.transform.position = new Vector3(copia4.transform.position.x, -0.9f, copia4.transform.position.z);
            }
        }
        if (contador2 >= 1 && contador6 >= 1)
        {
            if (cpont2 < 1)
            {
                pontuacao++;
                contadordospares++;
                cpont2++;
            }
            tempo3 -= Time.deltaTime;
            if (tempo3 <= 0)
            {
                tempo = 0.7f;
                tempo3 = 0;
                cpont4 = 0;
                contador = 0;
                contador2 = 0;
                contador6 = 0;
                copia2.transform.position = new Vector3(copia2.transform.position.x, 4.17f, copia2.transform.position.z);
                copia6.transform.position = new Vector3(copia6.transform.position.x, 0.35f, copia6.transform.position.z);
            }
        }
            if (contador3 >= 1 && contador7 >= 1)
            {
                if (cpont3 < 1)
                {
                    pontuacao++;
                    contadordospares++;
                    cpont3++;
                }
                tempo4 -= Time.deltaTime;
                if (tempo4 <= 0)
                {
                    tempo = 0.7f;
                    tempo4 = 0;
                    cpont4 = 0;
                    contador = 0;
                    contador3 = 0;
                    contador7 = 0;
                    copia7.transform.position = new Vector3(copia7.transform.position.x, -3f, copia7.transform.position.z);
                    copia3.transform.position = new Vector3(copia3.transform.position.x, 1.31f, copia3.transform.position.z);
                }
            }
            if (contador > 1)
            {
                tempo -= Time.deltaTime;

                if (tempo <= 0)
                {
                    cpont4 = 0;
                    if (contador0 >= 1)
                    {

                        copia0.transform.position = posicoes[0].transform.position;
                        contador0 = 0;
                        contador = 0;
                        tempo = 0.7f;
                        if (cpont4 < 1)
                        {
                            jogadas--;
                            cpont4++;
                        }
                    }
                    if (contador1 >= 1)
                    {
                        copia1.transform.position = posicoes[1].transform.position;
                        contador1 = 0;
                        contador = 0;
                        tempo = 0.7f;
                        if (cpont4 < 1)
                        {
                            jogadas--;
                            cpont4++;
                        }
                    }
                    if (contador2 >= 1)
                    {
                        copia2.transform.position = posicoes[2].transform.position;
                        contador2 = 0;
                        contador = 0;
                        tempo = 0.7f;
                        if (cpont4 < 1)
                        {
                            jogadas--;
                            cpont4++;
                        }
                    }
                    if (contador3 >= 1)
                    {
                        copia3.transform.position = posicoes[3].transform.position;
                        contador3 = 0;
                        contador = 0;
                        tempo = 0.7f;
                        if (cpont4 < 1)
                        {
                            jogadas--;
                            cpont4++;
                        }
                    }
                    if (contador4 >= 1)
                    {
                        copia4.transform.position = posicoes[4].transform.position;
                        contador4 = 0;
                        contador = 0;
                        if (cpont4 < 1)
                        {
                            jogadas--;
                            cpont4++;
                        }
                        tempo = 0.7f;
                    }
                    if (contador5 >= 1)
                    {
                        copia5.transform.position = posicoes[5].transform.position;
                        contador5 = 0;
                        contador = 0;
                        if (cpont4 < 1)
                        {
                            jogadas--;
                            cpont4++;
                        }
                        tempo = 0.7f;
                    }
                    if (contador6 >= 1)
                    {
                        copia6.transform.position = posicoes[6].transform.position;
                        contador6 = 0;
                        contador = 0;
                        if (cpont4 < 1)
                        {
                            jogadas--;
                            cpont4++;
                        }
                        tempo = 0.7f;
                    }
                    if (contador7 >= 1)
                    {
                        copia7.transform.position = posicoes[7].transform.position;
                        contador7 = 0;
                        contador = 0;
                        if (cpont4 < 1)
                        {
                            jogadas--;
                            cpont4++;
                        }
                        tempo = 0.7f;

                    }
                }
            }
            if (jogadas <= 0)
            {
                gameOver();
            }

            if (jogadas < 3 && cpont5 < 1)
            {
                Destroy(coracao2);
                cpont5++;
            }
            if (jogadas < 2 && cpont6 < 1)
            {
                Destroy(coracao1);
                cpont6++;
            }
            if (jogadas < 1 && cpont7 < 1)
            {
                Destroy(coracao);
                cpont7++;
            }
    }

	void Spawn()
	{
		copia0 = Instantiate((animais[6]), posicoes[0].transform.position, posicoes[0].transform.rotation) as GameObject;
		copia1 = Instantiate((animais[0]), posicoes[1].transform.position, posicoes[1].transform.rotation) as GameObject;
		copia2 = Instantiate((animais[5]), posicoes[2].transform.position, posicoes[2].transform.rotation) as GameObject;
		copia3 = Instantiate((animais[2]), posicoes[3].transform.position, posicoes[3].transform.rotation) as GameObject;
		copia4 = Instantiate((animais[1]), posicoes[4].transform.position, posicoes[4].transform.rotation) as GameObject;
		copia5 = Instantiate((animais[4]), posicoes[5].transform.position, posicoes[5].transform.rotation) as GameObject;
		copia6 = Instantiate((animais[3]), posicoes[6].transform.position, posicoes[6].transform.rotation) as GameObject;
		copia7 = Instantiate((animais[7]), posicoes[7].transform.position, posicoes[7].transform.rotation) as GameObject;
	}

	public void troncose()
	{
		if (contador < 2)
		{
			if (copia0.transform.position.y < 4.06)
			{
				contador++;
				contador0++;
			}
			while (copia0.transform.position.y < 4.06)
			{
				copia0.transform.Translate(Vector3.up * velocidade * Time.deltaTime);
			}
		}
	}
	public void pedrasc()
	{
		if (contador < 2)
		{
			if (copia1.transform.position.y < 4.11)
			{
				contador++;
				contador1++;
			}
			while (copia1.transform.position.y < 4.11)
			{
				copia1.transform.Translate(Vector3.up * velocidade * Time.deltaTime);
			}
		}

	}
	public void pedrasd()
	{
		if (contador < 2)
		{
			if (copia2.transform.position.y < 4.17)
			{
				contador++;
				contador2++;
			}
			while (copia2.transform.position.y < 4.17)
			{
				copia2.transform.Translate(Vector3.up * velocidade * Time.deltaTime);
			}
		}
	}
	public void pedrame()
	{
		if (contador < 2)
		{
			if (copia3.transform.position.y < 1.31)
			{
				contador++;
				contador3++;
			}
			while (copia3.transform.position.y < 1.31)
			{
				copia3.transform.Translate(Vector3.up * velocidade * Time.deltaTime);
			}
		}
	}
	public void pedrame2()
	{
		if (contador < 2)
		{
			if (copia4.transform.position.y < -0.9)
			{
				contador++;
				contador4++;
			}
			while (copia4.transform.position.y < -0.9)
			{
				copia4.transform.Translate(Vector3.up * velocidade * Time.deltaTime);
			}
		}
	}
	public void pedramc()
	{
		if (contador < 2)
		{
			if (copia5.transform.position.y < 0.79)
			{
				contador++;
				contador5++;
			}
			while (copia5.transform.position.y < 0.79)
			{
				copia5.transform.Translate(Vector3.up * velocidade * Time.deltaTime);
			}
		}
	}
	public void troncoid()
	{
		if (contador < 2)
		{
			if (copia6.transform.position.y < 0.35)
			{
				contador++;
				contador6++;
			}
			while (copia6.transform.position.y < 0.35)
			{
				copia6.transform.Translate(Vector3.up * velocidade * Time.deltaTime);
			}
		}
	}
	public void arbusto()
	{
		if (contador < 2)
		{
			if (copia7.transform.position.y < -3)
			{
				contador++;
				contador7++;
			}
			while (copia7.transform.position.y < -3)
			{
				copia7.transform.Translate(Vector3.up * velocidade * Time.deltaTime);
			}
		}
	}
	public void gameOver()
	{
		gameOverpopup.SetActive(true);
		Time.timeScale = 0f;

	}
	public void restart()
	{
		popSeguranca.SetActive(true);
	}
	public void quit()
	{
		popSeguranca2.SetActive(true);
	}
	public void pausecall()
	{
		Time.timeScale = 0f;
		pausepopup.SetActive(true);
	}
	public void continuar()
	{
		Time.timeScale = 1f;
		pausepopup.SetActive(false);
	}

	public void Reiniciar()
	{
        int random = Random.Range(1, 4);
        if (random == 1)
        {
            Application.LoadLevel("memoria");
        }
        else if (random == 2)
        {
            Application.LoadLevel("memoriaop2");
        }
        else if (random == 3)
        {
            Application.LoadLevel("memoriaop3");
        }
    }

	public void Sair()
	{
		loading.SetActive (true);
		Time.timeScale = 1f;
		Application.LoadLevel("LivroAberto");
	}

	public void naoQuit()
	{
		popSeguranca2.SetActive(false);
	}

	public void naoRestart()
	{
		popSeguranca.SetActive(false);
	}




	public void restart_2()
	{
		popSeguranca_2.SetActive(true);
	}
	public void quit_2()
	{
		popSeguranca2_2.SetActive(true);
	}


	public void naoQuit_2()
	{
		popSeguranca2_2.SetActive(false);
	}

	public void naoRestart_2()
	{
		popSeguranca_2.SetActive(false);
	}



	public void restart_3()
	{
		popSeguranca_3.SetActive(true);
	}
	public void quit_3()
	{
		popSeguranca2_3.SetActive(true);
	}


	public void naoQuit_3()
	{
		popSeguranca2_3.SetActive(false);
	}

	public void naoRestart_3()
	{
		popSeguranca_3.SetActive(false);
	}
}
