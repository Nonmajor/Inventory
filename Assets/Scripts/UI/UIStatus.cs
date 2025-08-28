using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI idText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI attackText;
    [SerializeField] private TextMeshProUGUI defenseText;
    [SerializeField] private Button backButton;

    // ID, ����, ���ݷ�, ����, ���θ޴� ��ư

    private void Start()
    // ���� ���� ��, �ڷ� ���� ��ư�� Ŭ�� �̺�Ʈ �����ʸ� �߰���

    {
        backButton.onClick.AddListener(OpenMainMenu);
    }

    public void SetCharacterData(Character character)
    // Character �����͸� �޾ƿ� ����â UI�� �ؽ�Ʈ���� ������Ʈ��

    {
        idText.text = character.ID;
        levelText.text = $"Level: {character.Level}";
        attackText.text = $"Attack: {character.AttackPower}";
        defenseText.text = $"Defense: {character.DefensePower}";
    }

    private void OpenMainMenu()
    // ���� ����â UI�� ��Ȱ��ȭ�ϰ� ���� �޴� UI�� Ȱ��ȭ�Ͽ� ȭ���� ��ȯ��

    {
        gameObject.SetActive(false);
        UIManager.Instance.UIMainMenu.gameObject.SetActive(true);
    }
}