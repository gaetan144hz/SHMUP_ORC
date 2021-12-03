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

    public void play(InputAction.CallbackContext ctx)
    {
        m_MyAudioSource.Play();
    }

    public void stop(InputAction.CallbackContext ctx)
    {
        m_MyAudioSource.Stop();
    }
}
