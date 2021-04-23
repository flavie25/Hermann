using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinCompteARebour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadDelayed(3f));
        IEnumerator LoadDelayed(float tempsEnSecondes=5f)
        {
          yield return new WaitForSeconds(tempsEnSecondes);
          SceneManager.LoadScene(1);

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
