using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject title;
    private void Start()
    {
        //LeanTween.scale(title, new Vector3(1, 1, 1), 1).setEase(LeanTweenType.easeInExpo).setDelay(1);
        LeanTween.scale(title, new Vector3(1, 1, 1), 0.5f).setLoopType(LeanTweenType.pingPong).setDelay(1);
    }

    public void Play(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
}
