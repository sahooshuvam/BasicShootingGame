using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyItself : MonoBehaviour
{
    public float time;

    

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time>3f)
        {
            Destroy(gameObject);
        }
    }
}
