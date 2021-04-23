using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*public enum CardinalDirections { CARDINAL_S, CARDINAL_N, CARDINAL_W, CARDINAL_E };*/
public class Victoire : MonoBehaviour
{

    [SerializeField] private AudioClip sonVictoire = null;
    [SerializeField] private AudioClip sonGagne = null;
    private AudioSource perso_AudioSource;

    void Awake()
    {
      perso_AudioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
      perso_AudioSource.PlayOneShot(sonVictoire);
      StartCoroutine(Perdu(1f));
      StartCoroutine(LoadDelayed(4f));

      IEnumerator Perdu(float tempsEnSecondes=5f)
      {
        yield return new WaitForSeconds(tempsEnSecondes);
        perso_AudioSource.PlayOneShot(sonGagne);
      }
      IEnumerator LoadDelayed(float tempsEnSecondes=5f)
      {
        yield return new WaitForSeconds(tempsEnSecondes);
        SceneManager.LoadScene(0);
      }
    }

}
