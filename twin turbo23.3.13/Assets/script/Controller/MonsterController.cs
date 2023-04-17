using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
   public int Monster_HP = 5;

    public void Damaged(int Damage)
    {
        Monster_HP -= Damage;

        if (Monster_HP < 0)
        {
            Destroy(this.gameObject);
        }
    }
}
