using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MoveScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        x = (float)(0.1 * x);
        y = (float)(0.1 * y);
        transform.position += new Vector3(x, y);

    }
}