using Assets.Scripts.UtilityScripts;
using System;
using System.Collections.Generic;
using UnityEngine;

public class BallPlayerTouchHandler : MonoBehaviour
{
     [SerializeField] public readonly FixedInsertList<Player> lastPlayerTouch = new FixedInsertList<Player>(4);

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.CompareTag("Player"))
        {
            var player = collision.gameObject.GetComponent<Player>();
            lastPlayerTouch.Insert(player);
        }
    }


}
