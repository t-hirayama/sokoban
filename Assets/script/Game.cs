using UnityEngine;
using System.Collections;

public class Game {

	private static Game instance;

	private Stage stage;

	public static Game initialize(string data) {
		instance = new Game (data);
		return instance;
	}

	public static Game getInstance() {
		return instance;
	}

	public Game(string data) {
		stage = new Stage(data);
	}

	public int getCell(int x, int z) {
		return stage.getCell (x, z);
	}

}
