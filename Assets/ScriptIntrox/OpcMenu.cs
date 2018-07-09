using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpcMenu : MonoBehaviour {

	public void PlayGame(){
        Application.LoadLevel("Escena1");
	}
	public void QuitGame(){
		Application.Quit ();
	}
}
