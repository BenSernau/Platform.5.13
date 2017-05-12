using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableManager : MonoBehaviour {

    private PlayerController player;

    public float threshold = -20;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject == player.cubePrefab && player.playerRB.velocity.y < threshold)
        {
            gameObject.SetActive(false);
        }
    }
}
