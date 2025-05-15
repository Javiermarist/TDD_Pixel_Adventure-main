using UnityEngine;

namespace NinjaFrog
{
    public class NinjaFrogMovement : MonoBehaviour
    {
        public Rigidbody2D rb;
        private bool isGrounded = false;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            rb.AddForce(10f * Vector2.right, ForceMode2D.Impulse);
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                isGrounded = true;
            }
        }
    }
}