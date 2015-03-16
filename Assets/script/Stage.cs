using UnityEngine;
using System.Collections;

public class Stage {

	public const int HEIGHT = 10;
	public const int WIDTH = 10;

	public const int NONE = 0;
	public const int MOVABLE = 1;
	public const int UNMOVABLE = 2;
	public const int DESTINATION = 3;
	public const int PUT = 4;

	private int[,] cells;

	public Stage(string data) {
		cells = parse (data);
	}

	private static int[,] parse(string data) {
		int[,] cells = new int[WIDTH, HEIGHT];
		for (int i = 0; i < data.Length; i++) {
			string ch = data.Substring(i, 1);
			if (ch == "u") {
				cells[i / WIDTH, i % WIDTH] = UNMOVABLE;
			}
			else if (ch == "m") {
				cells[i / WIDTH, i % WIDTH] = MOVABLE;
			}
			else if (ch == "d") {
				cells[i / WIDTH, i % WIDTH] = DESTINATION;
			}
			else {
				cells[i / WIDTH, i % WIDTH] = NONE;
			}
		}
		return cells;

	}

	public int getCell(int x, int z) {
		return cells[x, z];
	}

	public void moveCube(Coordinate current, Coordinate next) {
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
	}
}
