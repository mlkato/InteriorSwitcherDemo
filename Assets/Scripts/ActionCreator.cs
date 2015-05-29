using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ActionCreator : MonoBehaviour {

	[SerializeField]
	public GameObject FloorGO;
	public List<GameObject> WallGOs;

	[SerializeField]
	public List<Material> floorMaterialList;

	[SerializeField]
	public List<Material> wallMaterialList;

	public enum TEXTURE_TYPE {
		TEXTURE_DEFAULT,
		TEXTURE_WALL,
		TEXTURE_CHAIR
	};

	[SerializeField]
	public void ChangeFloorTextureTo (int textureType) {

		
		FloorGO.renderer.material = floorMaterialList [textureType];			

//		switch (textureType) {
//			case TEXTURE_TYPE.TEXTURE_WALL:
//				FloorGO.renderer.material = floorMaterialList [(int) TEXTURE_TYPE.TEXTURE_WALL];
//				break;
//			case TEXTURE_TYPE.TEXTURE_CHAIR:
//				FloorGO.renderer.material = floorMaterialList [(int) TEXTURE_TYPE.TEXTURE_CHAIR];
//				break;
//			case
//			TEXTURE_TYPE.TEXTURE_DEFAULT:
//			default:
//				FloorGO.renderer.material = floorMaterialList [(int) TEXTURE_TYPE.TEXTURE_DEFAULT];
//				break;
//		}


	}

	public void ChangeWallTextureTo (int textureType) {

		WallGOs.ForEach (
			(GameObject obj) => obj.renderer.material = wallMaterialList [textureType]
		);			
		

	}
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
