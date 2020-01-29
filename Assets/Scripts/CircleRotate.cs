using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleRotate : MonoBehaviour
{
    // Start is called before the first frame update
    float timeAccel;

    public FingerPress fingerscript;
    void Start()
    {
        timeAccel = Time.deltaTime;
        fingerscript = GameObject.Find("FingerPressBtn").GetComponent<FingerPress>();

    }

    // Update is called once per frame
    void Update()
    {
        if (fingerscript.ispressed)
        {
            transform.Rotate(0, 0, 90 * Time.deltaTime * timeAccel, Space.Self);
            timeAccel = timeAccel + Time.deltaTime;
        }
        else
        {
            timeAccel = 0;
        }

    }



}
