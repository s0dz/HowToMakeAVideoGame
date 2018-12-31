using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        public float speed;
        private Rigidbody rb;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        void FixedUpdate()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            bool isJump = Input.GetKeyDown(KeyCode.Space);

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            Vector3 jump = new Vector3(0.0f, 10, 0.0f);

            rb.AddForce(movement * speed);

            if (isJump)
                rb.AddForce(jump * speed);
        }
    }
}
