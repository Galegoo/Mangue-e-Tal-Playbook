using UnityEngine;
using System.Collections;

public class VoltarPag : MonoBehaviour {

    public string LivroAberto;
	public GameObject loading;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void voltarLivro()
    {
		loading.SetActive (true);
        Application.LoadLevel("LivroAberto");
    }
}
