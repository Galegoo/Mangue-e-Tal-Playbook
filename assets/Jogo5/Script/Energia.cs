using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Energia : MonoBehaviour {

    public GameObject derrota;
    public GameObject Hud;
    public Score1 link;
    
    public float energia;
    public Texture energiaT, contorno;
    public int energiaMax;
    public int switchcase;

    public TextMesh pontuacaoText;

	// Use this for initialization
	void Start () {

        switchcase = 1;
        energiaMax = 100;
        energia = energiaMax;
	
	}
	
	// Update is called once per frame
	void Update () {

        switch (switchcase)
        {
            case 1:

                energia -= Time.deltaTime;

                break;

            case 2:

                energia -= 2*Time.deltaTime;

                break;

            case 3:

                energia -= 3*Time.deltaTime;

                break;

            default:
                break;
        }
        
        if(energia >= energiaMax)
        {
            energia = energiaMax;
        }
        else if(energia <= 0)
        {
            energia = 0;
        }
        if(energia <= 0)
        {
            pontuacaoText.text = ("" + link.pontos).ToString();
            Time.timeScale = 0f;
            Hud.SetActive(false);
            derrota.SetActive(true);
        }
	}

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(Screen.width / 40, Screen.height / 40, Screen.width / 5f, Screen.height / 8), contorno);
        GUI.DrawTexture(new Rect(Screen.width / 10, Screen.height / 15, Screen.width / 8.5f / energiaMax * energia, Screen.height / 70), energiaT);       
    }
}
