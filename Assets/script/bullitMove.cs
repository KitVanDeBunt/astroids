using UnityEngine;
using System.Collections;

public class bullitMove : MonoBehaviour {
	public int speed = 30;
	void Update () {
		transform.Translate(Vector3.forward * Time.deltaTime*speed);
		
		if(transform.position.x>6){
			destroy();
		}
		if(transform.position.x<-6){
			destroy();
		}
		if(transform.position.z>6){
			destroy();
		}
		if(transform.position.z<-6){
			destroy();
		}
	}
	
	void destroy(){
		Destroy(gameObject);
	}
}
