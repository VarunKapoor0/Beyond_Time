using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject mainMenuCanvas;
    public GameObject levelsCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayOnClick()
    {
        mainMenuCanvas.SetActive(false);
        levelsCanvas.SetActive(true);
    }
    public void BackButton()
    {
        mainMenuCanvas.SetActive(true);
        levelsCanvas.SetActive(false);
    }

    public void ExitOnClick()
    {
        Debug.Log("Game exited. ");
        //Application.Quit();
    }

    public void TutorialObstacleOnClick()
    {
        SceneManager.LoadScene(1);
    }

    public void TutorialBounceOnClick()
    {
        SceneManager.LoadScene(2);
    }
    public void TutorialEnemyOnClick()
    {
        SceneManager.LoadScene(3);
    }

    public void Level1OnClick()
    {
        SceneManager.LoadScene(4);
    }
    public void Level2OnClick()
    {
        SceneManager.LoadScene(5);
    }
    public void Level3OnClick()
    {
        SceneManager.LoadScene(6);
    }
    public void Level4OnClick()
    {
        SceneManager.LoadScene(7);
    }


}
