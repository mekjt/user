using System;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private float speed;
    private int EnemyHp;
    private Transform target;
    private int wavepointIndex = 0;
    public Base base1;
    public Enemyall enemyall;
    public Enemyall.allEnemtnumbers enemtnumbers;

    void Start ()
    {
        target = waypoints.points[0];
        speed = enemyall.allEnemySetting[(int)enemtnumbers].speed;
        EnemyHp = enemyall.allEnemySetting[(int)enemtnumbers].Ehp;
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if(Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
    }


    void GetNextWaypoint()
    {
        wavepointIndex++;
        target = waypoints.points[wavepointIndex];
        if (wavepointIndex >= waypoints.points.Length - 1) 
        {
            base1.Bhp = base1.Bhp - enemyall.allEnemySetting[(int)enemtnumbers].attackpower; 
            Destroy(gameObject);
        }
    }
    
}
 