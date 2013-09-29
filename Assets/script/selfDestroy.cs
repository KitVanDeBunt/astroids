using UnityEngine;
using System.Collections;

public class selfDestroy : MonoBehaviour {
	public float lifeTime = 0.5f;
	// Use this for initialization
	void Start () {
		Destroy(gameObject,lifeTime);
	}
}
