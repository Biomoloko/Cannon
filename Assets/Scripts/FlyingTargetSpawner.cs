using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingTargetSpawner : MonoBehaviour
{
    [SerializeField] GameObject flyingTargetPref;
    void Start()
    {
        Timer.OnHalfTimer.AddListener(SpawnTarget);
    }

    void Update()
    {
        
    }

    public void SpawnTarget()
    {
        var currentFlyingTarget = Instantiate(flyingTargetPref, transform.position, Quaternion.Euler(0, 90, 0));
        Destroy(currentFlyingTarget, 13f);
    }
    
}
