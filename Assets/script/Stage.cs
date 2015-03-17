using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Stage {

	public const int HEIGHT = 10;
	public const int WIDTH = 10;

	public const int NONE = 0;
	public const int MOVABLE = 1;
	public const int UNMOVABLE = 2;
	public const int DESTINATION = 3;
	public const int PUT = 4;
	public const int PLAYER_CHARACTER = 5;

	private int[,] cells;
	private static List<Coordinate> trace;

	public Stage(string data) {
		cells = parse (data);
	}

	private static int[,] parse(string data) {
		int[,] cells = new int[WIDTH, HEIGHT];

		trace = new List<Coordinate>();

		for (int i = 0; i < data.Length; i++) {
			string ch = data.Substring(i, 1);
			Coordinate position = new Coordinate(i / WIDTH, i % WIDTH);
			if (ch == "u") {
				cells[position.x, position.z] = UNMOVABLE;
			}
			else if (ch == "m") {
				cells[position.x, position.z] = MOVABLE;
			}
			else if (ch == "d") {
				cells[position.x, position.z] = DESTINATION;
				trace.Add(position);
			}
			else if (ch == "p") {
				cells[position.x, position.z] = PLAYER_CHARACTER;
			}
			else {
				cells[position.x, position.z] = NONE;
			}
		}
		return cells;

	}

	public int getCell(int x, int z) {
		return cells[x, z];
	}

	public bool moveCube(Coordinate current, Coordinate next) {
		switch (cells[next.x, next.z]) {
		case DESTINATION:
			cells[next.x, next.z] = PUT;
			break;
		case NONE:
			cells[next.x, next.z] = MOVABLE;
			break;
		}

		switch (cells[current.x, current.z]) {
		case MOVABLE:
			cells[current.x, current.z] = NONE;
			break;
		case PUT:
			cells[current.x, current.z] = DESTINATION;
			break;
		}

		return isCompleted ();
	}

	public bool isCompleted() {
		for (int i = 0; i < trace.Count; i++) {
			Coordinate position = trace[i];
			if (cells[position.x, position.z] != PUT) {
				return false;
			}
		}
		return true;
	}
}
