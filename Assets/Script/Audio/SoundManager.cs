using UnityEngine;
using UnityEngine.InputSystem;

public class SoundManager : MonoBehaviour
{
    AudioSource m_MyAudioSource;

    void Awake()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
        m_MyAudioSource.Stop();
    }

    public void OnPlayMusic(InputValue value)
    {
        m_MyAudioSource.Play();
    }

    public void OnStopMusic(InputValue value)
    {
        m_MyAudioSource.Pause();
    }
}
