using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 2f;
    void Update()
    {
        transform.Rotate(0, 0, 360 * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMove player=collision.GetComponent<PlayerMove>();
        if(player != null)
        {
            player.changehealth(-5);
        }
    }
}
