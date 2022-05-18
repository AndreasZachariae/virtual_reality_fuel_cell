using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InSnapZone : MonoBehaviour
{
    public GameObject interactionObject;

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
        interactionObject.SetActive(true);
    }

    public void deactivate()
    {
        interactionObject.SetActive(false);
    }
}
