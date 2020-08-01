using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Events;

public class EnemiesContainer : MonoBehaviour
{
    [SerializeField] private List<Enemy> _enemies;
    public event UnityAction EnemiesEnded;

    private void OnEnable()
    {
        foreach (Enemy enemy in _enemies)
        {
            enemy.Killed += OnEnemyKilled;
        }
    }

    private void OnDisable()
    {
        foreach (Enemy enemy in _enemies)
        {
            enemy.Killed -= OnEnemyKilled;
        }
    }

    private void OnEnemyKilled(Enemy killedEnemy)
    {
        _enemies.Remove(killedEnemy);

        if (_enemies.Count == 0)
        {
            EnemiesEnded?.Invoke();
        }
    }
}
