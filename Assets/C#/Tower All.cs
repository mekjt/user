using UnityEngine;

public class Towerall : MonoBehaviour
{
    [System.Serializable]//직렬화

    public class Tower//타워 클래스 선언
    {
        [SerializeField] public string name;//이름
        [SerializeField] public Attributre attribute;//속성
        [SerializeField] public int attackpower;//공경력
        [SerializeField] public int Time;//쿨타임
    }

    public Tower[] allTowerSetting;
    public enum Attributre//속성을 열거형으로 정리
    {
        weakening,//약화
        Fire,//불
        Light,//빛
        extinction//소멸
    }
    public enum allTowernumbers
    {
        퇴마사,무당,구마사제,영매사
    }
}
