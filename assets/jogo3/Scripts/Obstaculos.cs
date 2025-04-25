using UnityEngine;
using System.Collections;

public class Obstaculos : MonoBehaviour {

    public Gerenciador spawnlink;

    void Awake()
    {
        spawnlink = GameObject.Find("Gerenciador").GetComponent<Gerenciador>();
    }

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {


    }

    public void OnCollisionEnter2D(Collision2D colisor)
    {
        if (colisor.gameObject.tag == "Player")
        {
            spawnlink.vidas--;
            spawnlink.erros++;
            Destroy(gameObject);
        }
         else if (colisor.gameObject.tag == "Destruidor")
        {
            Destroy(gameObject);
        }
    }

}
