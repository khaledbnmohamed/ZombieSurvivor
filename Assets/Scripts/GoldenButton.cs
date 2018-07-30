using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenButton : MonoBehaviour
{

    public void click()
    {


        if (FindObjectOfType<Shooting>().chaseBullet == false)
            FindObjectOfType<Shooting>().chaseBullet = true;
        else FindObjectOfType<Shooting>().chaseBullet = false;



    }
}
