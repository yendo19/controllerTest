using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class playerMovement : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    Test playerAction;
    Rigidbody2D rigid;
    public Vector2 position;



    public InputAction moveAction;

    private void Awake()
    {
        playerAction = new Test();
        rigid = GetComponent<Rigidbody2D>();
        if(rigid is null)
        {
            Debug.Log("Hah u suck");
        }
    }

    private void Start()
    {
        moveAction.Enable();
    }

    private void OnEnable()
    {
        playerAction.Enable();
    }

    private void OnDisable()
    {
        playerAction.Disable();
    }

    private void FixedUpdate()
    {
        
    }

    private void Update()
    {
        var moveDiection = moveAction.ReadValue<Vector2>();
        position += moveDiection * speed * Time.deltaTime;
        rigid.velocity = position;
    }
}
