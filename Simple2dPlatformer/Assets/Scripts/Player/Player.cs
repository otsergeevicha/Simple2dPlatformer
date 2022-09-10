using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public event Action Penetration;
    public event Action Leaving;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Penetration?.Invoke();
            Leaving?.Invoke();
            Destroy(collision.gameObject);
            
        }
    }
}