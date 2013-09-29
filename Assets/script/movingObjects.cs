using UnityEngine;
using System.Collections;

public class movingObjects : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	//set  on screen
		float currentX = transform.position.x;
		float currentZ = transform.position.z;
		if(transform.position.x>6){
			transform.position=new Vector3(-5.9f,0,currentZ);
		}
		if(transform.position.x<-6){
			transform.position=new Vector3(5.9f,0,currentZ);
		}
		if(transform.position.z>6){
			transform.position=new Vector3(currentX,0,-5.9f);
		}
		if(transform.position.z<-6){
			transform.position=new Vector3(currentX,0,5.9f);
		}
	}
}
