using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]
public class MovementPlayer : MonoBehaviour
{
    [HideInInspector] private SpriteRenderer _spritePlayer;
    [HideInInspector] private Animator _animatorPlayer;

    [SerializeField] private float _speed;
    [SerializeField] private int _forceJump;

    private float _horizontal;

    private void Awake()
    {
        _spritePlayer = GetComponent<SpriteRenderer>();
        _animatorPlayer = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        MoveHorizontal();
        Jumping();
    }

    private void MoveHorizontal()
    {
        _horizontal = Input.GetAxisRaw("Horizontal") * -1;

        if (_horizontal != 0)
        {
            _spritePlayer.flipX = _horizontal > 0;
            _animatorPlayer.SetBool("isRun", true);
            transform.Translate(_speed * Time.deltaTime * _horizontal, 0, 0);
        }
        else
        {
            _animatorPlayer.SetBool("isRun", false);
        }
    }

    private void Jumping()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            RaycastHit2D checkingGround = Physics2D.Raycast(transform.position, Vector2.down * .01f);

            if (checkingGround)
            {
                transform.Translate(0, _forceJump * Time.deltaTime, 0);
            }
        }
    }
}