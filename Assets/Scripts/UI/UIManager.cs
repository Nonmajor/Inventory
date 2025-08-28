using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }
    // 싱글톤 (정적 인스턴스)
    // UIManager.Instance로 외부에서 접근 가능

    [SerializeField] private UIMainMenu uiMainMenu;
    [SerializeField] private UIStatus uiStatus;
    [SerializeField] private UIInventory uiInventory;

    // 메인메뉴, 상태창, 인벤토리 캔버스

    public UIMainMenu UIMainMenu => uiMainMenu;
    public UIStatus UIStatus => uiStatus;
    public UIInventory UIInventory => uiInventory;

    // 다른 스크립트에서 private 필드에 접근할 수 있도록 public 프로퍼티를 제공

    private void Awake()
    // 싱글톤 초기화

    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
}