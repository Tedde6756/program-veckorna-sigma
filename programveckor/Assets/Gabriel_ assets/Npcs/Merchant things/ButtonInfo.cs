using UnityEngine;
using UnityEngine.UI;
public class ButtonInfo : MonoBehaviour
{
    public int ItemID;
    public Text PriceTxt;
    public Text QuantityTxt;
    public GameObject ShopManager;
    // Update is called once per frame
    void Start()
    {
        PriceTxt.text = "Price: coins" + ShopManager.GetComponent<ShopManagerScript>().ShopItems[2, ItemID].ToString();
        QuantityTxt.text = ShopManager.GetComponent<ShopManagerScript>().ShopItems[3, ItemID].ToString();
    }
}
