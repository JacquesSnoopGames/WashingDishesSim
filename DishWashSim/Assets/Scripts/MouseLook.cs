using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    public Transform playerRigthArm;

    float xRotation = 0f;
    float yRotation = 0f;

    public Vector2 turn;
    public Vector3 deltaMove;

    public float speed = 1f;

    public bool controlRightArm = false;

    // Start is called before the first frame update
    void Start()
    {
        controlRightArm = true;
        Cursor.visible = false;
        //playerRightArm.transform.eulerAngles = new Vector3(0f,0f,0f);   
    
    }

    // Update is called once per frame
    void Update()
    {
        if(controlRightArm == true)
        {
                turn.x += Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
                turn.y = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
                xRotation -= turn.y;
        
                playerRigthArm.transform.localRotation = Quaternion.Euler(xRotation, turn.x, 0);
                
                //playerRigthArm.transform.localPosition = new Vector3(xRotation, turn.x, turn.y);
        }

        
        /*if(controlLeftArm == true)
        {

        }*/
        
        
    
    }
}
