using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialStart : MonoBehaviour
{	
	public TextMeshProUGUI nextSlide;
	public Vector3 newResPos;
	public TutorialCollision tut;
	public PlayerMovement player;
	public GameObject gate1;
	public GameObject gate2;
	public GameObject gate3;
	public GameObject gate4;


	void OnTriggerEnter() 
	{
		if(player.speedMultiplier > 1)
		{
			tut.revive();
			player.speedMultiplier = 1f;
			gate1.SetActive(true);
			gate2.SetActive(true);
			gate3.SetActive(true);
			gate4.SetActive(true);
		}

		else
		{
			nextSlide.gameObject.SetActive(true);
			tut.resPos = newResPos;
		}
	}
}
