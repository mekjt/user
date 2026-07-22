using UnityEngine;

public class Tower : MonoBehaviour
{
    int Ehp;
    Enemy enemytrigger;
    public Towerall towerall;
    public Towerall.allTowernumbers allTowernumbers;

    void OnTriggerEnter(Collider other)
    {
        if(enemytrigger = other.GetComponent<Enemy>())
        {
            Debug.Log("경고!!!!");
        }

    }
}