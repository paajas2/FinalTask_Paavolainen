using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    public GameObject particleFX;
    public AudioSource collectSound;

    void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("It worked!");
        Instantiate(particleFX, transform.position, transform.rotation);
        collectSound.Play();
        ScoringSystem.theScore += 1;

        Destroy(gameObject);

    }

}