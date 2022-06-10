using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InSnapZone : MonoBehaviour
{
    public GameObject textCanvas;
    public GameObject snapObjectViz;

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
        textCanvas.SetActive(true);
        snapObjectViz.SetActive(false);
    }

    public void deactivate()
    {
        textCanvas.SetActive(false);
        snapObjectViz.SetActive(true);
    }
}
