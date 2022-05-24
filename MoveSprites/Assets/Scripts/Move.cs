using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;

    [SerializeField] private float runSpeed = 10.0f;

    [SerializeField] private SpriteRenderer spriteRenderer;

    [SerializeField] private Sprite up;
    [SerializeField] private Sprite down;
    [SerializeField] private Sprite right;
    [SerializeField] private Sprite left;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.W))
        {
            spriteRenderer.sprite = up;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            spriteRenderer.sprite = down;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            spriteRenderer.sprite = right;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            spriteRenderer.sprite = left;
        }
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}
