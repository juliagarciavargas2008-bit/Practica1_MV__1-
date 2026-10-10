using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private InputAction mv;
    private Vector2 dir;
    [SerializeField]
    private int vel = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mv = InputSystem.actions.FindAction("Move");
        if (mv == null)
        {
            Debug.Log("aaaaaaaaaaa");
        }
    }

    // Update is called once per frame
    void Update()
    {
        dir = mv.ReadValue<Vector2>();
        if (dir.x != 0)
        { Debug.Log("zzz"); }    
        Vector2 pos = transform.position;

        pos.x += dir.x * vel * Time.deltaTime;
        transform.position = pos;
    }
}
