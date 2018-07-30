using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject bulletPrefab;
    public GameObject ChasebulletPrefab;

    Vector3 m_StartPos;
    public bool chaseBullet = false;


    // Use this for initialization
    void Start()
    {

        m_StartPos = this.transform.position;



    }

    // Update is called once per frame
    void Update()
    {
      

        if (Input.GetMouseButtonDown(0))
        {
            if (WaitingTime.ready == true)
            {
                if (chaseBullet)
                {
                    var bullet2 = Instantiate(ChasebulletPrefab);
                    bullet2.transform.position = m_StartPos + transform.forward * 5f;
                    bullet2.transform.rotation = this.transform.rotation;
                    Debug.Log("asfr");
                    WaitingTime.ready = false;
                }
                else
                {
                    Debug.Log("a7mr");
                    var bullet = Instantiate(bulletPrefab);
                    bullet.transform.position = m_StartPos + transform.forward * 5f;
                    bullet.transform.rotation = this.transform.rotation;
                    WaitingTime.ready = false;

                }

            }
            else FindObjectOfType<ScoreManager>().UpdateScreen();
        }
        }




}



