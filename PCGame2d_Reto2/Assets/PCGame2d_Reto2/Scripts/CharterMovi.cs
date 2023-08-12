using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CharterMovi : MonoBehaviour
{
    public float playerSpeed;
    public float forceJump;
    public LayerMask layerFloor;
    public Lives livesObject;
    public AutoMoveCharacter AutoMoveCharacter;
    public AutoMoveCharacter AutoMoveCharacter2;

    private GameObject panelToShow;

    private Rigidbody2D rigidBody;
    private CapsuleCollider2D capsuleCollider;

    private Animator animator;


    private bool islookRight = true;
    private float InputMove;
    float lastJumpTime = 0.2f;
    float jumpCooldown = 0.6f;

    public static bool keyTouchBox = false;


    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        capsuleCollider = GetComponent<CapsuleCollider2D>();
        animator = GetComponentInChildren<Animator>();
        livesObject.GetComponent<Lives>().StarLives(10);

        panelToShow = GameObject.Find("---Canvas---/Canvas/PanelGameOver");
        panelToShow.SetActive(false); // panel game over oculto al inicio
       

    }

  

    void Update()
    {
        Movement();
        Jump();
        KeyTouchBox();
        AutoMoveCharacter.MoveCharacterAutomatically();
        AutoMoveCharacter2.MoveCharacterAutomatically();
    }


    void Jump()
    {

        if (Time.time - lastJumpTime >= jumpCooldown)
        {
            if ( Input.GetKeyDown(KeyCode.Space) ||  Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) )
            {
                animator.SetTrigger("jumpTrigger");
                lastJumpTime = Time.time;
                rigidBody.AddForce(Vector2.up * forceJump, ForceMode2D.Impulse);
            }
        }

    }



    void Movement()
    {
        InputMove = Input.GetAxis("Horizontal"); // Actualizar el valor del input horizontal
        rigidBody.velocity = new Vector2(InputMove * playerSpeed, rigidBody.velocity.y);
 
        // Llamada al método para cambiar la orientación
        Orientation(InputMove);

        //si no se mueve jugador
        if (InputMove != 0)
        {
            animator.SetBool("isRunning", true);   
        }
        else
        {
             animator.SetBool("isRunning", false);
        }
    }

    void Orientation(float InputMove)
    {
        // Si personaje mira hacia la derecha y el jugador pulsa hacia la izquierda,
        // o si el personaje mira hacia la izquierda y el jugador pulsa hacia la derecha
        if ((islookRight == true && InputMove < 0) || (islookRight == false && InputMove > 0))
        {
            islookRight = !islookRight;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }

    public void painPlayer()
    {
        
            animator.SetTrigger("damagerTrigger");   
           
    }


    public void KeyTouchBox()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            keyTouchBox = true;
        }
    }

    public void GameOver()
    {
        animator.SetBool("IsDead", true);
        Debug.Log("player Dead");

        // Verificar si una animación está reproduciéndose
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

           if (!panelToShow.activeSelf)
           {
                panelToShow.SetActive(true);
                Time.timeScale = 0f;
           }
        
    }
}

