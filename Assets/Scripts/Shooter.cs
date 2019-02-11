using System;
using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject projectile, gun;
    private AttackerSpawner _myLaneSpawner;
    private Animator _animator;


    private void Start()
    {
        SetLaneSpawner();
        _animator = GetComponent<Animator>();
    }


    private void Update()
    {
        _animator.SetBool("IsAttacking", IsAttackerInLane());
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