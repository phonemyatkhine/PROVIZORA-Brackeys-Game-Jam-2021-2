using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    private Text score_text;
    private Text status;
    private Text mistake_text;
    private static int score =0;
    private static int score_streak =0;
    private static int mistake = 0;
    private float wait_to_clean;

    // Start is called before the first frame update
    void Start()
    {
        Text score_text = GameObject.Find("Score_Text").GetComponent<Text>();
        score_text.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    public void addScore(int incoming_score) {
        Text score_text = GameObject.Find("Score_Text").GetComponent<Text>();
        if (score_streak <= 5) {
            score += incoming_score;
            score_streak ++;            
        } else if (score_streak <=9) {
            score += incoming_score +50;
            showCombo(score_streak);
            score_streak ++;            
        } else if (score_streak <= 10) {
            score += incoming_score +50;
            showCombo(score_streak);
            score_streak ++;
        }
        score_text.text = score.ToString();
    }

    public void showCombo(int combo_streak) {
        Text status = GameObject.Find("Status").GetComponent<Text>();
        status.text = combo_streak + " in a row Combo!!!";

    }

    public void resetScore(){
        score = 0;
    }

    public void error() {
        score_streak = 0;
        mistake ++;
        Text mistake_text = GameObject.Find("Mistake_Text").GetComponent<Text>();
        mistake_text.text = mistake + "/25 mistakes !!";
    }
    
    public bool gameOver() {
        if(mistake == 3) {
            return true;
        }
        return false;
    }

}


   
