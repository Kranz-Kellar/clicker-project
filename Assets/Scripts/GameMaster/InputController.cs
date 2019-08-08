using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MouseRaycast();
        }
    }

    void MouseRaycast()
    {
        var mousePosition = Input.mousePosition;
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.transform.position, -Vector2.up);
        Debug.DrawRay(Camera.main.transform.position, Vector3.forward, Color.green, 2);

        if (hit.collider != null)
        {
            var enemyInteface = GetEnemyFromCollider(hit);
            SendMessage("EnemyClicked", enemyInteface);
        }
    }

     private EnemyBehaviour GetEnemyFromCollider(RaycastHit2D hit)
    {
        EnemyBehaviour enemyInteface = hit.collider.GetComponent<EnemyBehaviour>();
        return enemyInteface;
    }
}
