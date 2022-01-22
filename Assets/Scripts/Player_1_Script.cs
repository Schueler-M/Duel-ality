using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1_Script : MonoBehaviour
{
    public int speed = 0;
    public int life_meter = 100;
    public Transform transform;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(Time.deltaTime * speed, 0, 0);
            Debug.Log("Horizontal output right");
        }
        if (Input.GetKey("a"))
        {
            transform.position -= new Vector3(Time.deltaTime * speed, 0, 0);
            Debug.Log("Horizontal output left");
        }

    }
}