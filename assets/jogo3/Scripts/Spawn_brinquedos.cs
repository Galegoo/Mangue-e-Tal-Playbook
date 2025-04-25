using UnityEngine;
using System.Collections;

public class Spawn_brinquedos : MonoBehaviour {

    public float spawnRate = 10f;
    private bool isPositionPlayer = false;
    public Transform [] brinquedo;
    public int i;



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

    }

    private void Spawn()
    {
        isPositionPlayer = !isPositionPlayer;
        Vector3 spawnPosition;

            spawnPosition = new Vector3(Random.Range(-2.5f, 2.5f), transform.position.y, transform.position.z);
        i = Random.Range(0, brinquedo.Length);

        var inimigoTransform2 = Instantiate(brinquedo[i]) as Transform;
        inimigoTransform2.position = spawnPosition;


        spawnRate = 10f;
    }
}
