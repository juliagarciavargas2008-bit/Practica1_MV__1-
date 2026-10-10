using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using Unity.VisualScripting;
using System;

public class PlayerControlerj : MonoBehaviour
{
    private InputAction movimiento;
    private Vector3 direccion;
    private Vector3 posicion;

    [SerializeField]
    private int velocidad = 4;
    
    void Start()
    {
        movimiento= InputSystem.actions.FindAction("Move");
        movimiento.Enable();
    }

    
    void Update()
    {
        direccion = movimiento.ReadValue<Vector2>();
        Debug.Log(direccion);
        posicion.x = direccion.x * Time.deltaTime * velocidad;
        Debug.Log (posicion.x);
        if ((!(transform.position.x < 8) && posicion.x > 0) || (!(transform.position.x > -8) && posicion.x < 0))
        {
            posicion = Vector3.zero;
        }
     
            transform.position += posicion;
            
    }
}
