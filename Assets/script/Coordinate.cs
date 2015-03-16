using UnityEngine;
using System.Collections;

public class Coordinate {
	private Vector3 ROOT = new Vector3 (-9.0f, 1.5f, -9.0f);

	private int x, z;

	public Coordinate(int x, int z) {
		this.x = x;
		this.z = z;
	}

	public Vector3 toRealPoint() {
		return ROOT + new Vector3(2.0f * this.x, 0.0f, 2.0f * this.z);
	}

}
