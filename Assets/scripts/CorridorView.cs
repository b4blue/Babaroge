using strange.extensions.mediation.impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorView : View {

    private float speedZ = 0.0f;
    private float switchZ = 400.0f;


    void FixedUpdate () {

        speedZ = -300 * Time.deltaTime;

        gameObject.transform.position += new Vector3(0.0f, 0.0f, speedZ);
       

        if(gameObject.transform.position.z < switchZ)
        {
            Debug.Log(gameObject.transform.position.z);
            float diff = switchZ - gameObject.transform.position.z;
            float newpos = gameObject.transform.position.z;
            newpos += diff;
            newpos += 1500.0f;
            gameObject.transform.position = new Vector3(0.0f, 0.0f, newpos);
        }
    }
}
