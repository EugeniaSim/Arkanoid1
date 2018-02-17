using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class GameOver : MonoBehaviour {

    public GameObject winPanel, losePanel;
    public Text onWinPanelScore, onLosePanelText;


    public void WhenVictory()
    {
       // Time.timeScale = 0;
        winPanel.SetActive(true);
        onWinPanelScore.text = Manager.TextControll.score.ToString();    
    }

    public void WhenDefeat()
    {
       // Time.timeScale = 0;
        losePanel.SetActive(true);
        onLosePanelText.text = Manager.TextControll.score.ToString();
    }

}
