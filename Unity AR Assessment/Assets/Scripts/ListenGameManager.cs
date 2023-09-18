using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.EventSystems;

public class ListenGameManager : MonoBehaviour
{
    [Header("Text Information")]
    [SerializeField] private TextMeshProUGUI _listenNumber;
    [SerializeField] private TextMeshProUGUI _listenText;
    [SerializeField] private string _listenMessage;

    [Header("Scriptable Object Information")]
    [SerializeField] private GameManagerSO _gameManager;

    [Header("Timer Information")]
    [SerializeField] private float _pauseTime;

    [Header("Next Game Information")]
    [SerializeField] private GameObject _targetObject;

    [Header("Audio Manager Information")]
    [SerializeField] private AudioManager _audioManager;

    private void OnEnable()
    {
        _gameManager.NextNumber();

        _listenNumber.text = _gameManager.GetCurrentNumber().Number.ToString();

        _listenText.text = _listenMessage;

        StartCoroutine(Introduction(_pauseTime));
    }

    private IEnumerator Introduction(float value)
    {
        _audioManager.PlayerEffect(_gameManager.GetCurrentNumber().IntroductionAudioClip);

        yield return new WaitForSeconds(_gameManager.GetCurrentNumber().IntroductionAudioClip.length);

        yield return new WaitForSeconds(value);

        StartCoroutine(Count(value));
    }

    private IEnumerator Count(float value)
    {
        _audioManager.PlayerEffect(_gameManager.GetCurrentNumber().CountingAudioClip);

        yield return new WaitForSeconds(_gameManager.GetCurrentNumber().CountingAudioClip.length);

        yield return new WaitForSeconds(value);

        StartCoroutine(WellDone(value));
    }

    private IEnumerator WellDone(float value)
    {
        _audioManager.PlayWellDone();

        yield return new WaitForSeconds(_gameManager.GetCurrentNumber().CountingAudioClip.length);

        yield return new WaitForSeconds(value);

        
    }


}
