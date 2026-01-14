using UnityEngine;

public class Loot : MonoBehaviour
{
    public ItemSO itemSO;
    public SpriteRenderer sr;
    public Animator anim;
    public int quantity;

    public void OnValidate()
    {
        if (itemSO == null)
            return;
        sr.sprite =itemSO.icon;
        this.name = itemSO.itemName;

    }
}
