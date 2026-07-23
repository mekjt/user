using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class TowerPlacement : MonoBehaviour
{
    private Camera mainCamera;
    private RaycastHit Hit;

    private void Awake()
    {
        mainCamera = Camera.main;
        mainCamera.ScreenPointToRay(Input.mousePosition);
    }

    void Update()
    {

        // 마우스 좌클릭이 처음 들어온 순간 (GetMouseButtonDown과 같음)
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.Log("마우스 클릭됨!");
            
            Vector2 mousePos = Mouse.current.position.ReadValue();
            Debug.Log($"마우스 좌표: {mousePos}");
        }
    }
} 

