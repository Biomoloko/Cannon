using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class ToolTarget : MonoBehaviour
{
    public int myCost;
    public float timeToDestroy = 2f;
    public ParticleSystem getShot;
    public static Score score;
    [SerializeField] private float timeToDestroyMinCanv;

    private static GameObject scoreMiniCanvas;
    private float MiniCanvasOffset = 2f;

    private void Awake()
    {
        if(score == null)
        {
            score = FindObjectOfType<Score>();
        }

        //проверить
        if(scoreMiniCanvas == null)
        {
            scoreMiniCanvas = Resources.Load("ScoreCanvas") as GameObject;
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ammo")
        {
            ParticleSystem getNewShot = Instantiate(getShot, transform.position, transform.rotation);

            score.ScoreCounting(myCost);
            gameObject.transform.parent = null;
            Destroy(gameObject, timeToDestroy);

            GameObject createScoreCanvas = Instantiate(scoreMiniCanvas,
                                                       new Vector3(col.transform.position.x, col.transform.position.y + MiniCanvasOffset, col.transform.position.z),
                                                       Quaternion.identity);
            
            createScoreCanvas.transform.LookAt(Camera.main.transform);
            Destroy(createScoreCanvas, timeToDestroyMinCanv);

            
        }
    }

    
}
