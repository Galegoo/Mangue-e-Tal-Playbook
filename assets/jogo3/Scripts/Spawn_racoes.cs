using UnityEngine;
using System.Collections;

public class Spawn_racoes : MonoBehaviour {
    public float spawnRate =8;
    private bool isPositionPlayer = false;
    public int contador;
    public GameObject[] conjuntos;
    public GameObject[] conjuntosG;
    public bool troca = true;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (spawnRate <= 0)
        {

            Spawn();

        }
        else
        {

            spawnRate -= Time.deltaTime;

        }
        if (contador > 2)
        {
            contador = 1;
        }

    }

    private void Spawn()
    {
        isPositionPlayer = !isPositionPlayer;
        Vector3 spawnPosition;

        if (isPositionPlayer)
        {
            spawnPosition = new Vector3(Random.Range(-1.8f, 1.8f), transform.position.y, transform.position.z);

        }
        else
        {
            spawnPosition = new Vector3(Random.Range(-1.8f, 1.8f), transform.position.y, transform.position.z);

        }

        if (troca)
        {
            Instantiate((conjuntos[contador = (Random.Range(0, 4))]), spawnPosition, transform.rotation);
            spawnRate = 8f;
            troca = !troca;
        }
        else
        {
            Instantiate((conjuntosG[contador = (Random.Range(0, 4))]), spawnPosition, transform.rotation);
            spawnRate = 8f;
            troca = !troca;
        }
    }
}
