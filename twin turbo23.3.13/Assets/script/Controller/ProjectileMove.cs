using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public Vector3 launchDirection;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "wall")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.name == "Monster")
        {
            collision.gameObject.gameObject.GetComponent<MonsterController>().Damaged(1);
            Destroy(this.gameObject);
        }
    }

    private void FixedUpdate()
    {
        float moveAmount = 3 * Time.fixedDeltaTime;

        transform.Translate(launchDirection * moveAmount);
    }
}
