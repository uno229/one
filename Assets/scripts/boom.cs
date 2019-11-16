using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boom : MonoBehaviour {
	private Animator anim;
	private const string isCollidedValName= "isColided";
	private const string isBlowValName= "Boom";
	private const int blowTimer = 1;
	private bool isColided = false;

	// Use this for initialization
	void Start () {
		anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ifCollision(){
		isColided = true;
		anim.SetBool(isBlowValName, true);
		Destroy (gameObject, blowTimer);
	}
}

