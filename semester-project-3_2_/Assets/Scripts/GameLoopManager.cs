using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoopManager 
{
    public enum GameState
    {
        Playing,
        GameOver
    }

    public static GameState state = GameState.Playing;
    public static event Action<GameState> onGameStateChange;

    public static GameState GetGameSTate()
    {
        return state;
    }

    public static void SetGameState(GameState newState)
    {
        state = newState;
        if (onGameStateChange != null)
            onGameStateChange(state);
    }
}
