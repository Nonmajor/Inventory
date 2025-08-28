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
    // ID, ����, ���, ����â ��ư, �κ��丮 ��ư

    private void Start()
    {
        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
        // ���� ���� �� ��ư Ŭ�� �̺�Ʈ�� �� �޼��忡 ����
    }

    public void SetCharacterData(Character character)
    // Character �����͸� �޾ƿ� UI �ؽ�Ʈ�� ǥ����
    {
        idText.text = character.ID;
        levelText.text = $"Level: {character.Level}";
        goldText.text = $"Gold: {character.Gold}";
    }

    private void OpenStatus()
    // ���� UI�� ��Ȱ��ȭ�ϰ� ����â(UIStatus)�� Ȱ��ȭ��
    {
        gameObject.SetActive(false);
        UIManager.Instance.UIStatus.gameObject.SetActive(true);
        UIManager.Instance.UIStatus.SetCharacterData(GameManager.Instance.Player); // ���� ���� UI�� ������Ʈ
    }

    private void OpenInventory()
    // ���� UI�� ��Ȱ��ȭ�ϰ� �κ��丮(UIInventory)�� Ȱ��ȭ��
    {
        gameObject.SetActive(false);
        UIManager.Instance.UIInventory.gameObject.SetActive(true);
        UIManager.Instance.UIInventory.InitInventoryUI();
    }
}