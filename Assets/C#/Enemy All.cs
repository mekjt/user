using UnityEngine;

public class Enemyall : MonoBehaviour
{
    [System.Serializable]
    public class Enemy
    {
        [SerializeField] public string name;
        [SerializeField] public float speed;
        [SerializeField] public string attribute;
        [SerializeField] public int attackpower;
    }
    public Enemy[] allEnemySett;
}
