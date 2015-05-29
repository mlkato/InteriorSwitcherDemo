using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections;

public class MenuController : MonoBehaviour {

	public void ShowMenu() {
		this.gameObject.transform.localPosition = new Vector3 (0.0f, 0.0f, 0.0f);
		
	}
	public void CloseMenu() {
		this.gameObject.transform.localPosition = new Vector3 (1136.0f, 0.0f, 0.0f);
	}
}
