using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using SimpleFirebaseUnity;
using SimpleFirebaseUnity.MiniJSON;

public class four : MonoBehaviour {
	public Text score;
	public int playerScore;
	public string playerName;

	public InputField nameText;

	private System.Random random = new System.Random ();

 public void onSubmit(){
	 playerName = nameText.text;
	 PostToDB();
 }

	private void PostToDB() {
		Firebase firebase = Firebase.CreateNew("https://ones-9b1ba.firebaseio.com","");

		FirebaseQueue firebaseQueue = new FirebaseQueue(true, 3, 1f);
		firebaseQueue.AddQueuePush(firebase.Child(playerName, false), "{ \"score\":"+ playerScore + "}", true);
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
}
