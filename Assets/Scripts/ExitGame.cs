using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void doquit()
    {
        Debug.Log("Quitting game");
        Application.Quit();

    }
}
