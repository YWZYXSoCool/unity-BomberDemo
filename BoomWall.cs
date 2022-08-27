using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BoomWall : MonoBehaviour
{
    public float t = 0;

    private void Update() {
        t += Time.deltaTime;

        if (t>0.5f)
        {
            Destroy(gameObject);
        }
    }
}
