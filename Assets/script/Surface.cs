using UnityEngine;
using System.Collections;

public class Surface : MonoBehaviour {

	public GameObject Button;
	private Canvas canvas;

	public void create(Canvas canvas) {
		this.canvas = canvas;
	}

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

				GameObject btn = (GameObject)Instantiate(Button);

				UnityEngine.UI.Button btn2 = btn.GetComponent<UnityEngine.UI.Button>();

				RectTransform rect = btn2.GetComponent<RectTransform>();
				rect.anchorMax = new Vector2(1, 1);
				rect.anchorMin = new Vector2(1, 1);
				rect.position = new Vector3(-92.0f, -64.0f, 0.0f);
				btn2.transform.SetParent(canvas.transform, false);

				btn2.onClick.AddListener( () => { 
					Game.currentStage++;
					Application.LoadLevel( Application.loadedLevel );
				} );



			}
		}
	}
}
