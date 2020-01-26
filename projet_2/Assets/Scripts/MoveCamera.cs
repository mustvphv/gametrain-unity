using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCamera : MonoBehaviour
{
    public float speed, speed2;
    public Text textOfMainCamera;
    
    Vector3 pos;
    Quaternion rot;
    int state = 0;
    
    // Update is called once per frame
    void Update()
    {
        rot = transform.rotation;
        pos = transform.position;

        if (pos[2] <= 29.0 && state == 0){
            CameraMove(1);
        } else {
            if (state == 0) { state = 1; }
        }


        if (pos[2] >= 29.0 && state == 1 && pos[0] <= 50.0) {
            if (rot[1] <= 0.705) {
                transform.Rotate(0, speed2 * Time.deltaTime, 0);
            //  Debug.Log(rot[1]);
            } else {
                CameraMove(1);
            }
        } else {
            if (state == 1 ) { state = 2; }
        }

        if (pos[0] >= 49.0 && state == 2 && pos[2] <= 90.0) {
            if (rot[1] >= 0.00) {
            //  Debug.Log(rot[1]);
                transform.Rotate(0, -speed2 * Time.deltaTime, 0);
            } else {
                CameraMove(1);
            }
        } else {
            if (state == 2) { state = 3; }
        }

        if (pos[2] >= 90.0 && state == 3 && pos[2] <= 218.0) {
            if (rot[0] >= -0.175) {
                transform.Rotate(-speed2 * Time.deltaTime, 0, 0);
            } else {
                CameraMove(1);
            }
        } else {
            if (state == 3) { state = 4; }
        }

        if (pos[2] >= 218.0 && state == 4 && pos[2] <= 249.0) {
            if (rot[0] <= 0) {
                transform.Rotate(speed2 * Time.deltaTime, 0, 0);
            } else {
                CameraMove(1);
            }
        } else {
            if (state == 4) { state = 5; }
        }

        if (pos[2] >= 249.0 && state == 5 && pos[2] <= 378.0) {
            if (rot[0] <= 0.17) {
                transform.Rotate(speed2 * Time.deltaTime, 0, 0);
            }
            else {
                CameraMove(1);
            }
        } else
        {
            if (state == 5) { state = 6; }
        }

        if (pos[2] >= 378.0 && state == 6) {
            EndGame();
        }

        //Debug.Log( state);

        return;
    }

    void EndGame()
    {
        RotateMovementY instanceOfcounter = FindObjectOfType<RotateMovementY>();
        textOfMainCamera = GameObject.Find("TextCounter").GetComponent<Text>();
        textOfMainCamera.text = "Fin du train. Objets ramassés " + instanceOfcounter.GetCounter();
    }
     
    void CameraMove(int arg) {
        switch(arg) {
            case 1:
                transform.Translate(0, 0, speed * Time.deltaTime);
                break;
            case 2:
                transform.Translate(speed * Time.deltaTime, 0, 0);
                break;
            case 3: break;

            default: break;
        }

        return; 
    }
}
