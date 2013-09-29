using UnityEngine;
using System.Collections;

public class live : MonoBehaviour {
	
	public GUIText scoreText;
	public GUIText lifeText;
	public static int score = 0 ;
	public static int life = 5 ;
	// Use this for initialization
	void Start () {
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
	}
}
