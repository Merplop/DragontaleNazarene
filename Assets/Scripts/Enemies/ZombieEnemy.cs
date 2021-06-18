using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class ZombieEnemy : MonoBehaviour
{
    private Animator anim;
    public int EnemyHealth = 20;
    public GameObject TheEnemy;
    //public Transform parent;
    public int EnemyStatus;

    void DeductPoints (int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    } 

    void Update()
    {
        if(EnemyHealth <= 0)
        {
            if (EnemyStatus == 0)
            {
                    StartCoroutine(DeathEnemy());
            }
        }
    }

    IEnumerator DeathEnemy()
    {
        EnemyStatus = 6;
        yield return new WaitForSeconds(0.5f);
        TheEnemy.GetComponent<Animation>().Play("die");
        yield return new WaitForSeconds(1.6f);
        TheEnemy.transform.SetParent(null);
        Destroy(gameObject);
    }
}
