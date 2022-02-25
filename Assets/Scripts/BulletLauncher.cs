using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLauncher : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float speed;
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject tempBullet;
            tempBullet = Instantiate(bulletPrefab,transform.position,Quaternion.identity);//quaternion.identity means no rotations
            Camera camera = GetComponentInChildren<Camera>();
            tempBullet.GetComponent<Rigidbody>().velocity =camera.transform.rotation * Vector3.forward * speed;
        }
    }
}
