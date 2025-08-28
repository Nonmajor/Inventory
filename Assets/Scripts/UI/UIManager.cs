using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }
    // �̱��� (���� �ν��Ͻ�)
    // UIManager.Instance�� �ܺο��� ���� ����

    [SerializeField] private UIMainMenu uiMainMenu;
    [SerializeField] private UIStatus uiStatus;
    [SerializeField] private UIInventory uiInventory;

    // ���θ޴�, ����â, �κ��丮 ĵ����

    public UIMainMenu UIMainMenu => uiMainMenu;
    public UIStatus UIStatus => uiStatus;
    public UIInventory UIInventory => uiInventory;

    // �ٸ� ��ũ��Ʈ���� private �ʵ忡 ������ �� �ֵ��� public ������Ƽ�� ����

    private void Awake()
    // �̱��� �ʱ�ȭ

    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
}