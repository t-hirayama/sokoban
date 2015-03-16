using UnityEngine;
using System.Collections;

public class Game {

	private static Game instance;

	private Stage stage;
	private string data;

	public static Game initialize(string data) {
		instance = new Game (data);
		return instance;
	}

	public static Game getInstance() {
		return instance;
	}

	public Game(string data) {
		stage = new Stage();
		this.data = data;
	}

	public Stage getStage() {
		return stage;
	}

	public string getData() {
		return data;
	}


}
