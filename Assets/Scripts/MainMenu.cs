using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private Button newGameButton { get; set; }
    private Button newGamePlusButton { get; set; }
    private Button quitButton { get; set; }

    public void Start()
    {
        newGameButton = GameObject.Find("NewGameButton").GetComponent<Button>();
        newGamePlusButton = GameObject.Find("NewGamePlusButton").GetComponent<Button>();
        quitButton = GameObject.Find("QuitButton").GetComponent<Button>();

        newGameButton.onClick.AddListener(() => SceneManager.LoadScene("Game"));
        newGameButton.onClick.AddListener(() => GameController.isVariantGameMode = false);
        newGamePlusButton.onClick.AddListener(() => SceneManager.LoadScene("Game"));
        newGamePlusButton.onClick.AddListener(() => GameController.isVariantGameMode = true);
        quitButton.onClick.AddListener(() => Application.Quit());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
