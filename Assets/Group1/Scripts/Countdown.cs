using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class Countdown : MonoBehaviour
{
    public void Launch(float duration, UnityAction onEnd)
    {
        StartCoroutine(Run(duration, onEnd));
    }

    private IEnumerator Run(float duration, UnityAction onEnd)
    {
        while (duration > 0)
        {
            duration -= Time.deltaTime;

            yield return null;
        }

        onEnd?.Invoke();
        Destroy(gameObject);
    }
}
