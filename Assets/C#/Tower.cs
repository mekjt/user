using Unity.VisualScripting;
using UnityEngine;


public class Tower : MonoBehaviour
{
    int Ehp;
    Enemy enemytrigger;
    public Towerall towerall;
    public Towerall.allTowernumbers allTowernumbers;
    public int Towerattack;

    void Start()
    {
        Towerattack = towerall.allTowerSetting[(int)allTowernumbers].attackpower;
    }

    void OnTriggerEnter(Collider other)
    {
        enemytrigger = other.GetComponent<Enemy>();

        if (enemytrigger != null)
        {
            enemytrigger.EnemyHp = enemytrigger.EnemyHp - Towerattack;
        }
    }
}