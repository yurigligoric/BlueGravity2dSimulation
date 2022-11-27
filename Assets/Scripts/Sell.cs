using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sell : MonoBehaviour
{
    // Start is called before the first frame update
    
    public TextMeshProUGUI cash;
    float amountSold;
    float amount;




    public void SellDiamonds(int a)
    {
        if(a == 1)
        {
            amount += 140f; 
            cash.text = amount.ToString("#,##0");
        } 
        else if (a == 2)
        {
            amount += 230f; 
            cash.text = amount.ToString("#,##0");
        }
        else if (a == 3)
        {
            amount += 314f; 
            cash.text = amount.ToString("#,##0");
        }
        else if (a == 4)
        {
            amount += 203f; 
            cash.text = amount.ToString("#,##0");
        }

    }
    
    
    
}
