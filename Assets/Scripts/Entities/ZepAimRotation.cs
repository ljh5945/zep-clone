using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZepAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;

    private ZepCharacterController _controller;

    private void Awake()
    {
        _controller = GetComponent<ZepCharacterController>();
    }

    void Start()
    {
        _controller.OnLookEvent += OnAim;
    }    

    private void OnAim(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
