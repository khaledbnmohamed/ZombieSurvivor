using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringSystem : MonoBehaviour {

    public GUIText ScoringScreen;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (EnemyDeath.life == 0)
        {
          //  ScoringScreen = 1

        }
	}
}
