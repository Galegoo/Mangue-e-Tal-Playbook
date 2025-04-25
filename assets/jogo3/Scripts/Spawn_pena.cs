using UnityEngine;
using System.Collections;

public class Spawn_pena : MonoBehaviour {

    public float spawnRate = 40f;
    private bool isPositionPlayer = false;
    public Transform pena;



    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

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

        if (isPositionPlayer)
        {
            spawnPosition = new Vector3(Random.Range(-2.5f, 2.5f), transform.position.y, transform.position.z);

        }
        else
        {
            spawnPosition = new Vector3(Random.Range(-2.5f, 2.5f), transform.position.y,transform.position.z);

        }
        var inimigoTransform2 = Instantiate(pena) as Transform;
        inimigoTransform2.position = spawnPosition;


        spawnRate = 40f;
    }
}
