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
    public int checkCount;
    public Star emptyStar;
    private int _tempStarCount = 0; // Use for duplicate of starting star for value calculation
    // private bool enumeratorTriggered;
    public GameObject startingStarGO; // Drawing script star's game object and thus position 
    private Star startingStar_Star; // Drawing script star reference
    public Vector3 startingStarPosition; // The position of the starting star needed for 
    public Vector3 offset; // Changing position for aesthetics
    public bool hasThePlayerDrawnForTurn;
    public bool isShieldCon;
    public bool isHealthCon;
    public bool isDamageCon;

    [Header("Popup and Particles")]
    public Transform popUpCenterPoint; 
    
    [Header("In-Script Lists")]
    public List<GameObject> lineFinal = new List<GameObject>();

    void Start()
    {
        checkCount = 0;
        hasThePlayerDrawnForTurn = false;
        startingStarGO = emptyStar.gameObject; // Need something to hold data during runtime
        offset = new Vector3(0.5f, 0.5f, 0f); 
        global = GlobalController.instance;
        conBool = false;
        // enumeratorTriggered = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Get the needed position data for PopUp
        startingStar_Star = global.drawingScript.NodeStar;
        startingStarGO = startingStar_Star.gameObject; 
        startingStarPosition = startingStarGO.transform.position;
        checkCount = 0; // To reset the count each method call
        ConstellationCheck(); // Should check the values of the current list

        isShieldCon = false;
        isHealthCon = false;
        isDamageCon = false; 
}

    public void ConstellationCheck()
    {
        foreach (Star star in global.constellationBeingBuilt.ToList())
        {
            //Debug.Log("Based");
            checkCount += 1;
        }
        if(checkCount <= 7) // CHANGED FOR PLAYTEST, CHANGE BACK EVENTUALLY
        {
            return;
        }
        else
        {
            //foreach (var x in global.constellationBeingBuilt)
            //{
                //Debug.Log(x.ToString());
            //}
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
                if (star == global.drawingScript.NodeStar)
                {
                    if (_tempStarCount == 0)
                    {
                        global.constellationPotentialHealth -= 1;
                    }   
                }
                else
                {
                    global.constellationPotentialHealth += star.myStarClass.constellationValue;
                    isHealthCon = true;
                }
            }
            if (star.myStarClass.starType == "DamageStar")
            {
                if (star == global.drawingScript.NodeStar)
                {
                    if (_tempStarCount == 0)
                    {
                        global.constellationPotentialDamage -= 1;
                    }
                }
                else
                {
                    global.constellationPotentialDamage += star.myStarClass.constellationValue;
                    isDamageCon = true;
                }
            }
            if (star.myStarClass.starType == "ShieldStar")
            {
                if (star == global.drawingScript.NodeStar)
                {
                    if (_tempStarCount == 0)
                    {
                        global.constellationPotentialShield -= 1;
                    }
                }
                else
                {
                    global.constellationPotentialShield += star.myStarClass.constellationValue;
                    isShieldCon = true;
                }
            }
        }

        if(isShieldCon == true) // Doing a comparative check to see if shield and other action stars are being triggered, damage and health already have functionlity elsewhere
        {
            if(isDamageCon == true)
            {
                Debug.Log("Can't have more than 1 Action Star in the consellation!");
                global.enumeratorCheckBad = 1;
                StartCoroutine(constellationClearBad());
            }
            if(isHealthCon == true)
            {
                Debug.Log("Can't have more than 1 Action Star in the consellation!");
                global.enumeratorCheckBad = 1;
                StartCoroutine(constellationClearBad());
            }
        } 
    }

    //Make this one more constellation

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
        Star _temp7 = emptyStar;

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
            if (_tempCount == 6) // Star 7 in list 
            {
                _temp7 = star;
            } 
            _tempCount++;
        }
        if (_temp1 == _temp2) // Comparing 1 to 2
        {
            if (_temp1 != emptyStar)
            {
                if (_temp2 != emptyStar)
                {
                    if (_temp1 != global.drawingScript.NodeStar)
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
        if (_temp1 == _temp3) // Comparing 1 to 3
        {
            if (_temp1 != emptyStar)
            {
                if (_temp3 != emptyStar)
                {
                    if (_temp1 != global.drawingScript.NodeStar)
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
                    if (_temp1 != global.drawingScript.NodeStar)
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
                    if (_temp1 != global.drawingScript.NodeStar)
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
        if (_temp1 == _temp6) // Comparing 1 to 6
        {
            if (_temp1 != emptyStar)
            {
                if (_temp6 != emptyStar)
                {
                    if (_temp1 != global.drawingScript.NodeStar)
                    {
                        if (_temp1 == _temp6)
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
        if (_temp2 == _temp7) // Comparing 2 to 7
        {
            if (_temp2 != emptyStar)
            {
                if (_temp7 != emptyStar)
                {
                    if (_temp2 == _temp7)
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
                    if (_temp3 == _temp6)
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
        if (_temp3 == _temp6) // Comparing 3 to 7
        {
            if (_temp3 != emptyStar)
            {
                if (_temp7 != emptyStar)
                {
                    if (_temp3 == _temp7)
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
        if (_temp4 == _temp5) // Comparing 4 to 5
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
        if (_temp4 == _temp6) // Comparing 4 to 6
        {
            if (_temp4 != emptyStar)
            {
                if (_temp6 != emptyStar)
                {
                    if (_temp4 == _temp6)
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
        if (_temp4 == _temp6) // Comparing 4 to 7
        {
            if (_temp4 != emptyStar)
            {
                if (_temp7 != emptyStar)
                {
                    if (_temp4 == _temp7)
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
        if (_temp5 == _temp6) // Comparing 5 to 6
        {
            if (_temp5 != emptyStar)
            {
                if (_temp6 != emptyStar)
                {
                    if (_temp5 == _temp6)
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
        if (_temp5 == _temp7) // Comparing 5 to 7
        {
            if (_temp5 != emptyStar)
            {
                if (_temp7 != emptyStar)
                {
                    if (_temp5 == _temp7)
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
        if (_temp6 == _temp7) // Comparing 6 to 7
        {
            if (_temp6 != emptyStar)
            {
                if (_temp7 != emptyStar)
                {
                    if (_temp6 == _temp7)
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
        if (_temp1 == _temp7) // Comparing 1 to 7
        {
            if (_temp1 != emptyStar)
            {
                if (_temp7 != emptyStar)
                {
                    if (_temp1 != global.drawingScript.NodeStar)
                    {
                        if (_temp1 == _temp7)
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
        foreach (Star star in global.constellationBeingBuilt.ToList())
        {
            global.constellationStarCount += 1;
            // Needs to be 4 to be formed
        }
        if ((global.constellationStarCount >= 4) & (conBool == false)) // Checks to make sure there are no duplicates and that there are more than 3 stars in the constellation list
        {
            if (global.constellationPotentialDamage == 0) // First check to see if only base stars have been tabulated, and thus an improper constellation
            {
                if (global.constellationPotentialHealth == 0) // No action star, no action done, and so no constellation, but stars become usable again 
                {
                    if(global.constellationPotentialShield == 0)
                    {
                        Debug.Log("Constellation Is Only Base Stars! \nTry Again!");
                        global.enumeratorCheckBad = 1; // Make it so the Coroutine doesn't autoreturn
                        StartCoroutine(constellationClearBad()); // Improper so fully clear
                    }
                }
            }
            Debug.Log("Constellation Building!");
            if (global.constellationPotentialDamage > 0) // Damage Star Check
            {
                if (global.constellationPotentialHealth > 0)
                {
                    Debug.Log("Can't have both Health and Action Stars. \n\nTry again.");
                    global.enumeratorCheckBad = 1; // Make it so the Coroutine doesn't autoreturn
                    StartCoroutine(constellationClearBad()); // Fully Clear
                }
                else
                {
                    if (global.constellationPotentialDamage == 1) // Checking action star count
                    {
                        Debug.Log("Constellation Built for Damage!");
                        float _lineMultiplier = LineMultiplierCalculator();  
                        global.constellationFinalDamage = global.constellationPotential + global.constellationPotentialDamage * _lineMultiplier;
                        int _constellationFinal = (int)Mathf.Round(global.constellationFinalDamage);
                        global.enemySelected.EnemyDamaged(_constellationFinal);
                        //Debug.Log(global.currentEnemy.enemyHealth);
                        global.enumeratorCheckGood = 1; // Make it so the Coroutine doesn't autoreturn
                        //global.particleSystemScript.SpawnStarParticleEffect(global.enemyPopUpTransform);
                        //Popup.Create(global.enemyPopUpTransform.position, global.constellationFinalHealth, 1);
                        //bool isDamage = true;
                        StartCoroutine(constellationClearGood("damage")); // Keep Persitent Proper Constellations
                    }
                    else
                    {
                        Debug.Log("You have too many action stars! \n\nOnly 1 Allowed");
                        global.enumeratorCheckBad = 1; // Make it so the Coroutine doesn't autoreturn
                        StartCoroutine(constellationClearBad()); // Fully Clear
                    }
                }
            }
            if (global.constellationPotentialHealth > 0) // Health Star Check
            {
                if (global.constellationPotentialDamage > 0)
                {
                    Debug.Log("Can't have both Health and Action Stars. \nTry Again.");
                    global.enumeratorCheckBad = 1; // Make it so the Coroutine doesn't autoreturn
                    StartCoroutine(constellationClearBad()); // Fully Clear
                }
                else
                {
                    if (global.constellationPotentialHealth == 1) // Checking action star count
                    {
                        Debug.Log("Constellation Built for Health!");
                        float _lineMultiplier = LineMultiplierCalculator();
                        global.constellationFinalHealth += global.constellationPotential + global.constellationPotentialHealth * _lineMultiplier * 0.5f;
                        int _constellationFinal = (int)Mathf.Round(global.constellationFinalHealth);
                        if(PlayerStats.playerVitality < 50)
                        {
                            global.playerScript.PlayerHealed(_constellationFinal);
                            global.enumeratorCheckGood = 1; // Make it so the Coroutine doesn't autoreturn
                            StartCoroutine(constellationClearGood("health")); 
                        }
                        else
                        {
                            Debug.Log("The player is at Max Health!");
                            global.enumeratorCheckBad = 1; 
                            StartCoroutine(constellationClearBad());
                        }
                    }
                    else
                    {
                        Debug.Log("You have too many action stars! \nOnly 1 Allowed");
                        global.enumeratorCheckBad = 1; // Make it so the Coroutine doesn't autoreturn
                        StartCoroutine(constellationClearBad()); // Fully Clear
                    }
                }
            }
            if (global.constellationPotentialShield > 0) // Shield Star Building, check done elsewhere
            {
                Debug.Log("Constellation Built for !");
                float _lineMultiplier = LineMultiplierCalculator();
                global.constellationFinalShield += global.constellationPotential + global.constellationPotentialShield * _lineMultiplier;
                int _constellationFinal = (int)Mathf.Round(global.constellationFinalShield);
                if (global.playerShieldCount < 20)
                {
                    global.playerScript.PlayerShields(_constellationFinal);
                    global.enumeratorCheckGood = 1; // Make it so the Coroutine doesn't autoreturn
                    StartCoroutine(constellationClearGood("shield"));
                }
                else
                {
                    Debug.Log("The player is at Max Shields!");
                    global.enumeratorCheckBad = 1;
                    StartCoroutine(constellationClearBad());
                }
            }

        }
        else // Failed the minimum Constellation Count Check 
        {
            Debug.Log("Not Enough Stars! \n\nTry again.");
            global.enumeratorCheckBad = 1; // Make it so the Coroutine doesn't autoreturn
            StartCoroutine(constellationClearBad()); // Fully Clear
        }
    }
    public IEnumerator constellationClearBad() // Add a isReset bool to reset behavior and then delete LineFinal
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
        global.constellationPotentialShield = 0;
        global.constellationPotential = 0;
        global.constellationFinalDamage = 0;
        global.constellationFinalHealth = 0;
        global.constellationFinalShield = 0;
        global.drawingScript.nodeClickCount = 0;
        checkCount = 0;
        global.starSpawnerFrameworkScript.StarResetForClear(); // Needed to reset drawing
        //enumeratorTriggered = true; // Thought I needed but will leave to trigger secondary behavior if need be
        conBool = false;
        _tempStarCount = 0;
        global.enumeratorCheckBad = 0;
        yield return new WaitUntil(() => global.enumeratorCheckBad == 0);
    }

    public IEnumerator constellationClearGood(string _identity)
    {
        global.m_SoundEffectConFinish.Play(); // CONSTELLATION SOUND EFFECT
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
        }
        if(_identity == "health") 
        {
            global.particleSystemScript.SpawnHealthParticleEffect(popUpCenterPoint);
            int _constellationFinal = (int)Mathf.Round(global.constellationFinalHealth);
            global.popup.Create(popUpCenterPoint.position, _constellationFinal, 0, true);
            global.m_SoundEffectWhoosh.Play();
            Debug.Log("PopUp!");
        }
        if (_identity == "damage")
        {
            global.particleSystemScript.SpawnDamageParticleEffect(popUpCenterPoint);
            int _constellationFinal = (int)Mathf.Round(global.constellationFinalDamage);
            global.popup.Create(popUpCenterPoint.position, _constellationFinal, 1, false);
            global.m_SoundEffectWhoosh.Play();
            Debug.Log("PopUp!");
        }
        if (_identity == "shield") 
        {
            global.particleSystemScript.SpawnShieldParticleEffect(popUpCenterPoint);
            int _constellationFinal = (int)Mathf.Round(global.constellationFinalShield);
            global.popup.Create(popUpCenterPoint.position, _constellationFinal, 2, true);
            global.m_SoundEffectWhoosh.Play();
            Debug.Log("PopUp!");
        }
        global.constellationPotentialHealth = 0;
        global.constellationPotentialDamage = 0;
        global.constellationPotentialShield = 0;
        global.constellationPotential = 0;
        global.constellationFinalDamage = 0;
        global.constellationFinalHealth = 0;
        global.constellationFinalShield= 0;
        global.drawingScript.nodeClickCount = 0; 
        conBool = false;
        _tempStarCount = 0;
        checkCount = 0;
        global.starSpawnerFrameworkScript.StarResetForClear();
        global.enumeratorCheckGood = 0; // Needs to be last, it's my exit condition
        yield return new WaitUntil(() => global.enumeratorCheckGood == 0);
    }

    public float LineMultiplierGrabbing(List<LineRendererScript> _lineList) // Helper function to give me a line tally to use in the calculator 
    {
        float _lineLengthTally = 0f;
        foreach (LineRendererScript _lineRendererReferenced in _lineList.ToList())
        {
            _lineLengthTally += _lineRendererReferenced.myTallyLength; 
        }
        return _lineLengthTally; 
    }

    public float LineMultiplierCalculator() // Where the line multiplier is calculated
    {
        // Initial Values
        float lineAmount = LineMultiplierGrabbing(global.lineRendererList);
        float lineMultiplier = 1.0f;

        // Global Animation Curve values 
        AnimationCurve comparatorCurve = global.animationCurveForMultiplier;
        float lowerBoundCurve = comparatorCurve[0].value; 
        float upperBoundCurve = comparatorCurve[1].value;

        float _lineValue = (lineAmount - global.lowerBoundLine) / global.upperBoundLine; // Normalize the tally amount into a decimal values around 1.0 
        Debug.Log(_lineValue); 

        // Compare the normalized value to the curve values 
        if (_lineValue >= lowerBoundCurve)
        {
            if (_lineValue <= upperBoundCurve)
            {
                lineMultiplier = comparatorCurve.Evaluate(_lineValue);
                Debug.Log(lineMultiplier);
                return lineMultiplier; 
            } 
            else
            {
                lineMultiplier = comparatorCurve.Evaluate(_lineValue);
                Debug.Log(lineMultiplier);
                return lineMultiplier;
            }
        }
        else // If it fails the conditions, it returns a 1.0 mutliplier 
        {
            Debug.Log(lineMultiplier);
            return lineMultiplier = comparatorCurve.Evaluate(_lineValue);
        }
    }
}

//lineLengthTally = (int)Mathf.Round(_lineLengthGrabbed);
