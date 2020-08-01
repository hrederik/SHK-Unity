using UnityEngine;

public class UserInterface : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverPanel;

    public void ShowGameOverPanel()
    {
        _gameOverPanel.SetActive(true);
    }
}
