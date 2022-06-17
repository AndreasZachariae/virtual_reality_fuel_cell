using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour


{

    public GameObject StartPos;
    public GameObject AutoPos;
    public GameObject Station2Pos;
    public float X;
    public float Y;
    public float Z;
    public float rotX;
    public float rotY;
    public float rotZ;

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
        StartPos.transform.localPosition =  new Vector3(X,Y,Z);
        StartPos.transform.localRotation =  Quaternion.Euler(rotX, rotY, rotZ);
    }
}
