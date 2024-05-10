using System;
using System.Diagnostics;
using System.Linq;
using UnityEngine;

using Debug = UnityEngine.Debug;

// TopDownMovement�� ĳ���Ϳ� ������ �̵��� ���� �����Դϴ�.
public class TopDownMovement : MonoBehaviour
{
    private TopDownController movementController;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;
    private Vector2 mouseDirection = Vector2.zero;
    private Animator animator;

    public float movementSpeed = 10f;

    [SerializeField] private SpriteRenderer characterRenderer;

    private void Awake()
    {
        // ���� ���ӿ�����Ʈ�� TopDownController, Rigidbody�� ������ �� 
        movementController = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        // OnMoveEvent�� Move�� ȣ���϶�� �����
        movementController.OnMoveEvent += Move;
        movementController.OnLookEvent += Look;
    }

    private void FixedUpdate()
    {
        // ���� ������Ʈ���� ������ ����
        ApplyMovement(movementDirection);
    }

    private void Move(Vector2 direction)
    {
        // �̵����⸸ ���صΰ� ������ ���������� ����.
        // �����̴� ���� ���� ������Ʈ���� ����(rigidbody�� �����ϱ�)
        movementDirection = direction;
    }

    private void Look(Vector2 direction)
    {
        Rotate(direction);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * movementSpeed;

        movementRigidbody.velocity = direction;
    }

    private void Rotate(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}