using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

public class NextLevelLoader : MonoBehaviour
{
    [SerializeField] private Tower _tower;
    [SerializeField] private LevelConfiguration _config;

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
        if (size == 0)
        {
            Game.Load(_config);
        }
    }
}

