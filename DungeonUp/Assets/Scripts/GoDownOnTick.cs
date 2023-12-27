using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoDownOnTick : MonoBehaviour
{

    private void OnEnable()
    {
        GameClock.OneTick += GoDown;
    }

    private void OnDisable()
    {
        GameClock.OneTick -= GoDown;
    }

    void GoDown()
    {
        transform.position += Vector3.down;
    }
}
