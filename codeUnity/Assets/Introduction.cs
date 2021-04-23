using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Introduction : MonoBehaviour
{
    [SerializeField] private AudioClip sonIntroduction = null;
    private AudioSource perso_AudioSource;

    void Awake()
    {
      perso_AudioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        perso_AudioSource.PlayOneShot(sonIntroduction, 0.7f);
        StartCoroutine(Continuer(35f));

        IEnumerator Continuer(float tempsEnSecondes=5f)
        {
          yield return new WaitForSeconds(tempsEnSecondes);
          SceneManager.LoadScene(9);
        }
    }
}
