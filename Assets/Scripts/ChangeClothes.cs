
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeClothes : MonoBehaviour
{
  
    
    public GameObject body;
    public GameObject armL;
    public GameObject armR;
    public Sprite orangeT;
    public Sprite pinkT;
    public Sprite blueT;
    public Sprite yellowT;
    public Sprite defaultGreen;
    public Sprite orangeArm;
    public Sprite pinkArm;
    public Sprite blueArm;
    public Sprite yellowArm;
    public Sprite defaultArmGreen;
    SpriteRenderer playerShirt;
    SpriteRenderer playerLeftArm;
    SpriteRenderer playerRightArm;
    public TextMeshProUGUI cash;
    float amount;

    
    // Start is called before the first frame update
    void Start()
    {
        
        playerShirt = body.GetComponent<SpriteRenderer>();
        playerLeftArm = armL.GetComponent<SpriteRenderer>();
        playerRightArm = armR.GetComponent<SpriteRenderer>();
        
        
    }

      

    public void ChangeShirt(int a)
    {
        amount = float.Parse(cash.text);
        if(a == 1)
        {   
            if (float.Parse(cash.text) < 11f)
            {
                CanvasLoader.ShowWarningUI();
                return;     
            }
            amount -= 11f; 
            cash.text = amount.ToString("#,##0");
            playerShirt.sprite = orangeT;
            playerLeftArm.sprite = orangeArm; 
            playerRightArm.sprite = orangeArm;
        }
        else if (a == 2)
        {
            if (float.Parse(cash.text) < 12f)
            {
                CanvasLoader.ShowWarningUI();
                return;     
            }
            amount -= 12f; 
            cash.text = amount.ToString("#,##0");
            playerShirt.sprite = pinkT;
            playerLeftArm.sprite = pinkArm; 
            playerRightArm.sprite = pinkArm;
            
        }
        else if (a == 3)
        {
            if (float.Parse(cash.text) < 12f)
            {
                CanvasLoader.ShowWarningUI();
                return;     
            }
            amount -= 12f; 
            cash.text = amount.ToString("#,##0");
            playerShirt.sprite = blueT;
            playerLeftArm.sprite = blueArm; 
            playerRightArm.sprite = blueArm;
            
        }
        else if (a == 4)
        {
            if (float.Parse(cash.text) < 13f)
            {
                CanvasLoader.ShowWarningUI();
                return;
            }
            
            amount -= 13f; 
            cash.text = amount.ToString("#,##0");
            playerShirt.sprite = yellowT;
            playerLeftArm.sprite = yellowArm; 
            playerRightArm.sprite = yellowArm;
            
        }
        else
        {
            if (float.Parse(cash.text) < 9f)
            {
                CanvasLoader.ShowWarningUI();
                return;
            }
            amount -= 9f; 
            cash.text = amount.ToString("#,##0");
            playerShirt.sprite = defaultGreen;
            playerLeftArm.sprite = defaultArmGreen; 
            playerRightArm.sprite = defaultArmGreen;
        }


    }
}
