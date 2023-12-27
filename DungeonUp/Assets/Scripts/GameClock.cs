using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClock : MonoBehaviour
{

    [SerializeField] float tick;
    [SerializeField] bool startClock = false;
    private static int starterGuard = 0;



    public delegate void OneTickAction();
    public static OneTickAction OneTick;

    private void Update()
    {
        if (startClock && starterGuard == 0)
        {
            StartCoroutine(GameTick());
            starterGuard = 1;

        }
    }


    IEnumerator GameTick()
    {
        while (true)
        {
            if (OneTick != null) OneTick();
            yield return new WaitForSeconds(tick);
        }
        
    }

}
