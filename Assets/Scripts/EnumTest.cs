using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumTest : MonoBehaviour
{
    // Enum allow us to create new type of value or data type
    enum GameState { Ready, Playing, Pause, GameOver}
    GameState state;
    // Start is called before the first frame update
    void Start()
    {
        state = GameState.Ready; // we cannot assign any value other than the 4 defined up.
    }

    // Update is called once per frame
    void Update()
    {
        switch(state)
        {
            case GameState.Ready:
                print("You are ready");
                break;
            case GameState.Playing:
                print("Game On");
                break;
            case GameState.Pause:
                print("Pause");
                break;
            case GameState.GameOver:
                print("GameOver");
                break;
        }       
    }
}
