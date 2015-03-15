using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {

	public void OnTriggerEnter( Collider col ) {
		Application.LoadLevel (Application.loadedLevel);
	}
}
