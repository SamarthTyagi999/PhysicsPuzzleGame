using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Player player;
    public float offset=2.0f;

    public static CameraController instance;

    private void Awake()
    {
        instance = this;
    }

    private void FixedUpdate()
    {
        if (player == null)
        {
            return;
        }

        if(player.launching && player.transform.position.x >= transform.position.x - offset)
        {
            //move camera from one place to another using lerp
            //lerp is used to move from one place to another in a given time
            transform.position = Vector3.Lerp(transform.position, new Vector3(player.transform.position.x + offset, 1, -10), Time.deltaTime * 10);
        }
    }

    public void SetPlayer(Player newPlayer)
    {
        player = newPlayer;
        Vector3 newPos = player.transform.position;
        newPos.z = -10;

        transform.position = newPos;
    }
}
