using UnityEngine;
using System.Collections;

public class live : MonoBehaviour {
	public GUIText scoreText;
	public GUIText lifeText;
	public int setScore = 0 ;
	public int setLife = 5 ;
	private int score;
	private int life;
	
	public GameObject GameOverUI;
	// Use this for initialization
	void Start () {
		score =  setScore;
		life = setLife;
		scoreText.text = "score: "+score;
		lifeText.text = "life: "+life;
	}
	
	public void setScoreText(int Delta){
		score+=Delta;
		scoreText.text = "score: "+score;
	}
	
	public void setLifeText(int Delta){
		life+=Delta;
		lifeText.text = "life: "+life;
		if(life < 0){
			Instantiate (GameOverUI, transform.position,Quaternion.identity);
			Destroy(gameObject);
		}
	}
}
