using TMPro;
using UnityEngine;
using Assets.Scripts.UtilityScripts;
public class GameManager : MonoBehaviour
{
    private static GameManager gameManagerInstance;

    public static GameManager GetInstance()
    {
        if(gameManagerInstance == null)
        {
            gameManagerInstance = new GameManager();
        }

        return gameManagerInstance;
    }

    public int bluPlayerPoints;
    public int redPlayerPoints;
    public int purlePlayerPoints;
    public int greenPlayerPoints;

    public int VictoryPointsNeeded;

    public GameObject BluPointCounter;
    public GameObject RedPointCounter;
    public GameObject PurlePointCounter;
    public GameObject GreenPointCounter;
    public GameObject VictoryText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DoorBehaviour.OnGoalScored += HandleGoal;
        gameManagerInstance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void HandleGoal(Player player)
    {
        switch (player.selectedPlayer)
        {
            case PlayerColorEnum.Blue:
                bluPlayerPoints += 1;
                BluPointCounter.GetComponent<TextMeshProUGUI>().text = bluPlayerPoints.ToString();
                break;
            case PlayerColorEnum.Red:
                redPlayerPoints += 1;
                RedPointCounter.GetComponent<TextMeshProUGUI>().text = redPlayerPoints.ToString();
                break;
            case PlayerColorEnum.Purlple:
                purlePlayerPoints += 1;
                PurlePointCounter.GetComponent<TextMeshProUGUI>().text = purlePlayerPoints.ToString();
                break;
            case PlayerColorEnum.Green:
                greenPlayerPoints += 1;
                GreenPointCounter.GetComponent<TextMeshProUGUI>().text = greenPlayerPoints.ToString();
                break;
        }

        this.CheckVictory();
    }

    private void CheckVictory()
    {
        if (bluPlayerPoints >= VictoryPointsNeeded)
        {
            VictoryText.GetComponent<TextMeshProUGUI>().text = "Blue Wins";
        }
        else if (redPlayerPoints >= VictoryPointsNeeded)
        {
            VictoryText.GetComponent<TextMeshProUGUI>().text = "Red Wins";
        }
        else if(purlePlayerPoints >= VictoryPointsNeeded)
        {
            VictoryText.GetComponent<TextMeshProUGUI>().text = "Purple Wins";
        }
        else if (greenPlayerPoints >= VictoryPointsNeeded)
        {
            VictoryText.GetComponent<TextMeshProUGUI>().text = "Green Wins";
        }
    }
}
