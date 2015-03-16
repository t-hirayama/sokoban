using UnityEngine;
using System.Collections;

public class Startup : MonoBehaviour {

	public GameObject MovableCube;
	public GameObject UnmovableCube;
	public GameObject Destination;


	// Use this for initialization
	void Start () {

		View view = new View ();
		Game game = Game.initialize (
			view,
			"uuuuuuuuuu" +
			"uuuuuuuuuu" +
			"uuuuuuuuuu" +
			"uuu pdd  u" +
			"uuu  mm  u" +
			"uuu     uu" +
			"uuuuuuuuuu" +
			"uuuuuuuuuu" +
			"uuuuuuuuuu" +
			"uuuuuuuuuu"
			);

		for (int x = 0; x < Stage.WIDTH; x++) {
			for (int z = 0; z < Stage.HEIGHT; z++) {
				int c = game.getCell(x, z);
				if (c == Stage.UNMOVABLE) {
					view.instantiateObject(UnmovableCube, x, z);
				}
				else if (c == Stage.MOVABLE) {
					view.instantiateObject(MovableCube, x, z);
				}
				else if (c == Stage.DESTINATION) {
					view.instantiateObject(Destination, x, z);
				}
			}
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
