using UnityEngine;
using System.Collections;

public class Conjuntos_destruidor : MonoBehaviour
{

    public int velocidade = 5;

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * velocidade * Time.deltaTime);
    }
   
}
