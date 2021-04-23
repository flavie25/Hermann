// The sprite will fall under its weight.  After a short time the
// sprite will start its upwards travel due to the thrust force that
// is added in the opposite direction.

using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
    public Texture2D tex;

    private Rigidbody2D rb2D;
    private Sprite mySprite;
    private SpriteRenderer sr;
    private float thrust = 1f;
    public int JumpPower = 0;

    void Awake()
    {
        sr = gameObject.AddComponent<SpriteRenderer>();
        rb2D = gameObject.AddComponent<Rigidbody2D>();
    }

    void Start()
    {
        mySprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, 128.0f, 128.0f), new Vector2(0.5f, 0.5f), 100.0f);

        sr.color = new Color(0.9f, 0.9f, 0.5f, 1.0f);
        sr.sprite = mySprite;
        transform.position = new Vector3(0.0f, -2.0f, 0.0f);
    }

    void FixedUpdate()
    {
        rb2D.AddForce(transform.up * thrust);
        // Alternatively, specify the force mode, which is ForceMode2D.Force by default
        rb2D.AddForce(transform.up * thrust, ForceMode2D.Impulse);

        this.GetComponent<Rigidbody2D>().AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);
    }
}