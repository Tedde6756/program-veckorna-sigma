using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ShopManagerScript : MonoBehaviour
{
    public int[,] ShopItems = new int[5, 5];
    public float coins;
    public Text CoinsTxt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CoinsTxt.text = "Coins:" + coins.ToString();
        ShopItems[1,1] = 1;
        ShopItems[2,1] = 2;
        ShopItems[3,1] = 3;

        ShopItems[2,1] = 25;
        ShopItems[2,2] = 50;
        ShopItems[2,3] = 100;

        ShopItems[3, 1] = 1;

    }
    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        if (coins >= ShopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            coins -= ShopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            ShopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]++;
            CoinsTxt.text = "Coins:" + coins.ToString();
            ButtonRef.GetComponent<ButtonInfo>().QuantityTxt.text = ShopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
