using UnityEngine;
using System.Collections;

public class NewGame : MonoBehaviour {

    public void StartGame() {
        Application.LoadLevel("game");
    }

    public void GameIA()
    {
        Application.LoadLevel("gameIA");
    }

}
