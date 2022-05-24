using UnityEngine;

public class CollisionPlayer : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;

    private float timer = 0.0f;

    private bool damaged = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            damaged = true;
        }
    }

    private void Update()
    {
        Blink();
    }

    private void Blink()
    {
        if (damaged)
        {
            if (timer < 5)
            {
                if ((int)timer % 2==0)
                {
                    spriteRenderer.color = Color.red;
                    Debug.Log(timer);
                }
                else
                {
                    spriteRenderer.color = Color.white;
                }
                timer += Time.deltaTime;
            }
            else
            {
                damaged = false;
                spriteRenderer.color = Color.white;
                Debug.Log(timer + "Sali");
                timer = 0;
            }
        }
    }
}
