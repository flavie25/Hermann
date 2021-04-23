using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioManager instance = null;
    public AudioSource m_soundStream;
    public AudioSource m_musicStream;
    void Awake(){
      if (instance == null) {
      instance = this;
      DontDestroyOnLoad (gameObject);
      } else {
      Destroy (gameObject);
      }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
