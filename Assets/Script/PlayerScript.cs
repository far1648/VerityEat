using UnityEngine;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D Rb;
    bool grounded = false;
    public float speed = 0;
    public float jumpForce = 0;
    public Spawner spawner;
    GameObject platform;
    GameObject otak;
    int score;
    public TextMeshProUGUI scoreText;
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (grounded) {
            if (Input.GetButtonDown("Jump"))
            {
                Jump();
            }
        }
        scoreText.text = "Score: " + score;
    }

    void FixedUpdate()
    {
        grounded = Physics2D.CircleCast(transform.position, 0.2f, Vector2.down, 0.05f);
        Move(Input.GetAxisRaw("Horizontal"));
    }

    void Jump()
    {
        Rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    void Move(float walkInput)
    {
        Rb.linearVelocity = new Vector2(walkInput * speed, Rb.linearVelocityY);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Otak")
        {
            score++;
            platform = GameObject.Find("5 Platform(Clone)");
            otak = GameObject.Find("Otak(Clone)");
            Destroy(platform);
            Destroy(otak);
            spawner.SpawnPlatform();
            spawner.SpawnBrain(); 
        }
    }
}