using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour
{

    public int velocidade = -5;
    public bool anda = false;


    public void OnMouseDown()
    {
        anda = true;

    }

    public void OnMouseUp()
    {
        anda = false;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (anda)
            transform.Translate(Vector2.right * velocidade * Time.deltaTime);
        else {
            transform.Translate(Vector2.right * 0 * Time.deltaTime);
        }
    }

}
