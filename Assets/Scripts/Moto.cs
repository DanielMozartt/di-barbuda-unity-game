using UnityEngine;
using System.Collections;

public class Moto : MonoBehaviour {
	public float velocidade;
	public bool play;
	public float gravity = 12f;
		// Use this for initialization
	void Start () {
		play = true;
		velocidade = 8f;
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(play){
			animation.Play ("Moto");
			transform.Translate(0,0,velocidade * Time.deltaTime);
	
  }
 }
	void OnCollisionEnter(Collision collision) {
	
		if (collision.rigidbody.tag == "Escola"){
                
			    Destroy(gameObject);	
		}		
        
    }
}
