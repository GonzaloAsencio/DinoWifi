using UnityEngine;

public class Dino : MonoBehaviour
{
    public float upForce;
    public Transform groundCheck;
    public LayerMask groundMask;
    public float radius;

    private Rigidbody2D dinoRb2d;

    
    void Start()
    {
        dinoRb2d = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        bool isGrounded = Physics2D.OverlapCircle(groundCheck.position, radius, groundMask);
        if (Input.GetKeyDown(KeyCode.Space))
            dinoRb2d.AddForce(Vector2.up * upForce);
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(groundCheck.position, radius);
    }
}
