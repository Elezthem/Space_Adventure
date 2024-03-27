using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour
{
    public bool rateGameOnExit;

    public RateGame rateGame;

    private bool windowOpened;
    public GameObject panel_loading;

    void Update()
    {
        
    }

    public void Exit()
    {
        panel_loading.SetActive(true);
        SceneManager.LoadSceneAsync(0 , LoadSceneMode.Single);
    }

    // Used to set the windowOpened value if other window is opened.
    public void WindowOpened(bool opened)
    {
        windowOpened = opened;
    }
}
