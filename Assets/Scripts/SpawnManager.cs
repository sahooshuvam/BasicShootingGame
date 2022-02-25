using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float time;
  
    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time >= 3f)
        {
            float x = Random.Range(Random.Range(-5f,-15f), Random.Range(5f, 15f));
            float y = Random.Range(1f, 4f);
            float z = Random.Range(Random.Range(-5f, -15f), Random.Range(5f, 15f));
            Instantiate(enemyPrefab, new Vector3(x, y, z), Quaternion.identity);
            time = 0f;
        }
    }
}
