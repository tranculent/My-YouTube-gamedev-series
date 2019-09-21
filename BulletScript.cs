using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] float speed;

    private Rigidbody2D rb2;

    Vector2 mousePos;

    private void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 directionToShoot = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);

        rb2.velocity = directionToShoot * speed;
    }

    private void Update()
    {
        Debug.Log(transform.position.x);
    }
}
