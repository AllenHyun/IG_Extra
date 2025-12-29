using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI pointText;
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private TextMeshProUGUI finalText;
    private int points = 0;
    private float time = 120;


    private void Update()
    {
        time -= Time.deltaTime;
        timeText.text = "" + (int)time;

        if(time < 0)
        {
            Lose();
        }
    }
    public void AddPoint()
    {
        points++;
        pointText.text = "" + points;

        if(points >= 16)
        {
            Win();
        }
    }

    private void Win()
    {
        finalText.gameObject.SetActive(true);
        finalText.text = "You win!";
        Time.timeScale = 0;
    }

    private void Lose()
    {   
        finalText.gameObject.SetActive(true);
        finalText.text = "You lose!";
        Time.timeScale = 0;
    }
}
