using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Works only with CapsuleCollider
public class CharacterMovementController : MonoBehaviour
{
    //INPUTS

    public bool updateHead = true;

    //PHYSICS

    public float moveSpeed = 5;
    public float airMoveDrag = 0.4f;
    public float lookSpeed = 5;
    public float lookSmooth = 4;
    public float jumpHeight = 3;
    public float gravityMultiplayer = 2;
    public int groundedCheckTime = 5; //How much delay should we make before grounded check.
    public float groundMaxRadius = 0.05f;
    public LayerMask layers;
    public Transform headTransform;

    public PhysicMaterial noFrictionMaterial;
    public PhysicMaterial maxFrictionMaterial;

    private Rigidbody _rigidbody;
    private Transform _transform;
    private CapsuleCollider _collider;
    private int _groundedCheckTimer;
    private bool _isGrounded;
    private bool _jumpPressed;
    private float _rotX;
    private Quaternion _rotY;
    private Vector3 _velocity;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _collider = GetComponent<CapsuleCollider>();
        _transform = transform;
    }

    private void Start()
    {
        if (layers == 0)
        {
            layers = LayerMask.GetMask("Default");
        }

        _rotY = Quaternion.identity;
        if (updateHead && !headTransform)
        {
            LogWarn("There is no 'headTransform' assigned, but 'updateHead' is checked.");
        }
    }

    public void UpdateMovement(Vector2 lookInput, Vector2 moveInput, float jump, float deltaTime)
    {
        Look(lookInput, deltaTime);
        Move(moveInput, deltaTime);
        Jump(jump, deltaTime);

        if (_groundedCheckTimer == groundedCheckTime)
        {
            _groundedCheckTimer = 0;
            CheckGround();
        }
        _groundedCheckTimer++;
    }

    private void Look(Vector2 lookInput, float deltaTime)
    {
        if (updateHead)
        {
            _rotX = Mathf.Clamp(lookInput.y * lookSpeed + _rotX, -89, 89);
            headTransform.localRotation =
                Quaternion.Slerp(headTransform.localRotation,
                    Quaternion.Euler(_rotX, 0, 0), deltaTime * lookSmooth);
        }

        _rotY *= Quaternion.Euler(0, lookInput.x * lookSpeed, 0);
        _transform.localRotation = Quaternion.Slerp(_transform.localRotation, _rotY, lookSmooth * deltaTime);
    }

    private void Move(Vector2 moveInput, float deltaTime)
    {
        var moveDir = _transform.TransformDirection(new Vector3(moveInput.x, 0, moveInput.y)).normalized * moveSpeed;
        if (!_isGrounded)
        {
            moveDir *= airMoveDrag;
        }

        _velocity.x = moveDir.x;
        _velocity.z = moveDir.z;
    }

    private void Jump(float jump, float deltaTime)
    {
        if (_isGrounded && !_jumpPressed && jump > 0.1f)
        {
            _jumpPressed = true;
            _velocity.y = jumpHeight;
        }

        if (!_isGrounded && _jumpPressed)
        {
            _jumpPressed = false;
        }
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = _velocity;
        if (!_isGrounded)
        {
            _velocity += Physics.gravity * gravityMultiplayer * Time.fixedDeltaTime;
            _collider.material = noFrictionMaterial;
        }
        else if (!_jumpPressed)
        {
            _velocity.y = 0;
            _collider.material = maxFrictionMaterial;
        }
    }

    private void CheckGround()
    {
        Vector3 down;
        if (_collider.direction == 0 || _collider.direction == 2)
        {
            down = Vector3.down * (_collider.radius - groundMaxRadius * 0.5f);
        }
        else
        {
            down = Vector3.down * (_collider.height * 0.5f - groundMaxRadius * 0.5f);
        }

        var hits = Physics.SphereCastAll(transform.position + _collider.center + down, groundMaxRadius, Vector3.down, groundMaxRadius, layers, QueryTriggerInteraction.Ignore);
        _isGrounded = false;

        foreach (var h in hits)
        {
            if (!h.collider.transform.IsChildOf(_transform))
            {
                _isGrounded = true;
                break;
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        var collider = _collider;
        if (!Application.isPlaying)
        {
            collider = GetComponent<CapsuleCollider>();
        }
        Vector3 down;
        if (collider.direction == 0 || collider.direction == 2)
        {
            down = Vector3.down * (collider.radius);
        }
        else
        {
            down = Vector3.down * (collider.height * 0.5f);
        }
        Gizmos.DrawWireSphere(transform.position + collider.center + down, groundMaxRadius);
    }

    private void Log(object message)
    {
        Debug.Log(message, gameObject);
    }

    private void LogWarn(object message)
    {
        Debug.LogWarning(message, gameObject);
    }
}