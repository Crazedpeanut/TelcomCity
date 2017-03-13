using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridItem : MonoBehaviour {

	public int X;
	public int Y;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseOver(){
		Debug.Log ("On Mouse Over");
		ShowMarker ();
	}

	public void ShowMarker() {
		Debug.Log ("show Marker");
	}

	public Vector3 GetCentre(){
		Vector3 size = transform.lossyScale;
		Vector3 pos = transform.position;

		Vector3 halfSize = new Vector3 (size.x / 2, size.y / 2, size.z / 2);

		return new Vector3 (pos.x + halfSize.x, pos.y + halfSize.y, pos.z + halfSize.z);
	}
}
