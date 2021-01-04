using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragArea : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("entered");
    }
    private void OnTriggerStay2D(Collider2D other) {
                Debug.Log("staid");

    }
}
