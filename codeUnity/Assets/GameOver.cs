using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*public enum CardinalDirections { CARDINAL_S, CARDINAL_N, CARDINAL_W, CARDINAL_E };*/
public class GameOver : MonoBehaviour
{

    [SerializeField] private AudioClip sonGameOver = null;
    [SerializeField] private AudioClip sonPerdu = null;
    private AudioSource perso_AudioSource;

    void Awake()
    {
      perso_AudioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
      perso_AudioSource.PlayOneShot(sonGameOver);
      StartCoroutine(Perdu(5f));
      StartCoroutine(LoadDelayed(7f));

      IEnumerator Perdu(float tempsEnSecondes=5f)
      {
        yield return new WaitForSeconds(tempsEnSecondes);
        perso_AudioSource.PlayOneShot(sonPerdu);
      }
      IEnumerator LoadDelayed(float tempsEnSecondes=5f)
      {
        yield return new WaitForSeconds(tempsEnSecondes);
        SceneManager.LoadScene(2);
      }
    }

}
