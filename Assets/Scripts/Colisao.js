#pragma strict
var inimigo:Rigidbody;
var vida: GameObject;
var totalVidas: int;
var velocidade:float;
function Start () {

velocidade = 5f;
totalVidas = 3;

}

function Update () {


		vida.guiText.text ="Vidas: "+ totalVidas.ToString();
		if (totalVidas <= 0){
			
			Destroy(gameObject);			
		}

}	
function OnCollisionEnter(collision:Collision){
    if(collision.rigidbody.tag == "Inimigo"){
       totalVidas--;}
       //Destroy (gameObject);
       if(collision.transform.tag == "Rua"){
       transform.Translate (0, 0, velocidade * Time.deltaTime);
	   animation.PlayQueued ("Andando");
	   velocidade += 0.0001f;
	   }
}


   