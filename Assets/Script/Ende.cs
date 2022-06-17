using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;


public class Ende : MonoBehaviour
{
    // Start is called before the first frame update
   public void exitgame()
    {
        if (Application.isEditor)
        {
#if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
#endif
            // comment to fill if 
        }
        else
        {
            Debug.Log("Beende das Spiel...");
            Application.Quit();
        }

    }

    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
