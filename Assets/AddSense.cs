using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSense : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        Score.score++;
    }
}
