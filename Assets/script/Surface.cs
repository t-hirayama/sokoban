using UnityEngine;
using System.Collections;

public class Surface : MonoBehaviour {

	public GameObject Button;

	public void OnTriggerEnter( Collider col ) {

		const float REF_VALUE = 0.5f;
		Coordinate movement = new Coordinate (0, 0);

		if (transform.localPosition.x > REF_VALUE) {
			movement.x = -1;
		}
		else if (transform.localPosition.x < -REF_VALUE) {
			movement.x = 1;
		}
		else if (transform.localPosition.z > REF_VALUE) {
			movement.z = -1;
		}
		else if (transform.localPosition.z < -REF_VALUE) {
			movement.z = 1;
		}

		Game game = Game.getInstance ();
		const float DISTANCE = 2.0f;
		Coordinate current = Coordinate.fromRealPoint(transform.parent.transform.position);

		Coordinate next = current + movement;
		if (game.isMovableAt (next)) {
			transform.parent.Translate(new Vector3(movement.x * DISTANCE, 0.0f, movement.z * DISTANCE));
			if (game.moveCube(current, next)) {

				Instantiate(Button);

				// finished playing, show result of the game.
//				Debug.Log("completed this stage!");
			}
		}
	}
}
