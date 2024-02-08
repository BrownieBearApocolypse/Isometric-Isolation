using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public Canvas MainCanvas;
    public Canvas Howto;

    private void Awake()
    {
        Howto.enabled = false;
    }
    
    public void HowtoON()
    {
        Howto.enabled = true;
        MainCanvas.enabled = false;
    }

    public void ReturnOn()
    {
        Howto.enabled = false;
        MainCanvas.enabled = true;
    }

    public void LoadOn()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }


}


