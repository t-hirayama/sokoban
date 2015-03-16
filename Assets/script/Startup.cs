using UnityEngine;
using System.Collections;

public class Startup : MonoBehaviour {

	public GameObject MovableCube;
	public GameObject UnmovableCube;
	public GameObject Destination;

	const int STAGE_WIDTH = 10;

	// Use this for initialization
	void Start () {
		Game.initialize ();

		Stage s = Game.getStage ();


		string stage =
			"uuuuuuuuuu" +
			"uuuuuuuuuu" +
			"uuuuuuuuuu" +
			"uuu pd uuu" +
			"uuu  m  uu" +
			"uuu    uuu" +
			"uuuuuuuuuu" +
			"uuuuuuuuuu" +
			"uuuuuuuuuu" +
			"uuuuuuuuuu";

		for (int i = 0; i < stage.Length; i ++) {
			string c = stage.Substring(i, 1);
			if (c == "u") {
				instantiateObject(UnmovableCube, i / STAGE_WIDTH, i % STAGE_WIDTH);
			}
			else if (c == "m") {
				instantiateObject(MovableCube, i / STAGE_WIDTH, i % STAGE_WIDTH);
			}
			else if (c == "d") {
				instantiateObject(Destination, i / STAGE_WIDTH, i % STAGE_WIDTH);
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
