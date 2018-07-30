using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Vector3 rot;

    // Use this for initialization
    void Start()
    {
        rot = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {


        var x = Input.GetAxis("Horizontal") * 2f;
        var y = Input.GetAxis("Vertical") * 2f;

        rot.y += x;
        rot.x -= y;

        rot.x = Mathf.Clamp(rot.x, -50f, 50f);



        transform.rotation = Quaternion.Euler(rot);
        
    }
}
