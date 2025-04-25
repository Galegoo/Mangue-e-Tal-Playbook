using UnityEngine;
using System.Collections;

public class SpawnPedra : MonoBehaviour
{
    public float spawnRate;
    public int contador;
    public GameObject[] inimigos;
    public int caseSwitch;

    // Use this for initialization
    void Start()
    {
        spawnRate = 5.35f;
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
        Vector3 spawnPosition1;
        Vector3 spawnPosition2;
        Vector3 spawnPosition3;

        switch (caseSwitch)
        {
            case 1:               
                spawnRate = 5.35f;
                spawnPosition1 = new Vector3(transform.position.x, Random.Range(-1f, 3.7f), transform.position.z);
                Instantiate((inimigos[contador = (Random.Range(0, 3))]), spawnPosition1, transform.rotation);
                break;

            case 2:
                spawnRate = 5.35f;
                spawnPosition2 = new Vector3(transform.position.x, Random.Range(-1f, 3.7f), transform.position.z);
                Instantiate((inimigos[contador = (Random.Range(0, 3))]), spawnPosition2, transform.rotation);
                break;
            default:
                spawnRate = 5.35f;
                spawnPosition3 = new Vector3(transform.position.x, Random.Range(-1f, 3.7f), transform.position.z);
                Instantiate((inimigos[contador = (Random.Range(0, 3))]), spawnPosition3, transform.rotation);
                break;
        }
           

    }

}
