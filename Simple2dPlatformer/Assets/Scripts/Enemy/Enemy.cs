using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Enemy : MonoBehaviour
{
    [HideInInspector] private SpriteRenderer _enemySprite;
    
    [SerializeField] private Vector3[] _wayPoints;
    [SerializeField] private float _speed;

    private int _targetPosition;

    private void Start()
    {
        _enemySprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _wayPoints[_targetPosition], _speed * Time.deltaTime);
        
        if (transform.position == _wayPoints[_targetPosition])
        {
            _enemySprite.flipX = false;
            _targetPosition++;

            if (_targetPosition >= _wayPoints.Length)
            {
                _targetPosition = 0;
                _enemySprite.flipX = true;
            }
        }
    }
}