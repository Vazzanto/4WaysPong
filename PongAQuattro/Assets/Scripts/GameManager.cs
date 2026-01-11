using TMPro;
using UnityEngine;

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
        gameManagerInstance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        BluPointCounter.GetComponent<TextMeshProUGUI>().text = bluPlayerPoints.ToString();
        RedPointCounter.GetComponent<TextMeshProUGUI>().text = redPlayerPoints.ToString();
        PurlePointCounter.GetComponent<TextMeshProUGUI>().text = purlePlayerPoints.ToString();
        GreenPointCounter.GetComponent<TextMeshProUGUI>().text = greenPlayerPoints.ToString();

        if (bluPlayerPoints > VictoryPointsNeeded)
        {
            VictoryText.GetComponent<TextMeshProUGUI>().text = "Blue Wins";
        }
    }
}
