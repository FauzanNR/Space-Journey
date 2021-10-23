using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    public Transform player;
    private static float speed = 90f;
    private float rotate = 0;
    bool cursormod;
    void Start()
    {   
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
     {
        float x = Input.GetAxis("Mouse X") * speed * Time.deltaTime;
        float y = Input.GetAxis("Mouse Y") * speed * Time.deltaTime;

        rotate -= y;

        rotate = Mathf.Clamp(rotate, -10f, 10f);
        transform.localRotation = Quaternion.Euler(rotate, 0f, 0f);

        if(Input.GetAxis("Horizontal") < 0) {
            print("left");
            transform.Rotate(Vector3.up * x);
        }

        if(Input.GetMouseButton(0)) {
            print("mouse button");
            player.Rotate(Vector3.up * x);
            //position = new Vector3(speed * Input.mousePosition.x * Time.deltaTime, 0, speed * Input.mousePosition.z * Time.deltaTime);
        } 
    }
}
