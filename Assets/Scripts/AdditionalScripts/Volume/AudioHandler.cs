using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    [SerializeField] private List<tk2dButton> _startPlayButton;
    [SerializeField] private List<tk2dButton> _stopPlayButton;
    
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();

        if (_audioSource == null)
            throw new NullReferenceException("AudioSource component is not found");
    }

    private void OnEnable()
    {
        foreach (tk2dButton button in _startPlayButton)
        {
            button.ButtonPressedEvent += StartPlaying;
        }

        foreach (tk2dButton button in _stopPlayButton)
        {
            button.ButtonPressedEvent += StopPlaying;
        }
        
    }

    private void OnDisable()
    {
        foreach (tk2dButton button in _startPlayButton)
        {
            button.ButtonPressedEvent -= StartPlaying;
        }

        foreach (tk2dButton button in _stopPlayButton)
        {
            button.ButtonPressedEvent -= StopPlaying;
        }
    }

    public void ChangeVolume(float value)
    {
        _audioSource.volume = value;
    }

    private void StartPlaying(tk2dButton source)
    {
        _audioSource.Play();
    }

    private void StopPlaying(tk2dButton source)
    {
        _audioSource.Pause();
    }
}
