using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXController : MonoBehaviour
{

    public ParticleSystem leftFoot, rightFoot;


    void FootStepEvent(int f)
    {
        Debug.Log("foot stepped: " + f);
        if (f == 0)
        {
            leftFoot.Play();
        }
        else { rightFoot.Play(); }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}