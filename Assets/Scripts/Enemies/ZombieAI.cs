﻿using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{

    public GameObject ThePlayer;
    public float TargetDistance;
    public float AllowedRange = 15;
    public GameObject TheEnemy;
    public float EnemySpeed;
    public int AttackTrigger;
    public RaycastHit Shot;


    void Update()
    {
        transform.LookAt(ThePlayer.transform);
        transform.rotation *= Quaternion.FromToRotation(Vector3.left, Vector3.forward);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
            TargetDistance = Shot.distance;
            if(TargetDistance <= AllowedRange)
        {
            EnemySpeed = 0.02f;
            if(AttackTrigger == 0)
          {
                  TheEnemy.GetComponent<Animator>().Play("Base Layer.Z_Walk");
                  transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, EnemySpeed);
            }
             }
              else
               {
                 EnemySpeed = 0;
                 TheEnemy.GetComponent<Animator>().Play("Base Layer.Z_Idle");
             }
            }

             if(AttackTrigger == 1)
             {
                EnemySpeed = 0;
                TheEnemy.GetComponent<Animator>().Play("Base Layer.Z_Attack");
          }
          }

           void OnTriggerEnter()
           {
             AttackTrigger = 1;
           }

            void OnTriggerExit()
           {
             AttackTrigger = 0;
           }
    }
