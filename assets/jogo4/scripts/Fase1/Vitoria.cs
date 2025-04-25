using UnityEngine;
using System.Collections;

public class Vitoria : MonoBehaviour {

    public Fase1 link;

    public GameObject portao;
    public GameObject painelWin;

    public int velocidade = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        if (link.venceu)
        {
            if(portao.transform.position.y < 7)
            {
                portao.transform.Translate(Vector2.up * velocidade * Time.deltaTime);
            }

            else
            {
                painelWin.SetActive(true);
            }      
        }
	}
}
