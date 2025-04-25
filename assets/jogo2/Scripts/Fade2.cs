using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Fade2 : MonoBehaviour {

	public Image imagem;
	public Color c;

	public bool fase2;

	// Use this for initialization
	void Start () {
	
		imagem = GetComponent<Image>();

		c = imagem.color;
		imagem.color = c;

		c.a = 1;

		fase2 = true;
	}
	
	// Update is called once per frame
	void Update () {
	
		imagem.color = c;

		if (fase2) 
		{
			c.a-= 2*Time.deltaTime;
		}


	}
}
