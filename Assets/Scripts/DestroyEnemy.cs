using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    ScoreManager score;
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        score.ScoreCalculator(10);
        
    }
}
