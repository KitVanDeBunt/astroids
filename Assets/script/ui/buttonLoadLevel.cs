using UnityEngine;
using System.Collections;

public class buttonLoadLevel : MonoBehaviour {
	public Texture restartTexture;
	public string buttonName;
	
	private void OnGUI(){
		if (GUI.Button (new Rect(15,15,200,100),buttonName))
			Application.LoadLevel("level1");	
	}
}
