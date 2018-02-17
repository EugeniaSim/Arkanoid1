using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float velocity, direction;
    public Rigidbody2D rbPlayer;

	void Update () {
        direction = Input.GetAxisRaw("Horizontal");

	}

    void FixedUpdate()
    {
        rbPlayer.velocity = new Vector2(direction * velocity, 0);
    }


}
