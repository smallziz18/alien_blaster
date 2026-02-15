using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D rb;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {   rb = GetComponent<Rigidbody2D>();
        var horizontal = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(horizontal, rb.linearVelocity.y);
    }
}
