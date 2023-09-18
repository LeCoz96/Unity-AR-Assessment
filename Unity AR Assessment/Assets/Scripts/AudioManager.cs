using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource _backgroundAudio, _effectsAudio;

    public void PlayerEffect(AudioClip Clip)
    {
        _effectsAudio.PlayOneShot(Clip);
    }
}
