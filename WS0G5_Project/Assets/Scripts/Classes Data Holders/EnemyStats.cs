using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyStats
{
    public int vitality;
    public int damage;
    public bool weaknessActivated;

    public static int enemyCount; // Track what enemy in the round we are on
}
