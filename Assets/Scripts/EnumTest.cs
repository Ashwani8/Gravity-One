using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumTest : MonoBehaviour
{
    // Enum allow us to create new type of value or data type
   public enum GameState { Ready, Playing, Pause, GameOver = 6}
   public GameState state;
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
                // print("You are ready");
                print(GameState.Ready); // will print Ready
                break;
            case GameState.Playing:
                print("Game On");
                print((int)GameState.Playing); // will display the index number of the Enum
                break;
            case GameState.Pause:
                print("Pause");
                break;
            case GameState.GameOver:
                print("GameOver");
                // will dipaly the assigned Enum
                print((int)GameState.GameOver);
                break;
        }       
    }
}
