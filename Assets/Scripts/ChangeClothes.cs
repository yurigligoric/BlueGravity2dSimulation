using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    
    // Start is called before the first frame update
    void Start()
    {
        
        playerShirt = body.GetComponent<SpriteRenderer>();
        playerLeftArm = armL.GetComponent<SpriteRenderer>();
        playerRightArm = armR.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeShirt(int a)
    {
        if(a == 1)
        {        
            playerShirt.sprite = orangeT;
            playerLeftArm.sprite = orangeArm; 
            playerRightArm.sprite = orangeArm;
            
        }
        else if (a == 2)
        {
            playerShirt.sprite = pinkT;
            playerLeftArm.sprite = pinkArm; 
            playerRightArm.sprite = pinkArm;
            
        }
        else if (a == 3)
        {
            playerShirt.sprite = blueT;
            playerLeftArm.sprite = blueArm; 
            playerRightArm.sprite = blueArm;
            
        }
        else if (a == 4)
        {
            playerShirt.sprite = yellowT;
            playerLeftArm.sprite = yellowArm; 
            playerRightArm.sprite = yellowArm;
            
        }
        else
        {
            playerShirt.sprite = defaultGreen;
            playerLeftArm.sprite = defaultArmGreen; 
            playerRightArm.sprite = defaultArmGreen;
        }


    }
}
