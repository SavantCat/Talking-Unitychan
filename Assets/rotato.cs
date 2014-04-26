using UnityEngine;
using System.Collections;

public class rotato : MonoBehaviour {

	public Vector3 r = Vector3.zero;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(r);
	}
}
