using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rig;
    public bool launching;


    private void Awake()
    {
        rig.isKinematic = true;//no physics is being applied
    }
    private void Update()
    {
        if (launching && rig.IsSleeping())
        {
            //next player
            GameManager.instance.PlayerFinished();
            //destroy previous player
            Destroy(gameObject);
        }
    }

    public void Launch(Vector2 direction)
    {
        rig.isKinematic = false;
        rig.AddForce(direction * 5, ForceMode2D.Impulse);
        launching = true;
    }
}
