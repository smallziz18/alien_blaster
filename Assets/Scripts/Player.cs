using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    
    {   Rigidbody2D rb = GetComponent<Rigidbody2D>();
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = rb.linearVelocity.y;
        if(Input.GetButtonDown("Fire1"))
            vertical = 5;
        rb.linearVelocity = new Vector2(horizontal, vertical);
    }
    
}
