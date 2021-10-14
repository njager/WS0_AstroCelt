using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI; 

public class ConstellationBuildingScript : MonoBehaviour
{
    [Header("Constellation Variables")]
    private GlobalController global; 

    // Start is called before the first frame update
    void Start()
    {
        global = GlobalController.instance; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ConstellationBuilding()
    {
        foreach (Star star in global.constellationBeingBuilt.ToList())
        {
            if (star.myStarClass.starType == "Star")
            {
                global.constellationPotential += star.myStarClass.constellationValue;

            }
            if (star.myStarClass.starType == "HealthStar")
            {
                global.constellationPotentialHealth += star.myStarClass.constellationValue;
            }
            if (star.myStarClass.starType == "DamageStar")
            {
                global.constellationPotentialDamage += star.myStarClass.constellationValue;
            }
        }
    }

    public void ConstellationBuilt()
    {
        ConstellationBuilding();
        foreach (Star star in global.constellationBeingBuilt)
        {
            global.constellationStarCount += 1;
        }

        if (global.constellationStarCount >= 3)
        {
            Debug.Log("Constellation Building!");
            if (global.constellationPotentialDamage > 0)
            {
                if (global.constellationPotentialHealth > 0)
                {
                    Debug.Log("Can't have both Health and Action Stars. Try again.");
                    global.enumeratorCheckBad = 1; // Make it so the Coroutine doesn't autoreturn
                    StartCoroutine(constellationClearBad());
                }
                else
                {
                    Debug.Log("Constellation Built for Damage!");
                    global.constellationFinalDamage += (global.constellationPotential + global.constellationPotentialDamage);
                    global.currentEnemy.EnemyDamaged(global.constellationFinalHealth);
                    Debug.Log(global.currentEnemy.enemyHealth);
                    global.enumeratorCheckGood = 1; // Make it so the Coroutine doesn't autoreturn
                    StartCoroutine(constellationClearGood());
                }
            }
            if (global.constellationPotentialHealth > 0)
            {
                if (global.constellationPotentialDamage > 0)
                {
                    Debug.Log("Can't have both Health and Action Stars. Try Again.");
                    global.enumeratorCheckBad = 1; // Make it so the Coroutine doesn't autoreturn
                    StartCoroutine(constellationClearBad());
                }
                else
                {
                    Debug.Log("Constellation Built for Health!");
                    global.constellationFinalHealth += (global.constellationPotential + global.constellationPotentialHealth);
                    global.playerScript.PlayerHealed(global.constellationFinalHealth);
                    global.enumeratorCheckGood = 1; // Make it so the Coroutine doesn't autoreturn
                    StartCoroutine(constellationClearGood());
                }
            }

        }
    }
    IEnumerator constellationClearBad()
    {
        Debug.Log("Clearing Constellation");
        foreach (LineRendererScript lineRenderer in global.lineRendererList.ToList())
        {
            Destroy(lineRenderer.gameObject);
        }
        foreach (Star star in global.constellationBeingBuilt.ToList())
        {
            star.starUsed = false;
            global.constellationBeingBuilt.Remove(star);
        }
        global.drawingScript.starCount = 0;
        global.constellationPotentialHealth = 0;
        global.constellationPotentialDamage = 0;
        global.constellationPotential = 0;
        global.constellationFinalDamage = 0;
        global.constellationFinalHealth = 0;
        global.enumeratorCheckBad = 0;
        yield return new WaitUntil(() => global.enumeratorCheckBad == 0);
    }

    IEnumerator constellationClearGood()
    {
        Debug.Log("Clearing Constellation");
        foreach (Star star in global.constellationBeingBuilt.ToList())
        {
            global.constellationFinalStars.Add(star);
            global.constellationBeingBuilt.Remove(star);
        }
        foreach (Star star in global.constellationFinalStars.ToList())
        {
            star.StarUsed();
            global.constellationBeingBuilt.Remove(star);
        }
        global.drawingScript.starCount = 0;
        global.constellationPotentialHealth = 0;
        global.constellationPotentialDamage = 0;
        global.constellationPotential = 0;
        global.constellationFinalDamage = 0;
        global.constellationFinalHealth = 0;
        global.enumeratorCheckGood = 0;
        yield return new WaitUntil(() => global.enumeratorCheckGood == 0);
    }
}
