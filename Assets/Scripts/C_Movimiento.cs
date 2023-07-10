using UnityEngine;

public class C_Movimiento : IComando
{
    private bool _HaciaFrente = true;
    private float directionX = 0f;
    [SerializeField] private float moveSpeed = 7f;
    private float jumpForce = 14f;
    private enum MovementState { PlayerIdle, PlayerRun, PlayerJump, PlayerAttack, PlayerDamage, PlayerFall }
    private SpriteRenderer sprite;
    private bool isJumping = false;
    private Animator animator;

    public void Ejecutar(GameObject pActor)
    {
        directionX = Input.GetAxisRaw("Horizontal");

        // Obtenemos la referencia al SpriteRenderer y Animator en el GameObject
        sprite = pActor.GetComponent<SpriteRenderer>();
        animator = pActor.GetComponent<Animator>();

        if (GroundCheck.IsGrounded && Input.GetButtonDown("Jump"))
        {
            pActor.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = true;
        }

        if (GroundCheck.IsGrounded)
        {
            isJumping = false;
        }

        pActor.GetComponent<Rigidbody2D>().velocity = new Vector2(directionX * moveSpeed, pActor.GetComponent<Rigidbody2D>().velocity.y);

        UpdateAnimation();
    }

    private void UpdateAnimation()
    {
        MovementState state;

        if (GroundCheck.IsGrounded ==false)
        {
            
            state = MovementState.PlayerJump;
            
           
        }
        else if (directionX != 0f && GroundCheck.IsGrounded)
        {
            state = MovementState.PlayerRun;
            sprite.flipX = (directionX < 0f);
        }
        else
        {
            state = MovementState.PlayerIdle;
        }

        animator.SetInteger("State", (int)state);
    }
}

