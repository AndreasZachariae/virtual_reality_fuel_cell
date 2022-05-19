using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateGameObjects : MonoBehaviour
{
    public GameObject activationObject;
    public Button thisButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onButtonClick()
    {
        if (activationObject.activeInHierarchy == true)
            activationObject.SetActive(false);
        else
            activationObject.SetActive(true);

        thisButton.interactable = true;
    }

    public void onButtonClickDeactivate()
    {
        if (activationObject.activeInHierarchy == false)
            activationObject.SetActive(true);
        else
            activationObject.SetActive(false);

        thisButton.interactable = true;
    }
}
