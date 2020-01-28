using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerPress : MonoBehaviour
{
    // Start is called before the first frame update
    private double randomFallTime;
    double timer;
    double fps;
    bool resetFallTime;
    public bool fall;
    public bool ispressed = false;

    void Start()
    {
        fall = false;
    }

    void Update()
    {
        if (!ispressed)
        {

            fall = false;
            return;
        }
       
        timer += Time.deltaTime;


        if(timer > randomFallTime)
        {
            fall = true;
        }

        // DO SOMETHING HERE
        Debug.Log("Pressed");
        Debug.Log("elapsed time = " + timer);
        Debug.Log("fall time = " + randomFallTime);


    }
    
    public void OnMouseDown()
    {
        if (!ispressed)
        {
            ispressed = true;
            randomFallTime = Random.Range(4.0f, 10.0f);
        }
        else
        {
            
        }
    }
    public void OnMouseUp()
    {
        timer = 0;
        ispressed = false;
    }
}
