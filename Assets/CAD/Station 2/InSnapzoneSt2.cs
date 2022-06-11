using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InSnapzoneSt2 : MonoBehaviour
{
    public GameObject nextSnap;
    public GameObject nextCanvas;
    public GameObject PreviousCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    public void activate()
    {
        nextSnap.SetActive(true);
        nextCanvas.SetActive(true);
        PreviousCanvas.SetActive(false);
    }
}
