using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MenuButtonController : MonoBehaviour
{
    [SerializeField] AudioMixer audioVolume;
    public void SoundVolume(float volume)
    {
        audioVolume.SetFloat("MasterVolume", Mathf.Log10(volume) * 20);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
