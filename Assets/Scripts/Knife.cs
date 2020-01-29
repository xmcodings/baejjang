using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Knife : MonoBehaviour
{
    // Start is called before the first frame update

    public FingerPress fingerscript;
    public int stage;
    public GameObject finbtn;

    private Transform target;
    float step;
    int ratio;
    Vector3 originalPos;

    void Start()
    {
        originalPos = new Vector3(1, 7, 0);
        fingerscript = GameObject.Find("FingerPressBtn").GetComponent<FingerPress>();
        ratio = 10;    
        stage = 10;
        step = Time.deltaTime * stage * ratio;
        finbtn = GameObject.Find("FingerPressBtn");
        target = finbtn.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        if(fingerscript.fall)
        {
            Debug.Log("falllllllll!!!!!!!!");
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        }
        if(fingerscript.ispressed && transform.position.y < -5.5)
        {

            Debug.Log("game0ver");
            SceneManager.LoadScene("gameOver", LoadSceneMode.Single);

        }

        if(!fingerscript.ispressed)
        {
            transform.position = originalPos;
        }

    }
}
