using UnityEngine;
using System.Collections;

public class Pena : MonoBehaviour
{


    public Gerenciador spawnlink;
    public int velocidade = 5;
    public int vida = 1;


    void Awake()
    {
        spawnlink = GameObject.Find("Gerenciador").GetComponent<Gerenciador>();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.down * velocidade * Time.deltaTime);

    }

    public void OnCollisionEnter2D(Collision2D colisor)
    {  
            if (colisor.gameObject.tag == "Player")
            {
                spawnlink.vidas += vida;
                Destroy(gameObject);
            }
            if (colisor.gameObject.tag == "Destruidor")
            {
                Destroy(gameObject);
            }
        
    }
}
