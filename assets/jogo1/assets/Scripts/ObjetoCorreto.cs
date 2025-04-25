using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ObjetoCorreto : MonoBehaviour {

    public GameObject[] posicoes;
    public int contador;
    public GameObject[] objeto;
    public float escala;
    public GameObject hudInventario;
    public AudioSource pistaEncontrada;
    public Timer theTimer;
    public AudioSource somVitoria;
    public bool controlador;

    public GameObject painelWin;

    public void Start()
    {
        controlador = true;

    }

    public IEnumerator PlaySomVitoria()
    {
        yield return new WaitForSeconds(1);
        somVitoria.Play();
    }

    public void moverInventarioPorca()
    {
        objeto[0].transform.position = posicoes[contador].transform.position;
        objeto[0].transform.localScale = new Vector3(escala, escala, escala);
        objeto[0].transform.parent = hudInventario.transform.parent;
        contador++;
        pistaEncontrada.Play();
    }

    public void moverInventarioPelo()
    {
        objeto[1].transform.position = posicoes[contador].transform.position;
        objeto[1].transform.localScale = new Vector3(1f, 1f, 0.3f);
        objeto[1].transform.parent = hudInventario.transform.parent;
        contador++;
        pistaEncontrada.Play();
    }
    public void moverInventarioPegada()
    {
        objeto[2].transform.position = posicoes[contador].transform.position;
        objeto[2].transform.localScale = new Vector3(1f, 1f, 1f);
        objeto[2].transform.parent = hudInventario.transform.parent;
        contador++;
        pistaEncontrada.Play();
    }
    public void moverInventarioParafuso()
    {
        objeto[3].transform.position = posicoes[contador].transform.position;
        objeto[3].transform.localScale = new Vector3(escala, escala, escala);
        objeto[3].transform.parent = hudInventario.transform.parent;
        contador++;
        pistaEncontrada.Play();
    }

    void Update()
    {
        if (contador > 2 & controlador == true)
        {
            painelWin.SetActive(true);
            StartCoroutine("PlaySomVitoria");
            controlador = false;
        }
    }
}
