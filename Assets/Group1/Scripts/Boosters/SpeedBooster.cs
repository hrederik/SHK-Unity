using UnityEngine;

public class SpeedBooster : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Countdown _countdown;
    [SerializeField] private float _duration;
    [SerializeField] private float _boostSpeed;

    public void OnCollected()
    {
        CreateCountdown();
        _player.SetSpeed(_boostSpeed);

        Destroy(gameObject);
    }

    private void CreateCountdown()
    {
        Countdown countdown = Instantiate(_countdown);
        countdown.Launch(_duration, _player.ResetSpeed);
    }
}
