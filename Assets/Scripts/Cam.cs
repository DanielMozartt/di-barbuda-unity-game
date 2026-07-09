using UnityEngine;
using System.Collections;

public class Cam : MonoBehaviour {
	
	public Transform camPos;
	public Transform diBarbuda;

	// Use this for initialization
	void Start () {
	
		
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = Vector3.Slerp(transform.position,camPos.position,Time.deltaTime);
		transform.LookAt(diBarbuda);
	}
}
