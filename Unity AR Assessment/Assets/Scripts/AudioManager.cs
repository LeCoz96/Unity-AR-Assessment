using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource _backgroundAudio, _effectsAudio;
    [SerializeField] private AudioClip _wellDone;

    public void PlayerEffect(AudioClip Clip)
    {
        _effectsAudio.PlayOneShot(Clip);
    }

    public void PlayWellDone()
    {
        _effectsAudio.PlayOneShot(_wellDone);
    }
}
