using UnityEngine;
using System.Collections;

public class FechaPreload : MonoBehaviour {

    public GameObject preload;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void fecharPreload()
    {
        preload.SetActive(false);
    }
}
