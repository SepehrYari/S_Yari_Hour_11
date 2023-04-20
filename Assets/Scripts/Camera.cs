using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
   
    public float MouseSensitivity = 2f;
    float yRotation;
    float xRotation;


    bool LockCursor = true;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;


    }

    // Update is called once per frame
    void Update()
    {



        // get the mouse inputs
        float y = Input.GetAxis("Mouse X") * MouseSensitivity;// * Time.deltaTime;
        float x = Input.GetAxis("Mouse Y") * MouseSensitivity;// * Time.deltaTime;

        xRotation += x;

        // clamp the vertical rotation
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // rotate the camera
        transform.eulerAngles = new Vector3(-xRotation, transform.eulerAngles.y + y, 0);






    }
}
