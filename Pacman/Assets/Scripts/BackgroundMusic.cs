using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    [SerializeField] AudioClip backgroundMusic;
    AudioSource backgroundSource;

    void Start()
    {
        PlayBGM();
    }

    void PlayBGM()
    {
        backgroundSource = FindObjectOfType<AudioSource>();
        backgroundSource.clip = backgroundMusic;
        backgroundSource.loop = true;
        backgroundSource.Play();
    }
}
