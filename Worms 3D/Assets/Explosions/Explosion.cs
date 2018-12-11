using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {
    int projectileType = 2;
    // Use this for initialization
    void Start()
    {
        ParticleSystem ps = GetComponent<ParticleSystem>();
        var main = ps.main;
        if (projectileType == 1)
        {//Grenades
            main.startColor = Color.green;
            main.startSize = 1;
        }
        if (projectileType == 2)
        {//Rockets
            main.startColor = Color.blue;
            main.startSize = 0.5f;

        }

        if (projectileType == 3) { 
            //Bullets
        main.startColor = Color.magenta;
        main.startSize = 0.01f;


                                 }
    }
     
 
    // Update is called once per frame
    
}
