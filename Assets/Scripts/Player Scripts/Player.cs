using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    float JumpHeight = 7f;
    bool isGrounded;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float BaseSpeed = 5f;
        float sprint = 2.0f;
        float speed;
        float HorizontalInput = Input.GetAxis("Horizontal");
        
        if (Input.GetKey(KeyCode.LeftShift) && isGrounded)
        {
            speed = BaseSpeed * sprint;
        } 
        else
        {
            speed = BaseSpeed;
        }

        transform.Translate(new Vector2(HorizontalInput, 0) * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
        {
            if (isGrounded) 
            {
                rb.AddForce(new Vector2(0, JumpHeight), ForceMode2D.Impulse);
            }
        }
    }

    void OnCollisionEnter2D (Collision2D other) 
    {
        if (other.gameObject.tag == "Ground")
        {
            foreach(ContactPoint2D hitPos in other.contacts)
            {
                Debug.Log(hitPos.normal);
                if (hitPos.normal.y == 1) {
                    isGrounded = true;
                }
            }
        }
        else if (other.gameObject.tag == "Enemy")
        {
            foreach(ContactPoint2D hitPos in other.contacts)
            {
                Debug.Log(hitPos.normal);
                if (hitPos.normal.y > 0)
                {
                    Destroy(other.gameObject);
                }
            }
        }
    }

    void OnCollisionExit2D (Collision2D other)
    {
        if (other.gameObject.tag == "Ground") {
            isGrounded = false;
        }
    }
}
