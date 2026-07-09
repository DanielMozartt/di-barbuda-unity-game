using UnityEngine;
using System.Collections;

public class Movimento : MonoBehaviour
{
	public float velocidade;
	public float pulo;
	public bool play;
	public int totalCoins = 0;
	//public int totalVidas = 0;
	public Transform mesh;
	public float gravity = 12f;
	public GameObject pontuacao;
	//public GameObject vida;
	public Transform camPos;
	// Use this for initialization
	void Start ()
	{
		//totalVidas = 3;
		velocidade = 5f;
		pulo = 30f;
				
	}
	
	// Update is called once per frame
	void Update ()
	{ 
		pontuacao.guiText.text = totalCoins.ToString();
		//vida.guiText.text ="Vidas: "+ totalVidas.ToString();
	
		//if (totalVidas <= 0){
			
			//Destroy (this);			
		//}
		if (play) {
			transform.Translate (0, 0, velocidade * Time.deltaTime);
			animation.PlayQueued ("Andando");
			velocidade += 0.0001f;
	
		}
		{		
			if (Input.GetButton ("D")) {
				animation.Play ("Direita");
				transform.Rotate (0, 40 * Time.deltaTime, 0);
			}
			{		
				if (Input.GetButton ("A")) {
					animation.Play ("Esquerda");
					transform.Rotate (0, -40 * Time.deltaTime, 0);
				}	
				if (Input.GetButton ("Jump")) {
					velocidade = 7f;
					animation.Play ("Agachado");
				
				}
				if (Input.GetButtonUp ("Jump")) {
					velocidade += 1f;
									
				}
				if (Input.GetButtonUp ("Jump")) {
					play = false;
					animation.Play ("Pulo");
					velocidade -= 1f;
					transform.Translate (0,pulo * Time.deltaTime,0);	
				}}}
	}

	void OnTriggerEnter (Collider hit)
	{
		if (hit.CompareTag("Inimigo")){
            Destroy(hit.gameObject);
        
        }
		if (hit.transform.tag == "Rua") {
			play = true;
		}
		if (hit.transform.tag == "Moeda") {
			totalCoins++;
			//totalVidas--;
			Destroy (hit.gameObject);
		}
		if (hit.transform.tag == "Fim") {
			totalCoins++;
			play = false;
			animation.Play ("Fim");
			Destroy (hit.gameObject);
			Destroy(this);
		}
		if (hit.transform.tag == "Mola") {
			//pulo = 350f;
			Destroy (hit.gameObject);
		}
		if (hit.transform.tag == "Ima") {
			velocidade = 10f;
			Destroy (hit.gameObject);
		}
		if (hit.transform.tag == "Estrela") {
			rigidbody.mass = 150000;
			Destroy (hit.gameObject);
        }
	}
	
	void OnCollisionEnter(Collision collision) {
			
			if (collision.rigidbody.tag == "Rua") {
			animation.Stop("Pulo");
			play = true;
			
		}
			//if (collision.rigidbody.tag == "Inimigo"){
                
			    //totalVidas--;
			    //Destroy(collision.gameObject);
			
        
        //}
		
	

        //if (collision.relativeVelocity.magnitude > 2)
            //audio.Play();
        
    }
		
		
	//}
	

  }
		
	


