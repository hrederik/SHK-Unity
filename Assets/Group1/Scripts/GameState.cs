using UnityEngine;

public class GameState : MonoBehaviour
{
    [SerializeField] private EnemiesContainer _enemiesContainer;
    [SerializeField] private UserInterface _userInterface;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _enemiesContainer.EnemiesEnded += OnEnemiesEnded;
    }

    private void OnDisable()
    {
        _enemiesContainer.EnemiesEnded -= OnEnemiesEnded;
    }

    private void OnEnemiesEnded()
    {
        _userInterface.ShowGameOverPanel();
        _player.Stop();
    }
}
