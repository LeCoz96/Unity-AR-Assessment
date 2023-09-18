using UnityEngine;

public class StartGameManager : MonoBehaviour
{
    [SerializeField] private GameObject _targetObject;

    public void StarGame()
    {
        _targetObject.SetActive(true);
        gameObject.SetActive(false);
    }
}
