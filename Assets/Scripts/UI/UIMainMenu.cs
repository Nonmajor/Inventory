using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI idText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI goldText;
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;
    // ID, 레벨, 골드, 상태창 버튼, 인벤토리 버튼

    private void Start()
    {
        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
        // 게임 시작 시 버튼 클릭 이벤트를 각 메서드에 연결
    }

    public void SetCharacterData(Character character)
    // Character 데이터를 받아와 UI 텍스트에 표시함
    {
        idText.text = character.ID;
        levelText.text = $"Level: {character.Level}";
        goldText.text = $"Gold: {character.Gold}";
    }

    private void OpenStatus()
    // 현재 UI를 비활성화하고 상태창(UIStatus)을 활성화함
    {
        gameObject.SetActive(false);
        UIManager.Instance.UIStatus.gameObject.SetActive(true);
        UIManager.Instance.UIStatus.SetCharacterData(GameManager.Instance.Player); // 현재 스탯 UI에 업데이트
    }

    private void OpenInventory()
    // 현재 UI를 비활성화하고 인벤토리(UIInventory)를 활성화함
    {
        gameObject.SetActive(false);
        UIManager.Instance.UIInventory.gameObject.SetActive(true);
        UIManager.Instance.UIInventory.InitInventoryUI();
    }
}