﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCandyZ : MonoBehaviour
{
    public int speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
