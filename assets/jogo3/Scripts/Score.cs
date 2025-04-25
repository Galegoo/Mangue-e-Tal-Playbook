using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Gerenciador spawnlink;
    public Text scoreText;
    public Text vidaText;
    public Text brinquedosText;

    public GameObject pena1;
    public GameObject pena2;
    public GameObject pena3;

    void Awake()
    {
        spawnlink = GameObject.Find("Gerenciador").GetComponent<Gerenciador>();
    }
    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {

        if(spawnlink.vidas == 3)
        {
            pena1.SetActive(true);
            pena2.SetActive(true);
            pena3.SetActive(true);
        }
        else if(spawnlink.vidas == 2)
        {
            pena1.SetActive(true);
            pena2.SetActive(true);
            pena3.SetActive(false);
        }
        else if (spawnlink.vidas == 1)
        {
            pena1.SetActive(true);
            pena2.SetActive(false);
            pena3.SetActive(false);
        }
        else if (spawnlink.vidas == 0)
        {
            pena1.SetActive(false);
            pena2.SetActive(false);
            pena3.SetActive(false);
        }

        scoreText.text = "" + Mathf.Round(spawnlink.pontuacao);
        brinquedosText.text = "" + Mathf.Round(spawnlink.brinquedos);
    }
}
