using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DidactcielFin : MonoBehaviour
{
    [SerializeField] private AudioClip sonDidFin = null;
    private AudioSource perso_AudioSource;

    void Awake()
    {
      perso_AudioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        perso_AudioSource.PlayOneShot(sonDidFin, 0.7f);
        StartCoroutine(Continuer(9f));

        IEnumerator Continuer(float tempsEnSecondes=5f)
        {
          yield return new WaitForSeconds(tempsEnSecondes);
          SceneManager.LoadScene(13);
        }
    }

}
