using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "ScriptableObjects/Item Data")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public string itemType;
    public int attackBonus;
    public int defenseBonus;
    public Sprite icon;
}

// SO 파일
// 이름, 종류, 공격력, 방어력, 아이콘 포함