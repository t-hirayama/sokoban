using UnityEngine;
using System.Collections;

public class View : Object {

	public GameObject instantiateObject(GameObject item, int x, int z) {
		return (GameObject)Instantiate(item, new Coordinate(x, z).toRealPoint(), Quaternion.identity);
	}

}
