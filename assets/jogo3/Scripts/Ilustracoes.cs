using UnityEngine;
using System.Collections;

public class Ilustracoes : MonoBehaviour
{
    public int velocidade = 5;
    void Update()
    {

        transform.Translate(Vector2.down * velocidade * Time.deltaTime);
    }

    public void OnCollisionEnter2D(Collision2D colisor)
    {
        if (colisor.gameObject.tag == "Destruidor")
        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D colisor)
    {
        if (colisor.gameObject.tag == "Destruidor")
        {
            Destroy(gameObject);
        }
    }
}
