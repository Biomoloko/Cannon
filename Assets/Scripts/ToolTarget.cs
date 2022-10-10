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

    private static ScoreCanvas scoreMiniCanvas;
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
            scoreMiniCanvas = Resources.Load<GameObject>("ScoreCanvas").GetComponent<ScoreCanvas>();
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ammo")
        {
            if (gameObject.tag == "FlyingTarget")
            {
                var animator = GetComponent<Animator>();
                Destroy(animator);
            }
            ParticleSystem getNewShot = Instantiate(getShot, transform.position, transform.rotation);

            AudioManager.instance.getShot.Play();
            
            score.ScoreCounting(myCost);
            gameObject.transform.parent = null;
            
            Destroy(gameObject, timeToDestroy);

            ScoreCanvas createScoreCanvas = Instantiate(scoreMiniCanvas,
                                                       new Vector3(col.transform.position.x, col.transform.position.y + MiniCanvasOffset, col.transform.position.z),
                                                       Quaternion.identity);
            createScoreCanvas.Drawler(myCost.ToString());
            createScoreCanvas.transform.LookAt(Camera.main.transform);
            Destroy(createScoreCanvas.gameObject, timeToDestroyMinCanv);
            
            
        }
    }

    
}
