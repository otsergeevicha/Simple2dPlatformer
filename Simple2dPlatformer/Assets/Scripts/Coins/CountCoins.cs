using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class CountCoins : MonoBehaviour
{
    [SerializeField] private Player _player;

    private Text _countCoins;
    private int _walletCoins = 0;
    private int _coinNominal = 1;

    private void Awake()
    {
        _countCoins = GetComponent<Text>();
    }

    private void OnEnable()
    {
        _player.Penetration += CollectCoins;
    }

    private void OnDisable()
    {
        _player.Leaving -= CollectCoins;
    }

    private void CollectCoins()
    {
        _walletCoins += _coinNominal;
        _countCoins.text = _walletCoins.ToString();
    }
}
