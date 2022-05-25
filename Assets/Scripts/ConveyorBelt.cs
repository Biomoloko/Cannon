using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    public float speed;
    public GameObject[] targets;
    public float yOffset;

    void Start()
    {
        int wholeChance = Random.Range(0,5);
        if (wholeChance == 0)
        {
            Instantiate(targets[Random.Range(0,targets.Length)], new Vector3(transform.position.x, transform.position.y + yOffset, transform.position.z), Quaternion.Euler(-90,0,0), gameObject.transform.parent = gameObject.transform);
        }
        
        
    }

    void Update()
    {
        transform.Translate(transform.right * Time.deltaTime * speed);
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "ConveyorEnd")
        {
            Destroy(gameObject, 1f);
        }
    }
}
