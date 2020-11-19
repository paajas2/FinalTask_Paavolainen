using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleToggle : MonoBehaviour
{
    public GameObject speechBubble;
    public AudioSource speechBark;

    void OnTriggerEnter2D(Collider2D collider)
    {

        speechBubble.SetActive(true);
        speechBark.Play();

        Destroy(gameObject);

    }
}
