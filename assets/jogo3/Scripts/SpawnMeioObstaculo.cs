using UnityEngine;
using System.Collections;

public class SpawnMeioObstaculo : MonoBehaviour {

    public float spawnRate = 1f;
    private bool isPositionPlayer = false;
    public GameObject[] obstaculos;
    public int i;
    public GameObject[] ilustracoes;
    public int contador =1;



    // Use this for initialization
    void Start()
    {
        contador = 1;
        spawnRate = 2f;
    }

    // Update is called once per frame
    void Update()
    {

        if (spawnRate <= 0 && contador <= 3)
        {

            SpawnIlustracao();

        }
        else if (spawnRate <=0 && contador >= 3) {
            SpawnObstaculo();
        }
        else
        {

            spawnRate -= Time.deltaTime;

        }

    }

    private void SpawnObstaculo()
    {
        isPositionPlayer = !isPositionPlayer;
        Vector3 spawnPosition;

        spawnPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        i = Random.Range(0, obstaculos.Length);
        var inimigoTransform2 = Instantiate(obstaculos[i]);
        inimigoTransform2.transform.position = spawnPosition;


        spawnRate = 1.3f;
        contador = 1;
    }
    private void SpawnIlustracao()
    {
        isPositionPlayer = !isPositionPlayer;
        Vector3 spawnPosition;

        spawnPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        i = Random.Range(0, ilustracoes.Length);
        var inimigoTransform2 = Instantiate(ilustracoes[i]);
        inimigoTransform2.transform.position = spawnPosition;

        spawnRate = 1.3f;
        contador++;
    }
}
