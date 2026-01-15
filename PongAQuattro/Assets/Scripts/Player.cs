using Assets.Scripts.UtilityScripts;
using UnityEngine;

public class Player : MonoBehaviour
{

    public PlayerColorEnum selectedPlayer;
    public GameObject positionA;
    public GameObject positionB;
    public float speed;
    private float targetA;
    private float targetB;
    private KeyCode input1;
    private KeyCode input2;

    private void Start()
    {
        this.SetInputBasedOnPlayer();
    }

    private void Update()
    {
        var playerSizeHalved = this.transform.localScale.x / 2;
        this.targetA = this.positionA.transform.localPosition.x;
        this.targetB = this.positionB.transform.localPosition.x;

        float actualSpeed = speed * Time.deltaTime;
        Vector3 position = this.transform.localPosition;
        if (Input.GetKey(input2))
        {
            position.x = Mathf.MoveTowards(transform.localPosition.x, targetB, actualSpeed);
            position.x = Mathf.Clamp(position.x, targetA + playerSizeHalved, targetB - playerSizeHalved);
        }

        if (Input.GetKey(input1))
        {
            position.x = Mathf.MoveTowards(transform.localPosition.x, targetA, actualSpeed);
            position.x = Mathf.Clamp(position.x, targetA + playerSizeHalved, targetB - playerSizeHalved);
        }


        this.transform.localPosition = position;
    }

    private void SetInputBasedOnPlayer()
    {
        switch (selectedPlayer)
        {
            case PlayerColorEnum.Blue:
                input1 = KeyCode.Q;
                input2 = KeyCode.W;
                break;
            case PlayerColorEnum.Green:
                input1 = KeyCode.Z;
                input2 = KeyCode.X;
                break;
            case PlayerColorEnum.Red:
                input1 = KeyCode.I;
                input2 = KeyCode.J;
                break;
            case PlayerColorEnum.Purlple:
                input1 = KeyCode.UpArrow;
                input2 = KeyCode.DownArrow;
                break;
        }
    }
}
