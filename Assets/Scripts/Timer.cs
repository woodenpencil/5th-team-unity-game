using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public float Time = 0;
    public Text TimerText;
    private void Start()
    {
        TimerText.text = Time.ToString();
    }
    private void Update()
    {
        Time += UnityEngine.Time.deltaTime;
        TimerText.text = (Time).ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                if (Info.fast_finish_1 == 0)
                {
                    Info.fast_finish_1 = Time;
                }
                else
                {
                    if (Info.fast_finish_1 > Time)
                    {
                        Info.fast_finish_1 = Time;
                    }
                }
                Info.last_finish_1 = Time;
            }
            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                if (Info.fast_finish_2 == 0)
                {
                    Info.fast_finish_2 = Time;
                }
                else
                {
                    if (Info.fast_finish_2 > Time)
                    {
                        Info.fast_finish_2 = Time;
                    }
                }
                Info.last_finish_2 = Time;
            }
            if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                if (Info.fast_finish_3 == 0)
                {
                    Info.fast_finish_3 = Time;
                }
                else
                {
                    if (Info.fast_finish_3 > Time)
                    {
                        Info.fast_finish_3 = Time;
                    }
                }
                Info.last_finish_3 = Time;
            }
            SceneManager.LoadScene(1);
        }
    }
}
