using UnityEngine;
using System.Collections;

public class RotateCam : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	    if(animation.Play("Fim")){
			
			transform.Rotate (0,80 * Time.deltaTime, 0);
		}
	}
	
}
