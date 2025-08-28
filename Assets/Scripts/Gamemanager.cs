using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public Character Player { get; private set; }

    [SerializeField] private ItemData swordData;
    [SerializeField] private ItemData shieldData;
    [SerializeField] private ItemData armorData;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        SetData();
    }

    public void SetData()
    {
        Player = new Character("Player", 1, 100);

        // SO ���Ͽ��� ������ ������ �ε�
        Player.AddItem(swordData);
        Player.AddItem(shieldData);
        Player.AddItem(armorData);

        UIManager.Instance.UIMainMenu.SetCharacterData(Player);
    }
}