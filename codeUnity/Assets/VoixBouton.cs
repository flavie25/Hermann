using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 using UnityEngine.UI;

/*public class VoixBouton: MonoBehaviour, IPointerEnterHandler{

  public AudioClip sonObstacle = null;
  private AudioSource perso_AudioSource;

    public void OnPointerEnter(PointerEventData eventData)
    {
      Debug.Log("Button was selected");  //do stuff
      perso_AudioSource.PlayOneShot(sonObstacle);

    }
  }*/

  public class  VoixBouton : MonoBehaviour, IPointerEnterHandler,  ISelectHandler
  {
      private bool mouse_over = false;
      [SerializeField] private AudioClip voixOff;
      private AudioSource perso_AudioSource;


      void Awake(){
        perso_AudioSource = GetComponent<AudioSource>();
      }

      public void OnPointerEnter(PointerEventData other)
      {
          mouse_over = true;
          //Debug.Log("Mouse enter");
          perso_AudioSource.PlayOneShot(voixOff);


      }

      public void OnSelect(BaseEventData eventData)
      {
          //Debug.Log(this.gameObject.name + " was selected");
          perso_AudioSource.PlayOneShot(voixOff);
      }
  }
