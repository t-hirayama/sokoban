using UnityEngine;
using System.Collections;

public class Game {

	private static Game instance;

	private Stage stage;

	public static Game initialize(View view, string data) {
		instance = new Game (view, data);
		return instance;
	}

	public static Game getInstance() {
		return instance;
	}

	public Game(View view, string data) {
		this.stage = new Stage(data);
	}

	public int getCell(int x, int z) {
		return stage.getCell (x, z);
	}

	public bool isMovableAt(Coordinate position) {
		int cell = getCell(position.x, position.z);
		switch (cell) {
		case Stage.NONE:
		case Stage.DESTINATION:
			return true;
		}

		return false;
	}

	public bool moveCube(Coordinate current, Coordinate next) {
		return stage.moveCube(current, next);
	}
}
