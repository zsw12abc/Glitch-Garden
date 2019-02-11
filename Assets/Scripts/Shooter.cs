using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject projectile, gun;
    private AttackerSpawner _myLaneSpawner;


    private void Start()
    {
        SetLaneSpawner();
    }


    private void Update()
    {
        if (IsAttackerInLane())
        {
            //TODO change animation state to shooting
            Debug.Log("Shooting");
        }
        else
        {
            //TODO change animation state to idle
            Debug.Log("IDLE");
        }
    }

    private void SetLaneSpawner()
    {
        var spawners = FindObjectsOfType<AttackerSpawner>();
        foreach (var spawner in spawners)
        {
            var isCloseEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);
            if (isCloseEnough)
            {
                _myLaneSpawner = spawner;
            }
        }
    }


    private bool IsAttackerInLane()
    {
        return _myLaneSpawner.transform.childCount > 0;
    }

    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, gun.transform.rotation);
    }
}