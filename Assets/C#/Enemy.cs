using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;
    public Base base1;
    public Enemyall enemyall;

    void Start ()
    {
        target = waypoints.points[0];
        
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
            base1.Bhp = base1.Bhp - enemyall.allEnemySett[1].attackpower; 
            Destroy(gameObject);
        }
    }
    
}
 