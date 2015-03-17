using UnityEngine;
using System.Collections;

public class MovableCube : MonoBehaviour {
	public void create(Canvas canvas) {
		for (int i = 0; i < transform.childCount; i++) {
			Transform t = transform.GetChild (i);
			Surface s = t.GetComponent<Surface> ();
			s.create(canvas);
		}




	}

}
