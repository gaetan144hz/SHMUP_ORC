using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Slider volumeSlider;

    public AudioMixer audioMixer;

    private void Start()
    {
        loadSave();
    }
    public void menu()
    {
        float volumeData = volumeSlider.value;
        PlayerPrefs.SetFloat("volumeData", volumeData);

        SceneManager.LoadScene(0); //MenuPrincipal
    }

    public void loadSave()
    {
        float volumeData = PlayerPrefs.GetFloat("volumeData");
        volumeSlider.value = volumeData;
        audioMixer.SetFloat("volume", volumeData);
    }
}
