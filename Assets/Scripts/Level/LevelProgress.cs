using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using IJunior.TypedScenes;
using DG.Tweening;

public class LevelProgress : MonoBehaviour
{
    [SerializeField] private float _filledDuration;
   [SerializeField] private Slider _slider;
   [SerializeField] private Tower _tower;
   [SerializeField] private TowerBilld _billder;

    private float _startTowerSize;

    private void Awake()
    {
        _startTowerSize = _billder.GetTowerSize();
        _slider.value = 0; 
    }

    private void OnEnable()
    {
        _tower.SizeUpdated += OnTowerSizeUpdated;
    }

    private void OnDisable()
    {
        _tower.SizeUpdated -= OnTowerSizeUpdated;
    }

    private void OnTowerSizeUpdated(int size)
    {
        if (size != _startTowerSize)
        {
            _slider.DOValue((_startTowerSize - size) / _startTowerSize, _filledDuration);
        }
    }
}
