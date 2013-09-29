using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {
	public GameObject bullit;
	public float resetTime = 0.5f;
	float shootTimer;
	
	void Start () {
		shootTimer = 0;
	}
	
	void Update () {
		if(shootTimer>=0){
			shootTimer-=Time.deltaTime;
		}
		if (Input.GetKey("space")){
			if(shootTimer<0){
				shootTimer=resetTime;
				Instantiate (bullit, transform.position,transform.rotation);
			}
		}
	}
}
