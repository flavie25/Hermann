using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour, ISelectHandler // required interface for OnSelect
{
 //Do this when the selectable UI object is selected.
 public void OnSelect(BaseEventData eventData)
 {
     Debug.Log(this.gameObject.name + " was selected");
 }
}
