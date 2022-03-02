using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private Transform tr;
    // Start is called before the first frame update
    public float movespeed = 10.0f;
    public float turnspeed = 80.0f;
    void Start()
    {
        tr=GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float r = Input.GetAxis("Mouse X");
        Debug.Log("H:"+h);
        Debug.Log("v:"+v);

        Vector3 movedir = (Vector3.forward * v) + ( Vector3.right * h);
        tr.Translate(movedir * movespeed * Time.deltaTime);
        tr.Rotate(Vector3.up * turnspeed * Time.deltaTime * r);
    } 
}
