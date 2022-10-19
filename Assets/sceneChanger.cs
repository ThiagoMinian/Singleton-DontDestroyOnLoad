using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    public string[] nombresEscenas;
    public int indexEscenas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarEscenaSecuencialmente()
    {
        if(indexEscenas >= nombresEscenas.Length)
        {
            indexEscenas = 0;
        }

        SceneManager.LoadScene(nombresEscenas[indexEscenas]);
        indexEscenas++;

    }
}
