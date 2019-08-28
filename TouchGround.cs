using UnityEngine;
using TMPro;

/* 
* Randomize gravity value
* Change text content in our TexMeshPro object
*/

public class TouchGround : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txt1;
    
    float randomGravityValue = 0;

    private void Start()
    {
        randomGravityValue = Random.Range(0.1f, 1.5f);
        GetComponent<Rigidbody2D>().gravityScale = randomGravityValue;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Debug.Log("Collision's name: " + collision.gameObject.name);
        string helperText = collision.gameObject.name + " destroyed our human :(";
        txt1.text = helperText;
    }
}
