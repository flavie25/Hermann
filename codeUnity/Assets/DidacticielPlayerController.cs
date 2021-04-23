using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DidacticielPlayerController : PhysicsObject {

    public float maxSpeed = 70;
    public float jumpTakeOffSpeed = 70;

    private SpriteRenderer spriteRenderer;
    private Animator animator;

    [SerializeField] private AudioClip sonSaut = null;
    private AudioSource perso_AudioSource;

    // Use this for initialization
    void Awake ()
    {
        spriteRenderer = GetComponent<SpriteRenderer> ();
        animator = GetComponent<Animator> ();
        perso_AudioSource = GetComponent<AudioSource>();
    }

    bool mustGoMax = false;
    bool mustGoMin= true;
    float maxPosY;
    public float jumpMax = 100f;

    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;

        move.x = Input.GetAxis ("Horizontal");

        if (Input.GetAxis("Fire1") > 0 && grounded && !mustGoMax && !mustGoMin) {
            velocity.y = jumpTakeOffSpeed;
            mustGoMax = true;
            maxPosY = this.transform.localPosition.y + jumpMax;
            perso_AudioSource.PlayOneShot(sonSaut);
        } else if (this.transform.localPosition.y > maxPosY && mustGoMax)
        {
            mustGoMin = true;
        }
        if (mustGoMin) {
            if (velocity.y > 0) {
                velocity.y = velocity.y * 0.5f;
            }

            if (grounded)
            {
                mustGoMin = false;
                mustGoMax = false;
            }
        }

        if(move.x > 0.01f)
        {
            if(spriteRenderer.flipX == true)
            {
                spriteRenderer.flipX = false;
            }
        }
        else if (move.x < -0.01f)
        {
            if(spriteRenderer.flipX == false)
            {
                spriteRenderer.flipX = true;
            }
        }

        targetVelocity = move * maxSpeed;
    }
}
