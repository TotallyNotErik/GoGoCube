using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScreen : MonoBehaviour
{
    public PlayerMovement player;
    public int match;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other) 
    {
        if(player.gateCheck != match)
            player.speedMultiplier += .25f;

        this.gameObject.SetActive(false);
    }
}
