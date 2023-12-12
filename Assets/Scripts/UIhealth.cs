using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIhealth : MonoBehaviour
{
    public Slider slider;
    private float timeValue = 200;
    [SerializeField] public Text text1;
    public void maxhealth(int value)
    {
        slider.value = value;
        slider.maxValue = value;
    }
    public void currenthealth(int value)
    {
        slider.value=value;
    }
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene(8);
        }
        Displaytime(timeValue);
    }

    public void Displaytime(float time2)
    {
        if (time2 < 0)
        {
            time2 = 0;
        }
        float minutes = Mathf.FloorToInt(time2 / 60);
        float seconds = Mathf.FloorToInt(time2 % 60);
        text1.text = string.Format("{0} : {1}", minutes, seconds);
    }
}
