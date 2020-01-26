using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateMovementY : MonoBehaviour
{
    public GameObject objet;
    public static int counter = 0;
    public  Text textOfMainCamera;

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(0, 50 * Time.deltaTime, 0);
        
    }

    public void DisappearObject(string name)
    {
        Debug.Log(counter);

        objet = GameObject.Find(name);             

        objet.SetActive(false);
        counter++;
        IncrementTextCounter();
        return;
    }

    public int GetCounter()
    {
        return counter;
    }

    public void IncrementTextCounter()
    {
        textOfMainCamera = GameObject.Find("TextCounter").GetComponent<Text>();
        textOfMainCamera.text = "Objets ramassés : " + counter.ToString();
        return;
    }
}
