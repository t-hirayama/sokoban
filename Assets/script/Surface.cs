using UnityEngine;
using System.Collections;

public class Surface : MonoBehaviour {

	public void OnTriggerEnter( Collider col ) {
		const float REF_VALUE = 0.5f;
		const float DISTANCE = 2.0f;

		if (transform.localPosition.x > REF_VALUE) {
			transform.parent.Translate(new Vector3(-DISTANCE, 0.0f, 0.0f));
		}
		else if (transform.localPosition.x < -REF_VALUE) {
			transform.parent.Translate(new Vector3(DISTANCE, 0.0f, 0.0f));
		}
		else if (transform.localPosition.z > REF_VALUE) {
			transform.parent.Translate(new Vector3(0.0f, 0.0f, -DISTANCE));
		}
		else if (transform.localPosition.z < -REF_VALUE) {
			transform.parent.Translate(new Vector3(0.0f, 0.0f, DISTANCE));
		}
		/*
*/		
	}
}
