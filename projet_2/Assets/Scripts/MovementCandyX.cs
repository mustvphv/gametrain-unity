using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCandyX : MonoBehaviour
{
    public int speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
