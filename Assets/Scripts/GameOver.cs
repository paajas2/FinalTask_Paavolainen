using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameplay;
    public GameObject epilogue;
    public GameObject camera;
    public GameObject score;
    public AudioSource gameOver;

    void OnTriggerEnter2D(Collider2D collider)
    {

        gameplay.SetActive(false);
        epilogue.SetActive(true);
        camera.SetActive(true);
        score.SetActive(false);
        gameOver.Play();

    }

}
