using UnityEngine;
using System.Collections;

public class DogMovement : MonoBehaviour
{
    Vector3 velocity = Vector3.zero;
    public Vector3 gravity;
    public Vector3 flapVelocity;
    public float maxSpeed = 5f;
    public bool pular = false;
    public int lixoQTD;

    public TextMesh QTDLixos;

    public Score link;

    bool didFlap = false;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;
    }
    //Do graphic & input updates here
    void Update()
    {
        if (pular)
        {
            didFlap = true;
            pular = false;
        }
        if (maxSpeed > 5)
        {
            maxSpeed = 5;
        }

        if (lixoQTD > 10)
        {
            lixoQTD = 10;
        }

        QTDLixos.text = (""+lixoQTD)+"/10";
    }


    // Do physics engine updates here
    void FixedUpdate()
    {
        velocity += gravity * Time.deltaTime;

        if (didFlap == true)
        {
            didFlap = false;
            velocity += flapVelocity;
        }


        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);

        transform.position += velocity * Time.deltaTime;


    }
}
