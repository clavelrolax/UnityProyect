using UnityEngine;
using System.Collections;

public class tubosScript : MonoBehaviour {
	//declaramos la velocidad inicial de la columna
	public Vector3 velocidad;
	//La distancia que habra entre una columna y otra
	public Vector3 distanciaEntreColumnas;
	//La forma correcta de hacerlo ¿?
	public SpriteRenderer formaColumna;
	
	void Update () {
		//funcion que mueve los tubos
		moverTubo ();
	}
	
	private void moverTubo()
	{
		//Los tubos iran avanzando de a pocos, igual que el Flappy bird
		this.transform.position = this.transform.position + (velocidad*Time.deltaTime);
		
		//if(formaColumna.isVisible == true)
		
		if (this.transform.position.x <= -13.5f)
		{
			//Le aumentamos la distancia entre columnas al llegar a la posicion -13.5
			Vector3 posicionTemporal = this.transform.position + distanciaEntreColumnas;
			//Cambiamos el lugar en Y por uno random
			posicionTemporal.y = Random.Range (-3f, 0.6f);
			//Movemos a los tubos a esa posicion
			this.transform.position = posicionTemporal;
		}
	}
}
