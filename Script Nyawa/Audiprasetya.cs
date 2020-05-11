using UnityEngine;
using System.Collections;

public class Audiprasetya : MonoBehaviour {

	public GameObject playerPrefab;
	GameObject playerInstance;

	public int numLives = 4;

	float respawnTimer;

	// Use this for initialization
	void Start () {
		SpawnPlayer();
	}

	void SpawnPlayer() {
		numLives--;
		respawnTimer = 1;
		playerInstance = (GameObject)Instantiate(playerPrefab, transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		if(playerInstance == null && numLives > 0) {
			respawnTimer -= Time.deltaTime;

			if(respawnTimer <= 0) {
				SpawnPlayer();
			}
		}
	}

	void OnGUI() {
		
		if(numLives > 0 || playerInstance!= null) {
			GUI.Button( new Rect(0, 0, 100, 50), "Nyawa: " + numLives);
		}
		else {
			 GUI.Label(new Rect(650, 300, 100, 20), "Coba lagi dong");

		}
	}
}
