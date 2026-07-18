using UnityEngine;

public class Enemyall : MonoBehaviour
{
    [System.Serializable]//직렬화
    
    public class Enemy//적 클래스 선언
    {
        [SerializeField] public string name;//이름
        [SerializeField] public float speed;//이동속도
        [SerializeField] public Attributre attribute;//속성
        [SerializeField] public int attackpower;//공경력
    }
    
    public Enemy[] allEnemySett;
    public enum Attributre//속성을 열거형으로 정리
    {
        Water,//물
        Fire,//불
        Air//공기
    }
}
