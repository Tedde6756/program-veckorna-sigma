using UnityEngine;

[CreateAssetMenu(fileName = "New Item")]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public Sprite icon;

    public bool isGold;
    [Header("For temporary items")]
    public float duration;


}
