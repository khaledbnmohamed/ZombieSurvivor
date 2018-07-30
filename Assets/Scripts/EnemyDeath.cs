using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{

    public static int life;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per framezsdd
    void Update()
    {



    }
    private void OnCollisionEnter(Collision collision)
    {

        if (life == 0)
        {
            Destroy(this.gameObject);
            Debug.Log("got hit " + collision.gameObject.name);
            FindObjectOfType<ScoreManager>().AddScore(1);

        }
        else
        {
            Debug.Log("ahlaaaan ana lsa mmamtosh");
            life = life - 1;

        }
    }

    private void OnCollisionStay(Collision collision)
    {
        Destroy(this.gameObject);
        Debug.Log("Hi ana 54bt");

    }
}
   
