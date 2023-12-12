using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Finsh : MonoBehaviour
{
    private AudioSource finsh;
    private bool Levelcomplete = false;
    void Start()
    {
        finsh = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !Levelcomplete)
        {
            finsh.Play();
            Levelcomplete = true;
            Invoke("CompleteLevel", 2f);
        }
    }
    private void CompleteLevel()
    {
        SceneManager.LoadScene(7);
    }
}
