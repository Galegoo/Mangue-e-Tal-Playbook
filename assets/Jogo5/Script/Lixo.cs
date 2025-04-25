using UnityEngine;
using System.Collections;

public class Lixo : MonoBehaviour {

    public float velocidade = 5;
    public int caseSwitch = 1;

    public Score1 spawnLink;
    public DogMovement link;

    void Awake()
    {

        spawnLink = GameObject.Find("Gerenciador").GetComponent<Score1>();
        link = GameObject.Find("PlayerDog").GetComponent<DogMovement>();
    } 


    // Use this for initialization
    void Start () {

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
                link.lixoQTD++;
                spawnLink.pontos += 10;
                Destroy(gameObject);
                break;
            case "Lixeira":
                Destroy(gameObject);
                break;
        }
    }

}
