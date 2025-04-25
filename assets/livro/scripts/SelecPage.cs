using UnityEngine;
using System.Collections;

public class SelecPage : MonoBehaviour {

    public Book link;
    public GameObject load;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void parapag1()
    {
        link.currentPage = 2;
        load.SetActive(true);
        Application.LoadLevel("LivroAberto");
    }

    public void parapag3()
    {
        link.currentPage = 4;
        load.SetActive(true);
        Application.LoadLevel("LivroAberto");
    }

    public void parapag5()
    {
        link.currentPage = 6;
        load.SetActive(true);
        Application.LoadLevel("LivroAberto");
    }

    public void parapag7()
    {
        link.currentPage = 8;
        load.SetActive(true);
        Application.LoadLevel("LivroAberto");
    }


    public void parapag9()
    {
        link.currentPage = 10;
        load.SetActive(true);
        Application.LoadLevel("LivroAberto");
    }

    public void parapag11()
    {
        link.currentPage = 12;
        load.SetActive(true);
        Application.LoadLevel("LivroAberto");
    }

    public void parapag13()
    {
        link.currentPage = 14;
        load.SetActive(true);
        Application.LoadLevel("LivroAberto");
    }

    public void parapagCapa()
    {
        link.currentPage = 0;
        load.SetActive(true);
        Application.LoadLevel("LivroAberto");
    }
}
