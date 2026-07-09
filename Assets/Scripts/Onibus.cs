using UnityEngine;
using System.Collections;

public class Onibus : MonoBehaviour {
	public float velocidade;

	// Use this for initialization
	void Start () {
		
		velocidade = 7f;
				
	}
	
	// Update is called once per frame
	void Update () {
		
		
			transform.Translate(0,velocidade * Time.deltaTime,0);
  
 }
	void OnCollisionEnter(Collision collision) {
	
		if (collision.rigidbody.tag == "Escola"){
                
			    Destroy(gameObject);	
		}		
        
    }
		
}
