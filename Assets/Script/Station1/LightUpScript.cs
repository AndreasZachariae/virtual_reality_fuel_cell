using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightUpScript : MonoBehaviour
{
    public MeshRenderer thisComponent;
    public Material lightcolor;
    public Material darkcolor;


    // Start is called before the first frame update
    void Start()
    {
        thisComponent = gameObject.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Material[] materials = thisComponent.materials;
        if (collision.transform.CompareTag("Electron1"))
        {
            // StartCoroutine(FlickerAnimation());
            thisComponent.material = lightcolor;
            Debug.Log("Let there be light!!!");
            materials[1] = lightcolor;
            thisComponent.materials = materials;
            System.Threading.Thread.Sleep(1000);
            materials[1] = darkcolor;
            thisComponent.materials = materials;
        }
        if (collision.transform.CompareTag("Electron1 (1)"))
        {
            // StartCoroutine(FlickerAnimation());
            thisComponent.material = lightcolor;
            Debug.Log("Let there be light!!!");
            materials[1] = lightcolor;
            thisComponent.materials = materials;
            System.Threading.Thread.Sleep(1000);
            materials[1] = darkcolor;
            thisComponent.materials = materials;
        }
        if (collision.transform.CompareTag("Electron2"))
        {
            // StartCoroutine(FlickerAnimation());
            thisComponent.material = lightcolor;
            Debug.Log("Let there be light!!!");
            materials[1] = lightcolor;
            thisComponent.materials = materials;
            System.Threading.Thread.Sleep(1000);
            materials[1] = darkcolor;
            thisComponent.materials = materials;
        }
        if (collision.transform.CompareTag("Electron2 (1)"))
        {
            // StartCoroutine(FlickerAnimation());
            thisComponent.material = lightcolor;
            Debug.Log("Let there be light!!!");
            materials[1] = lightcolor;
            thisComponent.materials = materials;
            System.Threading.Thread.Sleep(1000);
            materials[1] = darkcolor;
            thisComponent.materials = materials;
        }
    }
}
