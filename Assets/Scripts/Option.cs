using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Optiont : MonoBehaviour
{
    public void Map1()
    {
        SceneManager.LoadScene(2);
    }
    public void Map2()
    {
        SceneManager.LoadScene(3);
    }
    public void Map3()
    {
        SceneManager.LoadScene(4);
    }
    public void Map4()
    {
        SceneManager.LoadScene(5);
    }
    public void Map5()
    {
        SceneManager.LoadScene(6);
    }
    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
}
