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
    private bool conBool; // Use to see if star was clicked on 3 times
    private int checkCount;
    public Star emptyStar;
    private bool enumeratorTriggered;
    private float _timer = 0f;

    private List<Star> constellationCheck = new List<Star>();

    // Start is called before the first frame update
    void Start()
    {
        global = GlobalController.instance;
        conBool = false;
        enumeratorTriggered = false;
    }

    // Update is called once per frame
    private void Update()
    {
        checkCount = 0;
        ConstellationCheck();

        if(enumeratorTriggered == true)
        {
            TimerTrigger();
            DoubleDeleting(); 
        }
    }

    IEnumerator TimerTrigger()
    {
        _timer = _timer + 0.01f;
        yield return new WaitUntil(() => _timer > 3.0);
    }

    public void DoubleDeleting()
    {
        Debug.Log("Double Deleting");
        foreach (LineRendererScript lineRenderer in global.lineRendererList.ToList())
        {
            Destroy(lineRenderer.gameObject);
        }
        enumeratorTriggered = false;
        _timer = 0f; 
    }


    public void ConstellationCheck()
    {
        foreach (Star star in global.constellationBeingBuilt.ToList())
        {
            constellationCheck.Add(star);
            checkCount += 1; 
        }
        if(checkCount < 5)
        {
            return;
        }
        else
        {
            Debug.Log("Too many Stars!");
            global.enumeratorCheckBad = 1; // Delete half or finished Constellation 
            StartCoroutine(constellationClearBad());
        }
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
        conBool = false; 
        ConstellationBuilding();
        foreach (Star star in global.constellationBeingBuilt)
        {
            global.constellationStarCount += 1;
        }

        // Using this to check for duplicates
        int _tempCount = 0;
        Star _temp1 = emptyStar;
        Star _temp2 = emptyStar;
        Star _temp3 = emptyStar;
        Star _temp4 = emptyStar;
        Star _temp5 = emptyStar; 

        foreach (Star star in global.constellationBeingBuilt)
        {
            if(_tempCount == 0)
            {
                _temp1 = star;
            }
            if (_tempCount == 1)
            {
                _temp2 = star;
            }
            if (_tempCount == 2)
            {
                _temp3 = star;
            }
            if (_tempCount == 3)
            {
                _temp4 = star;
            }
            if (_tempCount == 4)
            {
                _temp5 = star;
            }
            _tempCount++;
            if (_temp1 == _temp2)
            {
                if(_temp1 != emptyStar)
                {
                    if (_temp2 != emptyStar)
                    {
                        if(_temp1 == _temp2)
                        {
                            Debug.Log("Duplicates in Constellation!");
                            conBool = true;
                        }
                        else
                        {
                            conBool = false; 
                        }
                    }
                }
            }
            if (_temp1 == _temp3)
            {
                if (_temp1 != emptyStar)
                {
                    if (_temp3 != emptyStar)
                    {
                        if (_temp1 == _temp3)
                        {
                            Debug.Log("Duplicates in Constellation!");
                            conBool = true;
                        }
                        else
                        {
                            conBool = false;
                        }
                    }
                }
            }
            if (_temp1 == _temp4)
            {
                if (_temp1 != emptyStar)
                {
                    if (_temp4 != emptyStar)
                    {
                        if (_temp1 == _temp4)
                        {
                            Debug.Log("Duplicates in Constellation!");
                            conBool = true;
                        }
                        else
                        {
                            conBool = false;
                        }
                    }
                }
            }
            if (_temp1 == _temp5)
            {
                if (_temp1 != emptyStar)
                {
                    if (_temp5 != emptyStar)
                    {
                        if (_temp1 == _temp5)
                        {
                            Debug.Log("Duplicates in Constellation!");
                            conBool = true;
                        }
                        else
                        {
                            conBool = false;
                        }
                    }
                }
            }
            if (_temp2 == _temp3)
            {
                if (_temp2 != emptyStar)
                {
                    if (_temp3 != emptyStar)
                    {
                        if (_temp2 == _temp3)
                        {
                            Debug.Log("Duplicates in Constellation!");
                            conBool = true;
                        }
                        else
                        {
                            conBool = false;
                        }
                    }
                }
            }
            if (_temp2 == _temp4)
            {
                if (_temp2 != emptyStar)
                {
                    if (_temp4 != emptyStar)
                    {
                        if (_temp2 == _temp4)
                        {
                            Debug.Log("Duplicates in Constellation!");
                            conBool = true;
                        }
                        else
                        {
                            conBool = false;
                        }
                    }
                }
            }
            if (_temp2 == _temp5)
            {
                if (_temp2 != emptyStar)
                {
                    if (_temp5 != emptyStar)
                    {
                        if (_temp2 == _temp5)
                        {
                            Debug.Log("Duplicates in Constellation!");
                            conBool = true;
                        }
                        else
                        {
                            conBool = false;
                        }
                    }
                }
            }
            if (_temp3 == _temp4)
            {
                if (_temp3 != emptyStar)
                {
                    if (_temp4 != emptyStar)
                    {
                        if (_temp3 == _temp4)
                        {
                            Debug.Log("Duplicates in Constellation!");
                            conBool = true;
                        }
                        else
                        {
                            conBool = false;
                        }
                    }
                }
            }
            if (_temp3 == _temp5)
            {
                if (_temp3 != emptyStar)
                {
                    if (_temp5 != emptyStar)
                    {
                        if (_temp3 == _temp5)
                        {
                            Debug.Log("Duplicates in Constellation!");
                            conBool = true;
                        }
                        else
                        {
                            conBool = false;
                        }
                    }
                }
            }
            if (_temp4 == _temp5)
            {
                if (_temp4 != emptyStar)
                {
                    if (_temp5 != emptyStar)
                    {
                        if (_temp4 == _temp5)
                        {
                            Debug.Log("Duplicates in Constellation!");
                            conBool = true;
                        }
                        else
                        {
                            conBool = false;
                        }
                    }
                }
            }

        }

        Debug.Log("Hey here's ConBool: " + conBool); 

        if (conBool == true)
        {
            global.enumeratorCheckBad = 1; // Delete Constellation  
            StartCoroutine(constellationClearBad());
        }

        if ((global.constellationStarCount >= 3) & (conBool == false))
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
        enumeratorTriggered = true;
        conBool = false;
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
        conBool = false;
        global.enumeratorCheckGood = 0;
        yield return new WaitUntil(() => global.enumeratorCheckGood == 0);
    }
}
