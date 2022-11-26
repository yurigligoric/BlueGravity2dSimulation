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



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
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
            }
        }
    }

void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Store")
        {
            CanvasLoader.CloseStoreInventory();
        }
    }
    
}
