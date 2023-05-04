using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController
{
    private static GameController instance = new GameController();

    public static GameController getInstance()
    {
        return instance;
    }

    public void logInfo()
    {
        Debug.Log("111");
    }
}
