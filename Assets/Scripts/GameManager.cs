using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject menu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && menu)
        {
            menu.SetActive(!menu.activeSelf);

            if (menu.activeSelf)
                AudioManager.Instance.OpenMenu();
            else
               AudioManager.Instance.CloseMenu();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            AudioManager.Instance.CloseMenu();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
