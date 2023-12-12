using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
public class Itemcollect : MonoBehaviour
{
  
    public AudioSource eat;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMove play=collision.GetComponent<PlayerMove>();
        if(play != null)
        {
            play.changehealth(5);
            Destroy(gameObject);
            eat.Play();
        }
    }
}


