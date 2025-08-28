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

// SO ����
// �̸�, ����, ���ݷ�, ����, ������ ����