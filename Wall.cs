using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("碰撞开始");
        if (other.gameObject.tag == "Boom")
        {
            Destroy(gameObject);
        }
    }
}
