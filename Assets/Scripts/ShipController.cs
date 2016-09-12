using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class ShipController : MonoBehaviour {

	public GameObject shootProjectile;

	public float shootTimer = 0.0f;
	public float shootDelay = 1.0f;


	SerialPort stream = new SerialPort("/dev/cu.wchusbserial1420", 9600);

	void Start(){
		stream.Open ();
		stream.ReadTimeout = 1;
	}

	void Update () {

		shootTimer += Time.deltaTime;
		if (shootTimer >= shootDelay) {
			Shoot();
			shootTimer = 0.0f;
		}
		string value = stream.ReadLine(); 

	}

	void moveShip(string s){
		Debug.Log (s);
	}

	void Shoot(){

		GameObject projectile = (GameObject)Instantiate(shootProjectile, transform.position, transform.rotation);
	}




}
