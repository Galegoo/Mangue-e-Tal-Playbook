﻿using UnityEngine;
using System.Collections;

public class Pula : MonoBehaviour {

    public DogMovement pulo;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnMouseDown()
    {
        pulo.pular = true;
    }
}
