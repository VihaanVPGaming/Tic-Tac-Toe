using UnityEngine;
using UnityEngine.UI;

public class CloseGameOnClick : MonoBehaviour
{
    void Start()
    {
        Button ExitButton = GetComponent<Button>();
        ExitButton.onClick.AddListener(CloseGame);
    }

    void CloseGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}