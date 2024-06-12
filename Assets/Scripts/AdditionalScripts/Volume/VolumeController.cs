using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VolumeController : MonoBehaviour
{
    [SerializeField] private UIVolumeSlider _uiVolumeSlider;
    [SerializeField] private List<AudioHandler> _audioHandlers;


private void Awake()
    {
        if (_uiVolumeSlider == null)
            throw new NullReferenceException("Volume slider is not found");
    }

    private void OnEnable()
    {
        _uiVolumeSlider.OnVolumeChangeEvent += ChangeVolume;
    }

    private void OnDisable()
    {
        _uiVolumeSlider.OnVolumeChangeEvent -= ChangeVolume;
    }

    private void ChangeVolume(float value)
    {
        foreach (AudioHandler audioHandler in _audioHandlers)
        {
            audioHandler.ChangeVolume(value);
        }
    }
}
