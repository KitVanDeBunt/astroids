using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {
	
	public GameObject astroid;
	float timer = 0;
	float resetTime;
	
	void Start(){
		resetTime = 2;
	}
	
	void Update () {
		timer-=1*Time.deltaTime;
		if(timer<=0){
			timer = resetTime;
			spawnAstroid();
		}
	}
	
	void spawnAstroid(){
		//calculate position
		float horOrVer = Random.Range(0.0f,2.0f);
		float posNeg = Random.Range(0.0f,2.0f);
		float posNegValue;
		if(posNeg>1){
			posNegValue = 5.9f;
		}else{
			posNegValue = -5.9f;	
		}
		
		float z;
		float x;
		if(horOrVer>1){
			z = Random.Range(-5.9f,5.9f);
			x = posNegValue;
		}else{
			z = posNegValue;
			x = Random.Range(-5.9f,5.9f);
		}
		Vector3 astroidSpawnPosition = new Vector3(x,0,z);
		
		//spawn at random rotation
		Instantiate (astroid, astroidSpawnPosition,Random.rotation);
	}
	
}
