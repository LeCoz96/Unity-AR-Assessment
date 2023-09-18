using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NumberSO", menuName = "Number")]
public class NumbersSO : ScriptableObject
{
    public int Number;

    public AudioClip IntroductionAudioClip;

    public AudioClip CountingAudioClip;
}
