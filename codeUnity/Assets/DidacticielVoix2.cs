using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DidacticielVoix2 : MonoBehaviour
{
    [SerializeField] private AudioClip sonDid1 = null;
    [SerializeField] private AudioClip sonDid2 = null;
    private AudioSource perso_AudioSource;

    void Awake()
    {
      perso_AudioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        perso_AudioSource.PlayOneShot(sonDid1, 0.7f);
        StartCoroutine(Didacticiel(4f));
        StartCoroutine(Continuer(10f));

        IEnumerator Didacticiel(float tempsEnSecondes=5f)
        {
          yield return new WaitForSeconds(tempsEnSecondes);
          perso_AudioSource.PlayOneShot(sonDid2);
        }

        IEnumerator Continuer(float tempsEnSecondes=5f)
        {
          yield return new WaitForSeconds(tempsEnSecondes);
          SceneManager.LoadScene(14);
        }
    }

}
