using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] 
    float speed = 5f;
    private Rigidbody2D rb;
    Vector2 playerInput;
    Vector2 inputNormalized;
    Animator animator;
    GameObject storeInventoryUI;
    bool facingRight = true;

    private SpriteRenderer body;
    private SpriteRenderer head;
    public GameObject _head;
    public GameObject _body;
    public Sprite backHead;
    public Sprite pinkBack;   
    public Sprite orangeBack;   
    public Sprite blueBack;   
    public Sprite yellowBack;   
    public Sprite bodyBack;

    public Sprite bodyPink;   
    public Sprite bodyOrange;   
    public Sprite bodyBlue;   
    public Sprite bodyYellow;   
    public Sprite bodyDefault;
    public Sprite headFacing;   
    bool walkedUp = false;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        body = _body.GetComponent<SpriteRenderer>();
        head = _head.GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        playerInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        inputNormalized = playerInput.normalized;
        rb.velocity = inputNormalized * speed;

        
        
        if(rb.velocity.magnitude > 0)
        {
            animator.SetTrigger("Walk");
        } 
        else
        {
            animator.SetTrigger("Idle");
        }
        
        if (playerInput.x != 0 && !facingRight)
        {
            FlipCharacter();
        }
        if (playerInput.x == 0f  && facingRight)
        {
            FlipCharacter();
        }

        if( !walkedUp && playerInput.y > 0)
        {
            head.sprite = backHead;
            walkedUp = true;

            if(body.sprite.name == "bodyPink")
            {
                body.sprite = pinkBack;
            }
            if(body.sprite.name == "bodyBlue")
            {
                body.sprite = blueBack;
            }
            if(body.sprite.name == "bodyOrange")
            {
                body.sprite = orangeBack;
            }
            if(body.sprite.name == "bodyYellow")
            {
                body.sprite = yellowBack;
            }
            if(body.sprite.name == "body")
            {
                body.sprite = bodyBack;
            }
        }
        
        if(walkedUp && playerInput.y <= 0) 
        {
        
            head.sprite = headFacing;     
            
            if(body.sprite.name == "pinkBack")
            {
                body.sprite = bodyPink;
            }
            if(body.sprite.name == "blueBack")
            {
                body.sprite = bodyBlue;
            }
            if(body.sprite.name == "orangeBack")
            {
                body.sprite = bodyOrange;
            }
            if(body.sprite.name == "yellowBack")
            {
                body.sprite = bodyYellow;
            }
            if(body.sprite.name == "bodyBack")
            {
                body.sprite = bodyDefault;
            }
            walkedUp = false;
        }

    }

    void FlipCharacter()
    {
        Vector3 presentScale = transform.localScale;
        presentScale.x *= -1;
        transform.localScale = presentScale;

        facingRight = !facingRight; 
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "Store")
        {
            if(Input.GetKey(KeyCode.F))
            {
                CanvasLoader.ShowStoreInventory();
                CanvasLoader.CloseSellUI();
            }

            if(Input.GetKey(KeyCode.G))
            {
                CanvasLoader.ShowSellUI();
                CanvasLoader.CloseStoreInventory();
            }
        }
    }

void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Store")
        {
            CanvasLoader.CloseStoreInventory();
            CanvasLoader.CloseSellUI();
        }
    }
    
}
