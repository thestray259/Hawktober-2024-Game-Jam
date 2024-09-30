using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    enum State
    {
        TITLE,
        GAME,
        CUTSCENE,
        GAME_DEAD,
        GAME_WIN
    }

    State state = State.TITLE;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
