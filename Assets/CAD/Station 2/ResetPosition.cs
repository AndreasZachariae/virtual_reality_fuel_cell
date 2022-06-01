using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{ 
    public GameObject parts;
    Vector3 StartPosition;
    

    // Start is called before the first frame update
    void Start()
    {
        parts = this.gameObject;
        StartPosition =parts.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void reset()
        {
        parts.transform.position = StartPosition;
        }
    
}
