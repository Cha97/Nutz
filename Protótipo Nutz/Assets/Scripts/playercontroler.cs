using UnityEngine;
using System.Collections;

public class playercontroler : MonoBehaviour {

	public Animator	   Anime;
	public Rigidbody2D PlayerRigidbody;
	public int		   forceJump;




	//Verifica o chão 
	public bool		   Grounded;
	public LayerMask   whatIsGround;
	public Transform   GroundCheck; 
	void Start () {
	
		
	}
	

	void Update () {
		if(Input.GetButtonDown("Jump")){
			PlayerRigidbody.AddForce(new Vector2(50,forceJump)); //força do pulo new vector e o vetor x e y para ver o quanto ele vai para o lado e para cima

		}

		Grounded = Physics2D.OverlapCircle (GroundCheck.position, 0.2f, whatIsGround); //Cria um pequeno Circulo no objeto filho player, para verificar se está colindo com o chão 

		Anime.SetBool ("jump", !Grounded);  //retorna o valor para o animator começar a animação de pulo... Colocou o ! (Não porque está ao contrario) se o grounded estiver no chão é true, ou seja está na animação de pulo.


}
}



