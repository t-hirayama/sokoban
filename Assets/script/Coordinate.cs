using UnityEngine;
using System.Collections;

public class Coordinate {
	private static Vector3 ROOT = new Vector3 (-9.0f, 1.5f, -9.0f);

	public int x, z;

	public Coordinate(int x, int z) {
		this.x = x;
		this.z = z;
	}

	public Vector3 toRealPoint() {
		return ROOT + new Vector3(2.0f * this.x, 0.0f, 2.0f * this.z);
	}

	public static Coordinate fromRealPoint(Vector3 realPoint) {
		Vector3 relativePoint = realPoint - ROOT;
		return new Coordinate((int)(relativePoint.x / 2.0f), (int)(relativePoint.z / 2.0f));
	}
	
	public static Coordinate operator+ (Coordinate a, Coordinate b)
	{
		return new Coordinate(a.x + b.x, a.z + b.z);
	}
}
