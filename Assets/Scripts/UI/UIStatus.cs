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

    // ID, 레벨, 공격력, 방어력, 메인메뉴 버튼

    private void Start()
    // 게임 시작 시, 뒤로 가기 버튼에 클릭 이벤트 리스너를 추가함

    {
        backButton.onClick.AddListener(OpenMainMenu);
    }

    public void SetCharacterData(Character character)
    // Character 데이터를 받아와 상태창 UI의 텍스트들을 업데이트함

    {
        idText.text = character.ID;
        levelText.text = $"Level: {character.Level}";
        attackText.text = $"Attack: {character.AttackPower}";
        defenseText.text = $"Defense: {character.DefensePower}";
    }

    private void OpenMainMenu()
    // 현재 상태창 UI를 비활성화하고 메인 메뉴 UI를 활성화하여 화면을 전환함

    {
        gameObject.SetActive(false);
        UIManager.Instance.UIMainMenu.gameObject.SetActive(true);
    }
}