using UnityEngine;
using System.Collections;

public class scriptMove : MonoBehaviour {
	public int speed = 30;
	public int rotateSpeed = 3;
	// Use this for initialization
	void Start () {
		
	}
	int up = 0;
	int down = 0;
	int left = 0;
	int right = 0;
	float upDown = 0;
	float leftRight = 0;
	//float xSpeed = 0;
	//float zSpeed = 0;
	float angle = 0;
	
	float Rspeed = 0;
	// Update is called once per frame
	void FixedUpdate () {
		angle = rigidbody.rotation.y;
		
		leftRight = -Input.GetAxis("Horizontal");
		upDown = Input.GetAxis("Vertical");
		
		Rspeed =-((leftRight)/10f)*rotateSpeed;
		
		rigidbody.AddRelativeForce(new Vector3(0,0,(upDown)*speed));
		rigidbody.AddTorque(new Vector3(0,Rspeed,0));
        //transform.rotation.y+=(left+right)*rotateSpeed;
    }
}
