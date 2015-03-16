using UnityEngine;
using System.Collections;

public class Startup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Game.initialize ();

		Stage s = Game.getStage ();




		Debug.Log ("startup " + s.val);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
