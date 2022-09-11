using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private EnemyRebirthPoint _enemies;
    [SerializeField] private CoinRebirthPoint _coins;

    private void Awake()
    {
        Instantiate(_enemies, new Vector3(0, 0, 0), quaternion.identity);
        Instantiate(_coins, new Vector3(0, 0, 0), quaternion.identity);
    }
}
