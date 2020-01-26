using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderMoveZ : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 1 * Time.deltaTime);
    }
}
