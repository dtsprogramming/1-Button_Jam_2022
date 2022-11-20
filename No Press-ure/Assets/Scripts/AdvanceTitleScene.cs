using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdvanceTitleScene : MonoBehaviour
{
    private Input _playerInput;

    // Update is called once per frame
    void Update()
    {
        CheckForKeyPress();
    }

    private void CheckForKeyPress()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        }
    }
}
