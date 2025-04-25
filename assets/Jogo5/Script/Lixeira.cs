using UnityEngine;
using System.Collections;

public class Lixeira : MonoBehaviour {

    public float velocidade = 5;
    public int caseSwitch = 1;

    public Score1 spawnLink;
    public DogMovement link;
    public Energia link2;

    void Awake()
    {

        spawnLink = GameObject.Find("Gerenciador").GetComponent<Score1>();
        link = GameObject.Find("PlayerDog").GetComponent<DogMovement>();
        link2 = GameObject.Find("BarradeEnergia").GetComponent<Energia>();
    }


    // Use this for initialization
    void Start()
    {

        Destroy(gameObject, 6f);

    }

    // Update is called once per frame
    void Update()
    {

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

    void OnTriggerEnter2D(Collider2D colli)
    {
        if (colli.gameObject.tag == "Player")
        {
            if(link.lixoQTD != 0)
            {
                spawnLink.pontos += link.lixoQTD * 25;
                link2.energia += 5 * link.lixoQTD;
                if (link.lixoQTD == 10)
                {
                    spawnLink.pontos += 100;
                }

                link.lixoQTD = 0;
            }
        }
    }
}