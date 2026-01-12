using Assets.Scripts.UtilityScripts;
using System;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    private GameManager gameManager;
    public static event Action<Player> OnGoalScored;
    public PlayerColorEnum netColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameManager.GetInstance();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            var ball = collision.GetComponent<BallPlayerTouchHandler>();
            var playerScorer = ball.lastPlayerTouch.FirstOrDefault(x => x.selectedPlayer != this.netColor);
            OnGoalScored(playerScorer);
        }
    }
}
