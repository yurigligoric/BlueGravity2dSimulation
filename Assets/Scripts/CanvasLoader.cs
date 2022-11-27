using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasLoader : MonoBehaviour
{
    
    public static GameObject storeInventory;
    public static GameObject storeSell;

    void Start()
    {
        storeInventory = GameObject.FindGameObjectWithTag("StoreUI");
        if(storeInventory != null)
        {
            storeInventory.SetActive(false);
        }

        storeSell = GameObject.FindGameObjectWithTag("SellUI");
        if(storeSell != null)
        {
            storeSell.SetActive(false);
        }

    }

    public static void ShowStoreInventory()
    {
        storeInventory.SetActive(true);
    }

    public static void CloseStoreInventory()
    {
        storeInventory.SetActive(false);
    }

    public static void ShowSellUI()
    {
        storeSell.SetActive(true);
    }

    public static void CloseSellUI()
    {
        storeSell.SetActive(false);
    }

}
