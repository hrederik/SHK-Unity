using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController controller;

    public GameObject go;
    public GameObject a;
    public GameObject[] B;

    private void Start()
    {
        controller = this;
    }

    private void Update()
    {
    }

    public void End()
    {
        go.SetActive(true);
    }
}
