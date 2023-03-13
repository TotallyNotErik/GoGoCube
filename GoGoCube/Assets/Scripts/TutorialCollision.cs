using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialCollision : MonoBehaviour
{
    public Vector3 resPos;
    public PlayerMovement movement;
    public TextMeshProUGUI tryagain;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            Invoke("revive",1f);
        }
    }

    public void revive() 
    {
        this.transform.position = resPos;
        movement.enabled = true;
        tryagain.gameObject.SetActive(true);
    }
}
