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
    private int _tempStarCount = 0; // Use for duplicate of staarting star for value calculation
    // private bool enumeratorTriggered;
    private float _timer = 0f;
    public GameObject startingStarGO; // In-Script reference to global's starting star
    private Star startingStar_Star; 
    public Vector3 startingStarPosition; // 
    public Vector3 offset; 

    private List<Star> constellationCheck = new List<Star>();
    private List<GameObject> lineFinal = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        startingStarGO = emptyStar.gameObject; // Need something to hold data during runtime
        offset = new Vector3(0.5f, 0.5f, 0f); 
        global = GlobalController.instance;
        conBool = false;
        // enumeratorTriggered = false;
    }

    // Update is called once per frame
    private void Update()
    {
        startingStar_Star = global.drawingScript.startingStar;
        startingStarGO = startingStar_Star.gameObject; 
        startingStarPosition = startingStarGO.transform.position; 
        checkCount = 0;
        ConstellationCheck();



        /*
        if(enumeratorTriggered == true)
        {
            TimerTrigger();
            DoubleDeleting(); 
        } */
    }

    IEnumerator TimerTrigger() // Thought I needed to delete twice
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
        // enumeratorTriggered = false;
        _timer = 0f; 
    }


    public void ConstellationCheck()
    {
        foreach (Star star in global.constellationBeingBuilt.ToList())
        {
            constellationCheck.Add(star);
            checkCount += 1; 
        }
        if(checkCount < 6)
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
                if (star == global.drawingScript.startingStar)
                {
                    if(_tempStarCount == 0)
                    {
                        global.constellationPotentialHealth -= 1; 
                    }
                    else
                    {
                        global.constellationPotentialHealth += star.myStarClass.constellationValue;
                    }
                        
                }
                else
                {
                    global.constellationPotentialHealth += star.myStarClass.constellationValue;
                }
                
            }
            if (star.myStarClass.starType == "DamageStar")
            {
                if (star == global.drawingScript.startingStar)
                {
                    if (_tempStarCount == 0)
                    {
                        global.constellationPotentialDamage -= 1;
                    }
                    else
                    {
                        global.constellationPotentialDamage += star.myStarClass.constellationValue;
                    }

                }
                else
                {
                    global.constellationPotentialDamage += star.myStarClass.constellationValue;
                }
            }
        }
    }

    // Using this to check for duplicates in global.constellationBeingBuilt
    public void DuplicateChecker() // Moved to it's own method so it can return out of the structure when True
    {
        int _tempCount = 0;
        Star _temp1 = emptyStar;
        Star _temp2 = emptyStar;
        Star _temp3 = emptyStar;
        Star _temp4 = emptyStar;
        Star _temp5 = emptyStar;
        Star _temp6 = emptyStar;

        foreach (Star star in global.constellationBeingBuilt.ToList())
        {
            if (_tempCount == 0) // Star 1 in list
            {
                _temp1 = star;
            }
            if (_tempCount == 1) // Star 2 in list
            {
                _temp2 = star;
            }
            if (_tempCount == 2) // Star 3 in list 
            {
                _temp3 = star;
            }
            if (_tempCount == 3) // Star 4 in list 
            {
                _temp4 = star;
            }
            if (_tempCount == 4) // Star 5 in list 
            {
                _temp5 = star;
            }
            if (_tempCount == 5) // Star 6 in list 
            {
                _temp6 = star;
            }
            _tempCount++;
            if (_temp1 == _temp2) // Comparing 1 to 2
            {
                if (_temp1 != emptyStar)
                {
                    if (_temp2 != emptyStar)
                    {
                        if (_temp1 != emptyStar)
                        {
                            if (_temp1 != global.drawingScript.startingStar)
                            {
                                if (_temp1 == _temp2)
                                {
                                    Debug.Log("Duplicates in Constellation!");
                                    conBool = true;
                                    return;
                                }
                                else
                                {
                                    conBool = false;
                                }

                            }
                        }

                    }
                }
            }
            if (_temp1 == _temp3) // Comparing 1 to 3
            {
                if (_temp1 != emptyStar)
                {
                    if (_temp3 != emptyStar)
                    {
                        if (_temp1 != global.drawingScript.startingStar)
                        {
                            if (_temp1 == _temp3)
                            {
                                Debug.Log("Duplicates in Constellation!");
                                conBool = true;
                                return;
                            }
                            else
                            {
                                conBool = false;
                            }
                        }
                    }
                }
            }
            if (_temp1 == _temp4) // Comparing 1 to 4
            {
                if (_temp1 != emptyStar)
                {
                    if (_temp4 != emptyStar)
                    {
                        if (_temp1 != global.drawingScript.startingStar)
                        {
                            if (_temp1 == _temp4)
                            {
                                Debug.Log("Duplicates in Constellation!");
                                conBool = true;
                                return;
                            }
                            else
                            {
                                conBool = false;
                            }

                        }
                    }
                }
            }
            if (_temp1 == _temp5) // Comparing 1 to 5
            {
                if (_temp1 != emptyStar)
                {
                    if (_temp5 != emptyStar)
                    {
                        if (_temp1 != global.drawingScript.startingStar)
                        {
                            if (_temp1 == _temp5)
                            {
                                Debug.Log("Duplicates in Constellation!");
                                conBool = true;
                                return;
                            }
                            else
                            {
                                conBool = false;
                            }

                        }
                    }
                }
            }
            if (_temp2 == _temp3) // Comparing 2 to 3
            {
                if (_temp2 != emptyStar)
                {
                    if (_temp3 != emptyStar)
                    {
                        if (_temp2 == _temp3)
                        {
                            Debug.Log("Duplicates in Constellation!");
                            conBool = true;
                            return;
                        }
                        else
                        {
                            conBool = false;
                        }
                    }
                }
            }
            if (_temp2 == _temp4) // Comparing 2 to 4
            {
                if (_temp2 != emptyStar)
                {
                    if (_temp4 != emptyStar)
                    {
                        if (_temp2 == _temp4)
                        {
                            Debug.Log("Duplicates in Constellation!");
                            conBool = true;
                            return;
                        }
                        else
                        {
                            conBool = false;
                        }
                    }
                }
            }
            if (_temp2 == _temp5) // Comparing 2 to 5
            {
                if (_temp2 != emptyStar)
                {
                    if (_temp5 != emptyStar)
                    {
                        if (_temp2 == _temp5)
                        {
                            Debug.Log("Duplicates in Constellation!");
                            conBool = true;
                            return;
                        }
                        else
                        {
                            conBool = false;
                        }
                    }
                }
            }
            if (_temp2 == _temp6) // Comparing 2 to 6
            {
                if (_temp2 != emptyStar)
                {
                    if (_temp6 != emptyStar)
                    {
                        if (_temp2 == _temp6)
                        {
                            Debug.Log("Duplicates in Constellation!");
                            conBool = true;
                            return;
                        }
                        else
                        {
                            conBool = false;
                        }
                    }
                }
            }
            if (_temp3 == _temp4) // Comparing 3 to 4
            {
                if (_temp3 != emptyStar)
                {
                    if (_temp4 != emptyStar)
                    {
                        if (_temp3 == _temp4)
                        {
                            Debug.Log("Duplicates in Constellation!");
                            conBool = true;
                            return;
                        }
                        else
                        {
                            conBool = false;
                        }
                    }
                }
            }
            if (_temp3 == _temp5) // Comparing 3 to 5
            {
                if (_temp3 != emptyStar)
                {
                    if (_temp5 != emptyStar)
                    {
                        if (_temp3 == _temp5)
                        {
                            Debug.Log("Duplicates in Constellation!");
                            conBool = true;
                            return;
                        }
                        else
                        {
                            conBool = false;
                        }
                    }
                }
            }
            if (_temp3 == _temp6) // Comparing 3 to 6
            {
                if (_temp3 != emptyStar)
                {
                    if (_temp6 != emptyStar)
                    {
                        if (_temp3 == _temp5)
                        {
                            Debug.Log("Duplicates in Constellation!");
                            conBool = true;
                            return;
                        }
                        else
                        {
                            conBool = false;
                        }
                    }
                }
            }
            if (_temp4 == _temp5) // Comapring 4 to 5
            {
                if (_temp4 != emptyStar)
                {
                    if (_temp5 != emptyStar)
                    {
                        if (_temp4 == _temp5)
                        {
                            Debug.Log("Duplicates in Constellation!");
                            conBool = true;
                            return;
                        }
                        else
                        {
                            conBool = false;
                        }
                    }
                }
            }

        }
        if (_temp3 == _temp5) // Comparing 4 to 6
        {
            if (_temp3 != emptyStar)
            {
                if (_temp5 != emptyStar)
                {
                    if (_temp3 == _temp5)
                    {
                        Debug.Log("Duplicates in Constellation!");
                        conBool = true;
                        return;
                    }
                    else
                    {
                        conBool = false;
                    }
                }
            }
        }
        if (_temp3 == _temp5) // Comparing 5 to 6
        {
            if (_temp3 != emptyStar)
            {
                if (_temp5 != emptyStar)
                {
                    if (_temp3 == _temp5)
                    {
                        Debug.Log("Duplicates in Constellation!");
                        conBool = true;
                        return;
                    }
                    else
                    {
                        conBool = false;
                    }
                }
            }
        }
        if (_temp1 == _temp6) // Comparing 1 to 6, should be the same, star 7 can't exist currently 
        {
            if (_temp1 != emptyStar)
            {
                if (_temp5 != emptyStar)
                {
                    if (_temp1 != global.drawingScript.startingStar)
                    {
                        if (_temp1 == _temp5)
                        {
                            Debug.Log("Duplicates in Constellation!");
                            conBool = true;
                            return;
                        }
                        else
                        {
                            conBool = false;
                        }

                    }
                    else
                    {
                        conBool = false;
                        return;
                    }
                }
            }
        }

        Debug.Log("Hey here's ConBool: " + conBool);

        if (conBool == true)
        {
            global.enumeratorCheckBad = 1; // Delete Constellation, since it was built falsely   
            StartCoroutine(constellationClearBad());
        }
    }

    /// <summary>
    ///  Future note to self:
    ///  When there is a lot of action stars in the future, 
    ///  build a helper function to add to a count variable in an iterable loop for the global.constellationBeingBuilt,
    ///  Where if the star's tag isn't "Star", the count goes up. 
    ///  Then I know how many action stars there are in the proposed constellation.
    ///  Why not change it now? Don't want to debug for it just yet. 
    /// </summary>

    public void ConstellationBuilt()
    {
        Vector3 _new_position = startingStarPosition + offset;
        conBool = false;
        DuplicateChecker();
        ConstellationBuilding();
        foreach (Star star in global.constellationBeingBuilt)
        {
            global.constellationStarCount += 1;
        }
        if ((global.constellationStarCount >= 3) & (conBool == false)) // Checks to make sure there are no duplicates and that there are more than 3 stars in the constellation list
        {
            if (global.constellationPotentialDamage == 0) // First check to see if only base stars have been tabulated, and thus an improper constellation
            {
                if (global.constellationPotentialHealth == 0) // No actionb star, no action done, and stars become usable again 
                {
                    Debug.Log("Constellation Is Only Base Stars! \nTry Again!");
                    global.enumeratorCheckBad = 1; // Make it so the Coroutine doesn't autoreturn
                    StartCoroutine(constellationClearBad()); // Improper so fully clear
                }
            }
            Debug.Log("Constellation Building!");
            if (global.constellationPotentialDamage > 0)
            {
                if (global.constellationPotentialHealth > 0)
                {
                    Debug.Log("Can't have both Health and Action Stars. \n\nTry again.");
                    global.enumeratorCheckBad = 1; // Make it so the Coroutine doesn't autoreturn
                    StartCoroutine(constellationClearBad()); // Fully Clear
                }
                else
                {
                    if(global.constellationPotentialDamage == 1) // Checking action star count
                    {
                        Debug.Log("Constellation Built for Damage!");
                        global.constellationFinalDamage = ((global.constellationPotential + global.constellationPotentialDamage) - 1); // Have to subtract by one since the starting star gets added twice
                        global.currentEnemy.EnemyDamaged(global.constellationFinalDamage);
                        Debug.Log(global.currentEnemy.enemyHealth);
                        global.enumeratorCheckGood = 1; // Make it so the Coroutine doesn't autoreturn
                        StartCoroutine(constellationClearGood()); // Keep Persitent Proper Constellations
                    }
                    else
                    {
                        Debug.Log("You have too many action stars! \n\nOnly 1 Allowed");
                        global.enumeratorCheckBad = 1; // Make it so the Coroutine doesn't autoreturn
                        StartCoroutine(constellationClearBad()); // Fully Clear
                    }
                }
            }
            if (global.constellationPotentialHealth > 0)
            {
                if (global.constellationPotentialDamage > 0)
                {
                    Debug.Log("Can't have both Health and Action Stars. \nTry Again.");
                    global.enumeratorCheckBad = 1; // Make it so the Coroutine doesn't autoreturn
                    StartCoroutine(constellationClearBad()); // Fully Clear
                }
                else
                {
                    if (global.constellationPotentialDamage == 1) // Checking action star count
                    {
                        Debug.Log("Constellation Built for Health!");
                        global.constellationFinalHealth += ((global.constellationPotential + global.constellationPotentialHealth) - 1); // Have to subtract by one since the starting star gets added twice
                        global.playerScript.PlayerHealed(global.constellationFinalHealth);
                        global.enumeratorCheckGood = 1; // Make it so the Coroutine doesn't autoreturn
                        StartCoroutine(constellationClearGood()); // Keep Persistent Proper Constellations 
                    }
                    else
                    {
                        Debug.Log("You have too many action stars! \nOnly 1 Allowed");
                        global.enumeratorCheckBad = 1; // Make it so the Coroutine doesn't autoreturn
                        StartCoroutine(constellationClearBad()); // Fully Clear
                    }
                }
            }

        }
    }
    IEnumerator constellationClearBad() // Add a isReset bool to reset behavior and then delete LineFinal
    {
        Debug.Log("Clearing Constellation");
        foreach (LineRendererScript lineRenderer in global.lineRendererList.ToList())
        {
            global.drawingScript.shouldNextStar = 1;
            Destroy(lineRenderer.gameObject);
        }
        foreach (Star star in global.constellationBeingBuilt.ToList())
        {
            star.starUsed = false;
            global.constellationBeingBuilt.Remove(star);
        }
        // All the values that need to go back to 0 
        global.constellationPotentialHealth = 0;
        global.constellationPotentialDamage = 0;
        global.constellationPotential = 0;
        global.constellationFinalDamage = 0;
        global.constellationFinalHealth = 0;
        global.starSpawnerFrameworkScript.StarResetForClear(); // Needed to reset drawing
        //enumeratorTriggered = true; // Thought I needed but will leave to trigger secondary behavior if need be
        conBool = false;
        _tempStarCount = 0;
        global.enumeratorCheckBad = 0;
        yield return new WaitUntil(() => global.enumeratorCheckBad == 0);
    }

    IEnumerator constellationClearGood()
    {
        foreach (LineRendererScript lineRenderer in global.lineRendererList.ToList())
        {
            lineFinal.Add(lineRenderer.gameObject); // Will have to delete later as well in Reset Behavior
            global.lineRendererList.Remove(lineRenderer);
        }
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
        global.constellationPotentialHealth = 0;
        global.constellationPotentialDamage = 0;
        global.constellationPotential = 0;
        global.constellationFinalDamage = 0;
        global.constellationFinalHealth = 0;
        conBool = false;
        _tempStarCount = 0;
        global.starSpawnerFrameworkScript.StarResetForClear();
        global.enumeratorCheckGood = 0; // Needs to be last, it's my exit condition
        yield return new WaitUntil(() => global.enumeratorCheckGood == 0);
    }
}


// Things for next week:
// Event table for enemy damage, starting on overworld scene with jager, implementing sound, implementing new pop up, cycling through enemies, new enemy and new star type, randomized star spawning