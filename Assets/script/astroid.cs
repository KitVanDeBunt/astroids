using UnityEngine;
using System.Collections;

public class astroid: MonoBehaviour {
	public float maxSpeed=70.0f;
	public float minSpeed=50.0f;
	public GameObject explosion;
	float randomScale;
	public GameObject spawn;
	private GameObject player;
	void Start () {
		player= GameObject.Find("player");
		float randomSpeed = Random.Range(minSpeed,maxSpeed);
		rigidbody.AddRelativeForce(new Vector3(0,0,randomSpeed));
    }
	
	void OnTriggerEnter(Collider col) {
		if(col.tag =="bullit"){
			explode();
			player.GetComponent<live>().setScoreText(5);
			if(spawn!=null){
				Instantiate (spawn, transform.position,Random.rotation);
				Instantiate (spawn, transform.position,Random.rotation);
			}
			Destroy(col.gameObject);
			Destroy(gameObject);
		}
    }
	
	void OnCollisionEnter(Collision col) {
		if(col.collider.tag =="Player"){
			explode();
			player.GetComponent<live>().setLifeText(-1);
			Destroy(gameObject);
		}
    }
	
	void explode(){
		Quaternion explRotation = Quaternion.AngleAxis(270, Vector3.right);
		Instantiate (explosion, transform.position,explRotation);
	}
}
