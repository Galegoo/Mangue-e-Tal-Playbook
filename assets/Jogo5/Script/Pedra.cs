using UnityEngine;
using System.Collections;

public class Pedra : MonoBehaviour {

    public float velocidade = 5;
    public int caseSwitch = 1;

    public Energia link;


    void Awake()
    {
        link = GameObject.Find("BarradeEnergia").GetComponent<Energia>();
    }

    // Use this for initialization
    void Start () {
        nivel();
        Destroy(gameObject, 6f);

	}
	
	// Update is called once per frame
	void Update () {

        nivel();
        transform.Translate(Vector2.left * velocidade * Time.deltaTime);


        
    }

    public void nivel()
    {
        switch (caseSwitch)
        {
            case 1:
                velocidade = 6;
                break;
            case 2:
                velocidade = 7;
                break;
            default:
                velocidade = 9f;
                break;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        switch (coll.gameObject.tag)
        {
            case "Player":
                link.energia -= 10;
                Destroy(gameObject);
                break;
            case "Lixeira":
                Destroy(gameObject);
                break;
        }
    }
}
