using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMove : MonoBehaviour
{
    public LayerMask detectLayer;
    public GameObject bomb;

    Vector2 moveDir;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            moveDir = Vector2.right;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            moveDir = Vector2.left;
        if (Input.GetKeyDown(KeyCode.UpArrow))
            moveDir = Vector2.up;
        if (Input.GetKeyDown(KeyCode.DownArrow))
            moveDir = Vector2.down;

        if (moveDir != Vector2.zero)
            if (CanMoveIt(moveDir)) Move(moveDir);

        moveDir = Vector2.zero;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var newBomb = Instantiate(bomb,transform.position,Quaternion.identity);
        }
    }

    bool CanMoveIt(Vector2 dir)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position,dir,1.5f,detectLayer);

        if (!hit)
            return true;
        else
        {
            return false;
        }
    }

    void Move(Vector2 dir)
    {
        transform.Translate(dir);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("碰撞开始");
        if (other.gameObject.tag == "Boom")
        {
            Destroy(gameObject);
        }
    }
}
