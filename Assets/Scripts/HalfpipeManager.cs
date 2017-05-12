using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfpipeManager : MonoBehaviour {

    private PlayerController player;

    public static bool inHalfpipe;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        inHalfpipe = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.CompareTag("PlayerTrigger") || Other.gameObject.CompareTag("Player"))
        {
            inHalfpipe = true;
            if (player.cubePrefab.activeSelf)
            {
                player.cubePrefab.SetActive(false);
                player.playerRenderer.enabled = true;
            }
        }
    }

    void OnTriggerStay(Collider Other)
    {
        if (Other.gameObject.CompareTag("PlayerTrigger"))
        {
            inHalfpipe = true;
            if (player.cubePrefab.activeSelf)
            {
                player.cubePrefab.SetActive(false);
                player.playerRenderer.enabled = true;
            }
        }
    }

    void OnTriggerExit(Collider Other)
    {
        if (Other.gameObject.CompareTag("PlayerTrigger"))
        {
            inHalfpipe = false;
        }
    }
}
