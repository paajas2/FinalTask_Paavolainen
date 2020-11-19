using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleManager : MonoBehaviour
{
    public GameObject npcTurn;
    public static Vector2 npcScale;
    public static Vector2 b1Scale;
    public static Vector2 b2Scale;

    void Start()
    {

        npcScale = new Vector2(-1, 1);
        b1Scale = new Vector2(-1, 1);
        b2Scale = new Vector2(1, 1);

    }

    void Update()
    {

        npcTurn.transform.localScale = npcScale;

    }
}
