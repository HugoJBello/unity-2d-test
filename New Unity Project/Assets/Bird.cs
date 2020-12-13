using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{

    Vector3 _initialPosition;

    private void Awake() {
        _initialPosition = transform.position;
    }

    private void Update() {
        
    }

    private void OnMouseDown() 
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }

    private void OnMouseUp() 
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    private void OnMouseDrag() {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPosition.x, newPosition.y);
    }
}
