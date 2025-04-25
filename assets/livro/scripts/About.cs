using UnityEngine;
using System.Collections;

public class About : MonoBehaviour {

    public int personagem;

	public GameObject loading;

    public GameObject Pernonagem1;
    public GameObject Pernonagem2;
    public GameObject Pernonagem3;
    public GameObject Pernonagem4;
    public GameObject Pernonagem5;
    public GameObject Pernonagem6;
    public GameObject MiniPernonagem1;
    public GameObject MiniPernonagem2;
    public GameObject MiniPernonagem3;
    public GameObject MiniPernonagem4;
    public GameObject MiniPernonagem5;
    public GameObject MiniPernonagem6;
    public GameObject MiniPernonagem1On;
    public GameObject MiniPernonagem2On;
    public GameObject MiniPernonagem3On;
    public GameObject MiniPernonagem4On;
    public GameObject MiniPernonagem5On;
    public GameObject MiniPernonagem6On;
    public GameObject SobrePersonagem1;
    public GameObject SobrePersonagem2;
    public GameObject SobrePersonagem3;
    public GameObject SobrePersonagem4;
    public GameObject SobrePersonagem5;
    public GameObject SobrePersonagem6;

    // Use this for initialization
    void Start () {

        personagem = 0;

	}
	
	// Update is called once per frame
	void Update () {

        switch (personagem)
        {
            case 1:

                Pernonagem1.SetActive(true);
                MiniPernonagem1.SetActive(false);
                MiniPernonagem1On.SetActive(true);
                SobrePersonagem1.SetActive(true);
                Pernonagem2.SetActive(false);
                MiniPernonagem2.SetActive(true);
                MiniPernonagem2On.SetActive(false);
                SobrePersonagem2.SetActive(false);
                Pernonagem3.SetActive(false);
                MiniPernonagem3.SetActive(true);
                MiniPernonagem3On.SetActive(false);
                SobrePersonagem3.SetActive(false);
                Pernonagem4.SetActive(false);
                MiniPernonagem4.SetActive(true);
                MiniPernonagem4On.SetActive(false);
                SobrePersonagem4.SetActive(false);
                Pernonagem5.SetActive(false);
                MiniPernonagem5.SetActive(true);
                MiniPernonagem5On.SetActive(false);
                SobrePersonagem5.SetActive(false);
                Pernonagem6.SetActive(false);
                MiniPernonagem6.SetActive(true);
                MiniPernonagem6On.SetActive(false);
                SobrePersonagem6.SetActive(false);

                break;

            case 2:

                Pernonagem1.SetActive(false);
                MiniPernonagem1.SetActive(true);
                MiniPernonagem1On.SetActive(false);
                SobrePersonagem1.SetActive(false);
                Pernonagem2.SetActive(true);
                MiniPernonagem2.SetActive(false);
                MiniPernonagem2On.SetActive(true);
                SobrePersonagem2.SetActive(true);
                Pernonagem3.SetActive(false);
                MiniPernonagem3.SetActive(true);
                MiniPernonagem3On.SetActive(false);
                SobrePersonagem3.SetActive(false);
                Pernonagem4.SetActive(false);
                MiniPernonagem4.SetActive(true);
                MiniPernonagem4On.SetActive(false);
                SobrePersonagem4.SetActive(false);
                Pernonagem5.SetActive(false);
                MiniPernonagem5.SetActive(true);
                MiniPernonagem5On.SetActive(false);
                SobrePersonagem5.SetActive(false);
                Pernonagem6.SetActive(false);
                MiniPernonagem6.SetActive(true);
                MiniPernonagem6On.SetActive(false);
                SobrePersonagem6.SetActive(false);

                break;

            case 3:

                Pernonagem1.SetActive(false);
                MiniPernonagem1.SetActive(true);
                MiniPernonagem1On.SetActive(false);
                SobrePersonagem1.SetActive(false);
                Pernonagem2.SetActive(false);
                MiniPernonagem2.SetActive(true);
                MiniPernonagem2On.SetActive(false);
                SobrePersonagem2.SetActive(false);
                Pernonagem3.SetActive(true);
                MiniPernonagem3.SetActive(false);
                MiniPernonagem3On.SetActive(true);
                SobrePersonagem3.SetActive(true);
                Pernonagem4.SetActive(false);
                MiniPernonagem4.SetActive(true);
                MiniPernonagem4On.SetActive(false);
                SobrePersonagem4.SetActive(false);
                Pernonagem5.SetActive(false);
                MiniPernonagem5.SetActive(true);
                MiniPernonagem5On.SetActive(false);
                SobrePersonagem5.SetActive(false);
                Pernonagem6.SetActive(false);
                MiniPernonagem6.SetActive(true);
                MiniPernonagem6On.SetActive(false);
                SobrePersonagem6.SetActive(false);

                break;

            case 4:

                Pernonagem1.SetActive(false);
                MiniPernonagem1.SetActive(true);
                MiniPernonagem1On.SetActive(false);
                SobrePersonagem1.SetActive(false);
                Pernonagem2.SetActive(false);
                MiniPernonagem2.SetActive(true);
                MiniPernonagem2On.SetActive(false);
                SobrePersonagem2.SetActive(false);
                Pernonagem3.SetActive(false);
                MiniPernonagem3.SetActive(true);
                MiniPernonagem3On.SetActive(false);
                SobrePersonagem3.SetActive(false);
                Pernonagem4.SetActive(true);
                MiniPernonagem4.SetActive(false);
                MiniPernonagem4On.SetActive(true);
                SobrePersonagem4.SetActive(true);
                Pernonagem5.SetActive(false);
                MiniPernonagem5.SetActive(true);
                MiniPernonagem5On.SetActive(false);
                SobrePersonagem5.SetActive(false);
                Pernonagem6.SetActive(false);
                MiniPernonagem6.SetActive(true);
                MiniPernonagem6On.SetActive(false);
                SobrePersonagem6.SetActive(false);

                break;

            case 5:

                Pernonagem1.SetActive(false);
                MiniPernonagem1.SetActive(true);
                MiniPernonagem1On.SetActive(false);
                SobrePersonagem1.SetActive(false);
                Pernonagem2.SetActive(false);
                MiniPernonagem2.SetActive(true);
                MiniPernonagem2On.SetActive(false);
                SobrePersonagem2.SetActive(false);
                Pernonagem3.SetActive(false);
                MiniPernonagem3.SetActive(true);
                MiniPernonagem3On.SetActive(false);
                SobrePersonagem3.SetActive(false);
                Pernonagem4.SetActive(false);
                MiniPernonagem4.SetActive(true);
                MiniPernonagem4On.SetActive(false);
                SobrePersonagem4.SetActive(false);
                Pernonagem5.SetActive(true);
                MiniPernonagem5.SetActive(false);
                MiniPernonagem5On.SetActive(true);
                SobrePersonagem5.SetActive(true);
                Pernonagem6.SetActive(false);
                MiniPernonagem6.SetActive(true);
                MiniPernonagem6On.SetActive(false);
                SobrePersonagem6.SetActive(false);

                break;

            case 6:

                Pernonagem1.SetActive(false);
                MiniPernonagem1.SetActive(true);
                MiniPernonagem1On.SetActive(false);
                SobrePersonagem1.SetActive(false);
                Pernonagem2.SetActive(false);
                MiniPernonagem2.SetActive(true);
                MiniPernonagem2On.SetActive(false);
                SobrePersonagem2.SetActive(false);
                Pernonagem3.SetActive(false);
                MiniPernonagem3.SetActive(true);
                MiniPernonagem3On.SetActive(false);
                SobrePersonagem3.SetActive(false);
                Pernonagem4.SetActive(false);
                MiniPernonagem4.SetActive(true);
                MiniPernonagem4On.SetActive(false);
                SobrePersonagem4.SetActive(false);
                Pernonagem5.SetActive(false);
                MiniPernonagem5.SetActive(true);
                MiniPernonagem5On.SetActive(false);
                SobrePersonagem5.SetActive(false);
                Pernonagem6.SetActive(true);
                MiniPernonagem6.SetActive(false);
                MiniPernonagem6On.SetActive(true);
                SobrePersonagem6.SetActive(true);

                break;

            default:

                Pernonagem1.SetActive(false);
                MiniPernonagem1.SetActive(true);
                MiniPernonagem1On.SetActive(false);
                SobrePersonagem1.SetActive(false);
                Pernonagem2.SetActive(false);
                MiniPernonagem2.SetActive(true);
                MiniPernonagem2On.SetActive(false);
                SobrePersonagem2.SetActive(false);
                Pernonagem3.SetActive(false);
                MiniPernonagem3.SetActive(true);
                MiniPernonagem3On.SetActive(false);
                SobrePersonagem3.SetActive(false);
                Pernonagem4.SetActive(false);
                MiniPernonagem4.SetActive(true);
                MiniPernonagem4On.SetActive(false);
                SobrePersonagem4.SetActive(false);
                Pernonagem5.SetActive(false);
                MiniPernonagem5.SetActive(true);
                MiniPernonagem5On.SetActive(false);
                SobrePersonagem5.SetActive(false);
                Pernonagem6.SetActive(false);
                MiniPernonagem6.SetActive(true);
                MiniPernonagem6On.SetActive(false);
                SobrePersonagem6.SetActive(false);

                break;
        }
	
	}

    public void sair()
    {
		loading.SetActive (true);
        Application.LoadLevel("LivroAberto");
    }

    public void b1()
    {
        personagem = 1;
    }

    public void b2()
    {
        personagem = 2;
    }

    public void b3()
    {
        personagem = 3;
    }

    public void b4()
    {
        personagem = 4;
    }

    public void b5()
    {
        personagem = 5;
    }

    public void b6()
    {
        personagem = 6;
    }
}
