using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    Vector3 target;
    public float angle;
    public float length;
    void Update()
    {
        angle += Time.deltaTime;
        //length-= Time.deltaTime;

        target.x = (float)(length * Math.Cos(angle));
        target.y = (float)(length * Math.Sin(angle));
        target.z = 0;
        this.transform.position = target;
    }

}
