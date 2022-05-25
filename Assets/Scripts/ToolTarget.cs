using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ToolTarget : MonoBehaviour
{
    public int myCost;
    public float timeToDestroy = 2f;
    public ParticleSystem getShot;
    public static Score score;

    private void Awake()
    {
        if(score == null)
        {
            score = FindObjectOfType<Score>();
        }
        
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ammo")
        {
            ParticleSystem getNewShot = Instantiate(getShot, transform.position, transform.rotation);
            score.ScoreCounting(myCost);
            gameObject.transform.parent = null;
            Destroy(gameObject, timeToDestroy);
            Debug.Log(score.currentScore);
        }
    }

    
}
