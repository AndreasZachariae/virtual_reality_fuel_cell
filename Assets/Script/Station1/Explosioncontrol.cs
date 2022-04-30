using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Explosioncontrol : MonoBehaviour
{
    public GameObject Fuel_Cell;
    private Animator anim;
    private Slider ExplosionSlider;

    // Start is called before the first frame update
    void Start()
    {
        ExplosionSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void applyExplosion()
    {
        anim = Fuel_Cell.GetComponent<Animator>();
        if(anim)
        {
            anim.SetFloat("ExplosionSlider", ExplosionSlider.value);
        }
    }
}
