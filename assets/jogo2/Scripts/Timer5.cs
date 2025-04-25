using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer5 : MonoBehaviour {

	public float timeLeft;
    public Text tempoTexto;
    public float minutos;
    public float segundos;
    public GameObject painelGameOver;
    public AudioSource musicaDeFundo;
    public int controle;

    public void GameOver()
    {
        painelGameOver.SetActive(true);
        Time.timeScale = 0f;
        /*if (musicaDeFundo.isPlaying)
        {
            musicaDeFundo.Stop();
        }*/
    }

	// Use this for initialization
	void Start () {
		}
	
	// Update is called once per frame
	void Update () {
        if (controle < 1)
        {
            timeLeft -= Time.deltaTime;
        }
        minutos = Mathf.Floor(timeLeft / 60);
        segundos = Mathf.Floor(timeLeft % 60);
        if ( timeLeft <= 0 ){
			GameOver();
		}
        tempoTexto.text = System.String.Format("{0:00}:{1:00}", minutos, segundos);
    }
}

