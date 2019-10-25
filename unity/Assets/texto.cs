using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class texto : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Este es un ejemplo de texto enriquecido <b>con negrita</b>.");
		Debug.Log ("Este es un ejemplo de texto enriquecido <b><i>con negrita y cursiva</i></b>.");
		Debug.Log ("Este es un ejemplo de texto <i><color=red>con cursiva y en rojo</color></i>.");
		Debug.Log ("Este es un ejemplo de texto <b><color=red>con negrita y en rojo</color></b>.");
		Debug.Log ("Este es un ejemplo de texto <size=20><color=green>en verde y a 20 pixeles</color></size>.");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
