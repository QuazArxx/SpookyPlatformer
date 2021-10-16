using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    public Transform player;
    public Vector2 PlayerStart;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        PlayerStart = new Vector2(player.position.x, player.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;

        temp.x = player.position.x;

        transform.position = temp;
    }
}
