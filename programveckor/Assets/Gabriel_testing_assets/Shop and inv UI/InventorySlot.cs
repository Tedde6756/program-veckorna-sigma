using UnityEngine;
using UnityEngine.UI;

using JetBrains.Annotations;
public class InventorySlot : MonoBehaviour
{
    public ItemSO itemSO;
    public Image itemImage;
    
    public void UpdateUI()
    {
        if (itemSO != null)
        {
            itemImage.sprite = itemSO.icon;
            itemImage.gameObject.SetActive(true);
        }
        else
        {
            itemImage.gameObject.SetActive(false);
        }
    }
}
