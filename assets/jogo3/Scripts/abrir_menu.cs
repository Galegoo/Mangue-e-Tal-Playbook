using UnityEngine;
using System.Collections;

public class abrir_menu : MonoBehaviour {

    public GameObject popUp;
    
    public void ObjInterativo()
    {
        popUp.SetActive(true);
        Time.timeScale = 0f;
        
    }
}
