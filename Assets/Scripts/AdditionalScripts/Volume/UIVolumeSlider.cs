using System;
using System.Collections;
using UnityEngine;


public class UIVolumeSlider : MonoBehaviour
{
	public event Action<float> OnVolumeChangeEvent;

	[SerializeField] private tk2dUIScrollbar _slider;

	private float _curentValue;
	
	private void OnEnable()
	{
		StartCoroutine(ChangeSliderCoroutine());
	}


	private IEnumerator ChangeSliderCoroutine()
	{
		for (; _slider.gameObject.activeSelf;)
		{
			if (_slider.Value != _curentValue)
			{
				_curentValue = _slider.Value;
				OnVolumeChangeEvent.Invoke(_curentValue);
			}
			
			yield return 0;
		}
	}
}