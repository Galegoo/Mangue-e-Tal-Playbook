using UnityEngine;
using System.Collections;

public class racao_pequena : MonoBehaviour
{

    public Gerenciador spawnlink;

    public int pontos = 10;


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


    }

    public void OnCollisionEnter2D(Collision2D colisor)
    {
        if (colisor.gameObject.tag == "Player")
        {
            spawnlink.pontuacao += pontos;
            spawnlink.racoes++;
            Destroy(gameObject);
        }

        if (colisor.gameObject.tag == "Destruidor")
        {
            Destroy(gameObject);
        }

    }
}
