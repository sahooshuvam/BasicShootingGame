using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    [SerializeField]
    private static  int score;
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        score = score + 10;
        Debug.Log("Score: " +score);
    }
}
