using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    float currentTime;
    [SerializeField] Text countdownText;

    void Start()
    {
        currentTime = 121f;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;
        float minutes = Mathf.FloorToInt(currentTime / 60f);
        float seconds = Mathf.FloorToInt(currentTime % 60f);
        countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        if (currentTime <= 11)
        {
            countdownText.color = Color.red;
        }
        if (currentTime <= 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
