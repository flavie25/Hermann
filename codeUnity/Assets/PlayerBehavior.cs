using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehavior : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb2D;
    public int vie = 1;
    public string gameover = "GameOver";
    [SerializeField] private AudioClip sonObstacle = null;
    [SerializeField] private AudioClip sonMort = null;
    [SerializeField] private AudioClip sonGameOver = null;
    [SerializeField] private AudioClip sonPerdu = null;
    [SerializeField] private AudioClip sonTestReussi = null;
    [SerializeField] private AudioClip sonTestRate = null;
    private AudioSource perso_AudioSource;
    public Sprite crouchSprite = null;
    public Sprite frontSprite = null;
    public SpriteRenderer renderer = null;

    // Start is called before the first frame update
    void Awake()
    {
      perso_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      rb2D.MovePosition(rb2D.position + Time.fixedDeltaTime * speed * Vector2.right);
      /*Pour crouch
      if (Input.GetKeyDown(KeyCode.AltGr))
      {
        renderer.sprite = crouchSprite;
        Vector2 S = gameObject.GetComponent<SpriteRenderer>().sprite.bounds.size;
        gameObject.GetComponent<BoxCollider2D>().size = S;
        gameObject.GetComponent<BoxCollider2D>().offset = new Vector2 (0, S.y /2 );
      }

      if(Input.GetKeyUp(KeyCode.AltGr)){
        renderer.sprite = frontSprite;
        Vector2 S = gameObject.GetComponent<SpriteRenderer>().sprite.bounds.size;
        gameObject.GetComponent<BoxCollider2D>().size = S;
        gameObject.GetComponent<BoxCollider2D>().offset = new Vector2 (0, S.y /2 );
      }*/
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
      if (collision.gameObject.tag == "Obstacle")
      {
        vie -= 1;

        if(vie == 0)
        {
          //mouvement.enabled = false;
          speed = 0;
          Debug.Log(gameover);
          perso_AudioSource.Stop();
          perso_AudioSource.PlayOneShot(sonMort);
          StartCoroutine(LoadDelayed(1f));

          IEnumerator LoadDelayed(float tempsEnSecondes=5f)
          {
            yield return new WaitForSeconds(tempsEnSecondes);
            SceneManager.LoadScene(10);
          }

        }
      }
      if (collision.gameObject.tag == "TestObstacle")
      {
        vie -= 1;

        if(vie == 0)
        {
          //mouvement.enabled = false;
          speed = 0;
          Debug.Log(gameover);
          perso_AudioSource.Stop();
          perso_AudioSource.PlayOneShot(sonMort);
          StartCoroutine(Mort(1f));
          StartCoroutine(LoadDelayed(4f));

          IEnumerator Mort(float tempsEnSecondes=5f)
          {
            yield return new WaitForSeconds(tempsEnSecondes);
            perso_AudioSource.PlayOneShot(sonTestRate);
          }

          IEnumerator LoadDelayed(float tempsEnSecondes=5f)
          {
            yield return new WaitForSeconds(tempsEnSecondes);
            SceneManager.LoadScene(15);
          }

        }
      }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "SonPrevention")
        {
          perso_AudioSource.PlayOneShot(sonObstacle);
        }

        if (other.tag == "EndLevel1")
        {
          SceneManager.LoadScene(11);
        }

        if (other.tag == "EssaiReussi")
        {
          speed = 0;
          perso_AudioSource.Stop();
          perso_AudioSource.PlayOneShot(sonTestReussi);
          StartCoroutine(LoadDelayed(4f));

          IEnumerator LoadDelayed(float tempsEnSecondes=5f)
          {
            yield return new WaitForSeconds(tempsEnSecondes);
            SceneManager.LoadScene(12);
          }

        }

    }

    /*private void ChangeSpriteToMatchDirection()
    {
        if (m_direction == CardinalDirections.CARDINAL_S)
        {
            m_renderer.sprite = m_frontSprite;
        }
        else if (m_direction == CardinalDirections.CARDINAL_E)
        {
            m_renderer.sprite = m_rightSprite;
        }

    }*/
}
