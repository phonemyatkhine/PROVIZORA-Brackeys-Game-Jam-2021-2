using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public TimerScript timer_script;
    private int minute;
    private string[] game_modes = {"Easy","Moderate","Hard","GameOver"};
    private string current_game_mode;
    public ScoreKeeper score_keeper;
    public bool game_over;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        current_game_mode = getGameMode();
        game_over = score_keeper.gameOver();
        Debug.Log(game_over);
    }

    public string getGameMode() {
        string game_mode;
        minute = timer_script.getMinute();
        if (minute <3) {
            return game_mode = game_modes[0];
        } else if (minute <6) {
            return game_mode = game_modes[1];
        } else if (minute <9) {
            return game_mode = game_modes[2];
        } else if (minute == 9 ){
            return game_mode = game_modes[3];
        }
        return game_mode = game_modes[3];
    }

    public string setGameMode(string mode) {
        return current_game_mode = mode;
    }

}
