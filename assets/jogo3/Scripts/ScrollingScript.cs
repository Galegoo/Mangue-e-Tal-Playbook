using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
 class ScrollingScript : MonoBehaviour {

    public Vector2 speed = new Vector2(3, 3);
    public Vector2 direcao = new Vector2(0, -10);
    public float velocidade = 1f;
    public bool isLooping = false;
    private List<Transform> backgroundPart;
    

    // Use this for initialization
    void Start () {
	
        if (isLooping)
        {
            backgroundPart = new List<Transform>();
            for (int i = 0; i < transform.childCount; i++)
            {
                Transform child = transform.GetChild(i);
                if (child.GetComponent<Renderer>() != null)
                {
                    backgroundPart.Add(child);
                }
            }

            backgroundPart = backgroundPart
                .OrderBy(t => t.position.y).ToList();

        }

	}
	
	// Update is called once per frame
	void Update () {

        Vector2 movimento = new Vector2(
            speed.x * direcao.x * velocidade,
            speed.y * direcao.y);

        movimento *= Time.deltaTime;

        transform.Translate(movimento);

        if (isLooping)
        {
            Transform firstChild = backgroundPart.FirstOrDefault();
            if(firstChild != null)
            {
                if (firstChild.position.y < Camera.main.transform.position.y)
                {
                    if (!firstChild.GetComponent<Renderer>().isVisibleFrom(Camera.main))
                    {
                        Transform lastChild = backgroundPart.LastOrDefault();
                        Vector3 lastPosition = lastChild.position;
                        Vector3 lastSize = (lastChild.GetComponent<Renderer>().bounds.max -
                                            lastChild.GetComponent<Renderer>().bounds.min);

                        firstChild.position = new Vector3(
                            firstChild.position.x,
                            lastPosition.y + lastSize.y,                            
                            firstChild.position.z);
                        backgroundPart.Remove(firstChild);
                        backgroundPart.Add(firstChild);
                    }
                }
            }
        }

	}

}
