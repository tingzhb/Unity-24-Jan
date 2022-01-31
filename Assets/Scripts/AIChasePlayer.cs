using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChasePlayer : MonoBehaviour {
	private CommandContainer commandContainer;
	private Transform player;

	private void Start() { 
		commandContainer = GetComponentInChildren<CommandContainer>();
		player = GameObject.FindWithTag("Player").transform;
	}

	private void Update() {
		var directionToPlayer = Vector3.Normalize(player.position - transform.position);
		var horizontalDirectionToPlayer = Mathf.Sin(directionToPlayer.x);
		commandContainer.walkCommand = horizontalDirectionToPlayer;
	}
}
