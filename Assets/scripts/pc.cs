using UnityEngine;

public class pc : MonoBehaviour {

public float speed = 20f;
 private Rigidbody2D rb;
 private Animator anim; 
 public float jumpForce = 1500f;
 
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		float moveX = Input.GetAxis("Horizontal");
		//rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime);
		jumpForce = 1500f;
		if(Input.GetKeyDown (KeyCode.Space)){
			rb.AddForce (new Vector2(0,jumpForce));
		}
		
	}

void FixedUpdate () {
	float move = Input.GetAxis ("Horizontal");
	rb.velocity = new Vector3 (move * speed, rb.velocity.y);
	anim.SetFloat ("speed",Mathf.Abs(move));
	}
	void OnCollisionEnter2D(Collision2D collision){
		Debug.Log ("Collision");
		if (null != collision) {
			boom bombObj = collision.gameObject.GetComponent<boom> ();
			if (null != bombObj) {
				bombObj.ifCollision ();
			}

		}
	}
}