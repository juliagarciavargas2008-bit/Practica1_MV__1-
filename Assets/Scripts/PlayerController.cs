using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using Unity.VisualScripting;
using System;

public class PlayerController : MonoBehaviour
{
    private InputAction movimiento;
    private Vector3 direccion;
    private Vector3 posicion;

    [SerializeField]
    private int velocidad = 4;
    
    void Start()
    {
        if (InputSystem.actions.FindAction("Move") != null)
        {
            movimiento = InputSystem.actions.FindAction("Move");
            movimiento.Enable();
        }
    }

    
    void Update()
    {
        direccion = movimiento.ReadValue<Vector2>();
        posicion.x = direccion.x * Time.deltaTime * velocidad;
        if (((transform.position.x > 8) && posicion.x > 0) || ((transform.position.x < -8) && posicion.x < 0))
        {
            posicion = Vector3.zero;
        }
     
            transform.position += posicion;
            
    }
}
