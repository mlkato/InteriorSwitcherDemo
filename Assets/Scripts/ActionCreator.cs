using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class ActionCreator : MonoBehaviour {
	
	public GameObject floorObj;
	public GameObject wallObj;

	public List<Texture> floorTextureList;
	public List<Texture> wallTextureList;

	public void ChangeFloorTextureTo (int textureType) {

		floorObj.renderer.material.mainTexture = floorTextureList [textureType];

	}

	public void ChangeWallTextureTo (int textureType) {

		wallObj.renderer.material.mainTexture = wallTextureList [textureType];

	}

}
