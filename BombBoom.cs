using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BombBoom : MonoBehaviour
{
    public float t = 0;

    private void Start() {
        transform.GetChild(0).gameObject.SetActive(false);
    }

    private void Update() {
        t += Time.deltaTime;

        if (t>3)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(0).parent = null;
            Destroy(gameObject);
        }
    }
}
