using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasLoader : MonoBehaviour
{
    
    public static GameObject storeInventory;

    void Start()
    {
        storeInventory = GameObject.FindGameObjectWithTag("StoreUI");
        if(storeInventory != null)
        {
            storeInventory.SetActive(false);
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

}
