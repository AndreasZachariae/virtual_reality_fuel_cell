using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testskript : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        ball.transform.position = Vector3.zero;
    }
}
