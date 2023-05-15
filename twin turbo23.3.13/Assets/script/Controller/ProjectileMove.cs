using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ProjectileMove : MonoBehaviour
{

    public enum PROJECTILETYPE
    {
        PLAYER,
        ENEMY
    }
    public Vector3 launchDirection;

    public PROJECTILETYPE ProjectileType = PROJECTILETYPE.PLAYER;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Monster")
        {
            collision.gameObject.gameObject.GetComponent<MonsterController>().Damaged(1);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "wall")
        {
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Monster"&& ProjectileType ==PROJECTILETYPE.PLAYER)

        {
            other.gameObject.gameObject.GetComponent<MonsterController>().Damaged(1);
            other.transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1);
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "player" && ProjectileType == PROJECTILETYPE.ENEMY)
        {
            other.gameObject.gameObject.GetComponent<PlayerController>().Damaged(1);
            Destroy(this.gameObject);
        }
    }

    private void FixedUpdate()
    {
        float moveAmount = 3 * Time.fixedDeltaTime;

        transform.Translate(launchDirection * moveAmount);
    }
}
