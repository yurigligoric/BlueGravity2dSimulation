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
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        inputNormalized = playerInput.normalized;
        rb.velocity = inputNormalized * speed;
    }



    void OnTriggerStay2D(Collider2D other)
    {
        
    }
}
