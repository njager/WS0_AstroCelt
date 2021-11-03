using System.Collections;
using System.Collections.Generic;
using System.Linq; 
using UnityEngine;

[System.Serializable]
public class EnemyStats
{
    public int vitality;
    public int damage;
    public float speed; 
    public bool weaknessActivated;
    public string identifier; 
    public IEnumerable<int> squares = Enumerable.Range(35, 50);
}
