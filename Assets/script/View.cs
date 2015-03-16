using UnityEngine;
using System.Collections;

public class View : Object {

	public void instantiateObject(GameObject item, int x, int z) {
		Instantiate(item, new Coordinate(x, z).toRealPoint(), Quaternion.identity);
	}

}
