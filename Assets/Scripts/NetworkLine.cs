using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkLine : MonoBehaviour {

    public NetworkNode fromNode;
    public NetworkNode toNode;
	public LineRenderer lineRenderer;

	private List<GridItem> path;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpdatePath(List<GridItem> path) {
		this.path = path;
		drawPath ();

	}

	private void drawPath(){

		List<Vector3> vectors = new List<Vector3> ();

		foreach(GridItem item in path){
			Vector3 pathPos = item.GetCentre ();
			vectors.Add (pathPos);
		}

		lineRenderer.SetPositions (vectors.ToArray());
	}
}
