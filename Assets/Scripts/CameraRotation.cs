using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
       
          
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
       transform.rotation = transform.rotation * Quaternion.Euler(-mouseY * rotationSpeed, mouseX * rotationSpeed, 0);
       
        
    }
}
