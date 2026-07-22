using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class towerplacement: MonoBehaviour
{
public class TowerPlacement : MonoBehaviour
{
    private Camera mainCamera;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
     if (Mouse.current == null) return;

        if (Mouse.current.leftButton.wasPressedThisFrame || Mouse.current.rightButton.wasPressedThisFrame)//마우스 좌측 또는 우측이 이번 프레임에 눌렸음
        {
            Vector3 mousePosition = Mouse.current.position.ReadValue();
            Ray ray = mainCamera.ScreenPointToRay(mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.transform == this.transform)
                {
                    Debug.Log("뉴 인풋 시스템 레이캐스트로 클릭 감지!");
                }
            }
        }
    }
}

}
