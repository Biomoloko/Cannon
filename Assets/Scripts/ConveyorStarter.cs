using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorStarter : MonoBehaviour
{
    public float timeForConveyorSpawn = 1f;
    public GameObject Conveyor;
    public bool conveyouCreated = false;
    void Start()
    {
        StartCoroutine(CreateAndMoveConveyor());
    }


    void Update()
    {
    }

    public IEnumerator CreateAndMoveConveyor()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeForConveyorSpawn);
            Instantiate(Conveyor, transform.position, transform.localRotation);
        }
    }
}
