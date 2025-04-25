using UnityEngine;
using System.Collections;

public class popUp : MonoBehaviour {
    public GameObject popup;


    public void desativaPOP()
    {
        Time.timeScale = 1;
        popup.SetActive(false);
    }    
}
