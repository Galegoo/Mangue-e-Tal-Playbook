using UnityEngine;
using System.Collections;

public class Abrir_menu : MonoBehaviour {

    public GameObject popUp;
    public GameObject Hud;

    public void ObjInterativo()
    {
        Hud.SetActive(false);
        popUp.SetActive(true);
        Time.timeScale = 0f;
    }
}
