using UnityEngine;
using System.Collections;

public class projectileManager : MonoBehaviour {

	public float projectileSpeed = 2.0f;

	BoxCollider2D boxCollider;


	// Update is called once per frame
	void Update () {
		transform.position += Vector3.right * projectileSpeed * 2 * Time.deltaTime;
	}
}
