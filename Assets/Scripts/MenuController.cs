using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections;

public class MenuController : MonoBehaviour {

	public void ShowMenu() {
		this.gameObject.SetActive (true);
		
	}
	public void CloseMenu() {
		this.gameObject.SetActive (false);
	}
}
