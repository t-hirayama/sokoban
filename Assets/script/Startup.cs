using UnityEngine;
using System.Collections;

public class Startup : MonoBehaviour {

	public GameObject MovableCube;
	public GameObject UnmovableCube;
	public GameObject Destination;


	// Use this for initialization
	void Start () {

		Game game = Game.initialize (
			"uuuuuuuuuu" +
			"uuuuuuuuuu" +
			"uuuuuuuuuu" +
			"uuu pd uuu" +
			"uuu  m  uu" +
			"uuu    uuu" +
			"uuuuuuuuuu" +
			"uuuuuuuuuu" +
			"uuuuuuuuuu" +
			"uuuuuuuuuu"
			);

		for (int x = 0; x < Stage.WIDTH; x++) {
			for (int z = 0; z < Stage.HEIGHT; z++) {
				int c = game.getCell(x, z);
				if (c == Stage.UNMOVABLE) {
					instantiateObject(UnmovableCube, x, z);
				}
				else if (c == Stage.MOVABLE) {
					instantiateObject(MovableCube, x, z);
				}
				else if (c == Stage.DESTINATION) {
					instantiateObject(Destination, x, z);
				}
			}
		}
	}

	private void instantiateObject(GameObject item, int x, int z) {
		Instantiate(item, new Coordinate(x, z).toRealPoint(), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
