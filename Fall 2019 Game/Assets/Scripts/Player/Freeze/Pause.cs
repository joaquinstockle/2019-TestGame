using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseScreen;
    private bool OnPause = false;
    public void Start()
    {
        pauseScreen.SetActive(false);
        
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            OnPause = !OnPause;
        }
        
        if (OnPause)
        {
            Cursor.lockState = CursorLockMode.None;
            pauseScreen.SetActive(true);
            Time.timeScale = 0f;

        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            pauseScreen.SetActive(false);
            Time.timeScale = 1f;

        }


    }
}
