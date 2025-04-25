using UnityEngine;
using System.Collections;

public class AbrePause : MonoBehaviour {

    public GameObject menuPause;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Pausou()
    {
        menuPause.SetActive(true);
    }
}
