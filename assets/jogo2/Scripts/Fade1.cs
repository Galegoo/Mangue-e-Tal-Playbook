using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Fade1 : MonoBehaviour {

	public Image imagem;
	public Color c;
	public float tempo;

	public bool fase2;

	// Use this for initialization
	void Start () {

		imagem = GetComponent<Image>();

		c = imagem.color;
		imagem.color = c;

		c.a = 0;
	
		tempo = 2f;
	}
	
	// Update is called once per frame
	void Update () {
	
		imagem.color = c;

		if (fase2) 
		{
			c.a+= 2*Time.deltaTime;
			tempo -= Time.deltaTime;
		}

		if (fase2 && tempo <= 0)
		{
            int random = Random.Range(1, 4);
            if (random == 1)
            {
                Application.LoadLevel("memoria2");
            }
            else if (random == 2)
            {
                Application.LoadLevel("memoria2op2");
            }
            else if (random == 3)
            {
                Application.LoadLevel("memoria2op3");
            }
        }

	}
}
