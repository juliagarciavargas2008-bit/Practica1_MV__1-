using UnityEngine;
using UnityEngine.UIElements;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private float frecuencia;
    private float positionx;
    private float positiony;
    [SerializeField]
    private float rango = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        frecuencia = Random.Range(-3f, 3f);
        positionx = transform.position.x;
        
    }

    // Update is called once per frame
    void Update()
    {
        positiony = transform.position.y;
        Vector3 dir = new Vector3( positionx + (frecuencia * Mathf.Sin(rango*Time.time)),positiony,0);
        transform.position = dir;
    }
}
