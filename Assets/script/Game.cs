using UnityEngine;
using System.Collections;

public class Game {

	private static Stage stage;

	public static void initialize() {
		stage = new Stage();
	}

	public static Stage getStage() {
		return stage;
	}


}
