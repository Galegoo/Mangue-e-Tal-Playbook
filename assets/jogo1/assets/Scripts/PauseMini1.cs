using UnityEngine;
using System.Collections;

public class PauseMini1 : MonoBehaviour {

    public GameObject popUp;

    public void ObjInterativo()
    {
        popUp.SetActive(true);
        Time.timeScale = 0f;
    }
}
