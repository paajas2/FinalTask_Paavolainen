using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block1Trigger : MonoBehaviour
{
    public AudioSource turnSound;

    void OnTriggerEnter2D(Collider2D collider)
    {

        if (ScaleManager.npcScale == ScaleManager.b2Scale)
        {

            ScaleManager.npcScale = new Vector2(-1, 1);
            turnSound.pitch = (Random.Range(0.6f, .9f));
            turnSound.Play();

        }

    }
}
