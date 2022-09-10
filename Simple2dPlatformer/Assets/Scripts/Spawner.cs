using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemies _enemy;
    [SerializeField] private SpawnCoins _coin;

    private void Awake()
    {
        Instantiate(_enemy, new Vector3(0, 0, 0), quaternion.identity);
        Instantiate(_coin, new Vector3(0, 0, 0), quaternion.identity);
    }
}
