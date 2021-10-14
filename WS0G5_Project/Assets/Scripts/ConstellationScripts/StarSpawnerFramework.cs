using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TMPro;

public class StarSpawnerFramework : MonoBehaviour
{
    [Header("Stars")] // Were the prefabs are stored to refer to specific stars, this data is also in the prefab itself, which is where I grab most of the time 
    public StarClass baseStar;
    public StarClass actionHealthStar;
    public StarClass actionDamageStar; 

    [Header("Other")]
    public GameObject verticalGrid;
    public GameObject horizontalGrid;
    public int starSpawnCount; // Check star spawn count
    public int counter = 20;
    private int iEnumeratorFramework = 0;

    public int starMapCount; 

    [Header("Lists")] // Lists to contain spawn points so we could iterate through them if need be
    public List<Transform> row1= new List<Transform>();
    public List<Transform> row2 = new List<Transform>();
    public List<Transform> row3 = new List<Transform>();
    public List<Transform> row4 = new List<Transform>();
    public List<Transform> row5 = new List<Transform>();
    public List<Transform> row6 = new List<Transform>();
    public List<Transform> row7 = new List<Transform>();
    public List<Transform> row8 = new List<Transform>();
    public List<Transform> row9 = new List<Transform>();
    public List<Transform> row10 = new List<Transform>();
    public List<Transform> row11 = new List<Transform>();
    public List<Transform> row12 = new List<Transform>();
    public List<Transform> row13 = new List<Transform>();
    public List<Transform> row14 = new List<Transform>();
    public List<Transform> row15 = new List<Transform>();
    public List<Transform> row16 = new List<Transform>();
    public List<Transform> row17 = new List<Transform>();
    public List<GameObject> usedTransform = new List<GameObject>();


    // Structure for refering to a spawn point goes starSpawnPoint(point number in row)_(what row that point is in)


    [Header("Row 1")]
    public Transform starSpawnPoint1_1;
    public Transform starSpawnPoint2_1;
    public Transform starSpawnPoint3_1;
    public Transform starSpawnPoint4_1;
    public Transform starSpawnPoint5_1;
    public Transform starSpawnPoint6_1;
    public Transform starSpawnPoint7_1;
    public Transform starSpawnPoint8_1;
    public Transform starSpawnPoint9_1;
    public Transform starSpawnPoint10_1;
    public Transform starSpawnPoint11_1;
    public Transform starSpawnPoint12_1;
    public Transform starSpawnPoint13_1;
    public Transform starSpawnPoint14_1;
    public Transform starSpawnPoint15_1;
    public Transform starSpawnPoint16_1;
    public Transform starSpawnPoint17_1;
    public Transform starSpawnPoint18_1;
    public Transform starSpawnPoint19_1;
    public Transform starSpawnPoint20_1;

    [Header("Row 2")]
    public Transform starSpawnPoint1_2;
    public Transform starSpawnPoint2_2;
    public Transform starSpawnPoint3_2;
    public Transform starSpawnPoint4_2;
    public Transform starSpawnPoint5_2;
    public Transform starSpawnPoint6_2;
    public Transform starSpawnPoint7_2;
    public Transform starSpawnPoint8_2;
    public Transform starSpawnPoint9_2;
    public Transform starSpawnPoint10_2;
    public Transform starSpawnPoint11_2;
    public Transform starSpawnPoint12_2;
    public Transform starSpawnPoint13_2;
    public Transform starSpawnPoint14_2;
    public Transform starSpawnPoint15_2;
    public Transform starSpawnPoint16_2;
    public Transform starSpawnPoint17_2;
    public Transform starSpawnPoint18_2;
    public Transform starSpawnPoint19_2;
    public Transform starSpawnPoint20_2;

    [Header("Row 3")]
    public Transform starSpawnPoint1_3;
    public Transform starSpawnPoint2_3;
    public Transform starSpawnPoint3_3;
    public Transform starSpawnPoint4_3;
    public Transform starSpawnPoint5_3;
    public Transform starSpawnPoint6_3;
    public Transform starSpawnPoint7_3;
    public Transform starSpawnPoint8_3;
    public Transform starSpawnPoint9_3;
    public Transform starSpawnPoint10_3;
    public Transform starSpawnPoint11_3;
    public Transform starSpawnPoint12_3;
    public Transform starSpawnPoint13_3;
    public Transform starSpawnPoint14_3;
    public Transform starSpawnPoint15_3;
    public Transform starSpawnPoint16_3;
    public Transform starSpawnPoint17_3;
    public Transform starSpawnPoint18_3;
    public Transform starSpawnPoint19_3;
    public Transform starSpawnPoint20_3;

    [Header("Row 4")]
    public Transform starSpawnPoint1_4;
    public Transform starSpawnPoint2_4;
    public Transform starSpawnPoint3_4;
    public Transform starSpawnPoint4_4;
    public Transform starSpawnPoint5_4;
    public Transform starSpawnPoint6_4;
    public Transform starSpawnPoint7_4;
    public Transform starSpawnPoint8_4;
    public Transform starSpawnPoint9_4;
    public Transform starSpawnPoint10_4;
    public Transform starSpawnPoint11_4;
    public Transform starSpawnPoint12_4;
    public Transform starSpawnPoint13_4;
    public Transform starSpawnPoint14_4;
    public Transform starSpawnPoint15_4;
    public Transform starSpawnPoint16_4;
    public Transform starSpawnPoint17_4;
    public Transform starSpawnPoint18_4;
    public Transform starSpawnPoint19_4;
    public Transform starSpawnPoint20_4;

    [Header("Row 5")]
    public Transform starSpawnPoint1_5;
    public Transform starSpawnPoint2_5;
    public Transform starSpawnPoint3_5;
    public Transform starSpawnPoint4_5;
    public Transform starSpawnPoint5_5;
    public Transform starSpawnPoint6_5;
    public Transform starSpawnPoint7_5;
    public Transform starSpawnPoint8_5;
    public Transform starSpawnPoint9_5;
    public Transform starSpawnPoint10_5;
    public Transform starSpawnPoint11_5;
    public Transform starSpawnPoint12_5;
    public Transform starSpawnPoint13_5;
    public Transform starSpawnPoint14_5;
    public Transform starSpawnPoint15_5;
    public Transform starSpawnPoint16_5;
    public Transform starSpawnPoint17_5;
    public Transform starSpawnPoint18_5;
    public Transform starSpawnPoint19_5;
    public Transform starSpawnPoint20_5;

    [Header("Row 6")]
    public Transform starSpawnPoint1_6;
    public Transform starSpawnPoint2_6;
    public Transform starSpawnPoint3_6;
    public Transform starSpawnPoint4_6;
    public Transform starSpawnPoint5_6;
    public Transform starSpawnPoint6_6;
    public Transform starSpawnPoint7_6;
    public Transform starSpawnPoint8_6;
    public Transform starSpawnPoint9_6;
    public Transform starSpawnPoint10_6;
    public Transform starSpawnPoint11_6;
    public Transform starSpawnPoint12_6;
    public Transform starSpawnPoint13_6;
    public Transform starSpawnPoint14_6;
    public Transform starSpawnPoint15_6;
    public Transform starSpawnPoint16_6;
    public Transform starSpawnPoint17_6;
    public Transform starSpawnPoint18_6;
    public Transform starSpawnPoint19_6;
    public Transform starSpawnPoint20_6;

    [Header("Row 7")]
    public Transform starSpawnPoint1_7;
    public Transform starSpawnPoint2_7;
    public Transform starSpawnPoint3_7;
    public Transform starSpawnPoint4_7;
    public Transform starSpawnPoint5_7;
    public Transform starSpawnPoint6_7;
    public Transform starSpawnPoint7_7;
    public Transform starSpawnPoint8_7;
    public Transform starSpawnPoint9_7;
    public Transform starSpawnPoint10_7;
    public Transform starSpawnPoint11_7;
    public Transform starSpawnPoint12_7;
    public Transform starSpawnPoint13_7;
    public Transform starSpawnPoint14_7;
    public Transform starSpawnPoint15_7;
    public Transform starSpawnPoint16_7;
    public Transform starSpawnPoint17_7;
    public Transform starSpawnPoint18_7;
    public Transform starSpawnPoint19_7;
    public Transform starSpawnPoint20_7;

    [Header("Row 8")]
    public Transform starSpawnPoint1_8;
    public Transform starSpawnPoint2_8;
    public Transform starSpawnPoint3_8;
    public Transform starSpawnPoint4_8;
    public Transform starSpawnPoint5_8;
    public Transform starSpawnPoint6_8;
    public Transform starSpawnPoint7_8;
    public Transform starSpawnPoint8_8;
    public Transform starSpawnPoint9_8;
    public Transform starSpawnPoint10_8;
    public Transform starSpawnPoint11_8;
    public Transform starSpawnPoint12_8;
    public Transform starSpawnPoint13_8;
    public Transform starSpawnPoint14_8;
    public Transform starSpawnPoint15_8;
    public Transform starSpawnPoint16_8;
    public Transform starSpawnPoint17_8;
    public Transform starSpawnPoint18_8;
    public Transform starSpawnPoint19_8;
    public Transform starSpawnPoint20_8;

    [Header("Row 9")]
    public Transform starSpawnPoint1_9;
    public Transform starSpawnPoint2_9;
    public Transform starSpawnPoint3_9;
    public Transform starSpawnPoint4_9;
    public Transform starSpawnPoint5_9;
    public Transform starSpawnPoint6_9;
    public Transform starSpawnPoint7_9;
    public Transform starSpawnPoint8_9;
    public Transform starSpawnPoint9_9;
    public Transform starSpawnPoint10_9;
    public Transform starSpawnPoint11_9;
    public Transform starSpawnPoint12_9;
    public Transform starSpawnPoint13_9;
    public Transform starSpawnPoint14_9;
    public Transform starSpawnPoint15_9;
    public Transform starSpawnPoint16_9;
    public Transform starSpawnPoint17_9;
    public Transform starSpawnPoint18_9;
    public Transform starSpawnPoint19_9;
    public Transform starSpawnPoint20_9;

    [Header("Row 10")]
    public Transform starSpawnPoint1_10;
    public Transform starSpawnPoint2_10;
    public Transform starSpawnPoint3_10;
    public Transform starSpawnPoint4_10;
    public Transform starSpawnPoint5_10;
    public Transform starSpawnPoint6_10;
    public Transform starSpawnPoint7_10;
    public Transform starSpawnPoint8_10;
    public Transform starSpawnPoint9_10;
    public Transform starSpawnPoint10_10;
    public Transform starSpawnPoint11_10;
    public Transform starSpawnPoint12_10;
    public Transform starSpawnPoint13_10;
    public Transform starSpawnPoint14_10;
    public Transform starSpawnPoint15_10;
    public Transform starSpawnPoint16_10;
    public Transform starSpawnPoint17_10;
    public Transform starSpawnPoint18_10;
    public Transform starSpawnPoint19_10;
    public Transform starSpawnPoint20_10;

    [Header("Row 11")]
    public Transform starSpawnPoint1_11;
    public Transform starSpawnPoint2_11;
    public Transform starSpawnPoint3_11;
    public Transform starSpawnPoint4_11;
    public Transform starSpawnPoint5_11;
    public Transform starSpawnPoint6_11;
    public Transform starSpawnPoint7_11;
    public Transform starSpawnPoint8_11;
    public Transform starSpawnPoint9_11;
    public Transform starSpawnPoint10_11;
    public Transform starSpawnPoint11_11;
    public Transform starSpawnPoint12_11;
    public Transform starSpawnPoint13_11;
    public Transform starSpawnPoint14_11;
    public Transform starSpawnPoint15_11;
    public Transform starSpawnPoint16_11;
    public Transform starSpawnPoint17_11;
    public Transform starSpawnPoint18_11;
    public Transform starSpawnPoint19_11;
    public Transform starSpawnPoint20_11;

    [Header("Row 12")]
    public Transform starSpawnPoint1_12;
    public Transform starSpawnPoint2_12;
    public Transform starSpawnPoint3_12;
    public Transform starSpawnPoint4_12;
    public Transform starSpawnPoint5_12;
    public Transform starSpawnPoint6_12;
    public Transform starSpawnPoint7_12;
    public Transform starSpawnPoint8_12;
    public Transform starSpawnPoint9_12;
    public Transform starSpawnPoint10_12;
    public Transform starSpawnPoint11_12;
    public Transform starSpawnPoint12_12;
    public Transform starSpawnPoint13_12;
    public Transform starSpawnPoint14_12;
    public Transform starSpawnPoint15_12;
    public Transform starSpawnPoint16_12;
    public Transform starSpawnPoint17_12;
    public Transform starSpawnPoint18_12;
    public Transform starSpawnPoint19_12;
    public Transform starSpawnPoint20_12;

    [Header("Row 13")]
    public Transform starSpawnPoint1_13;
    public Transform starSpawnPoint2_13;
    public Transform starSpawnPoint3_13;
    public Transform starSpawnPoint4_13;
    public Transform starSpawnPoint5_13;
    public Transform starSpawnPoint6_13;
    public Transform starSpawnPoint7_13;
    public Transform starSpawnPoint8_13;
    public Transform starSpawnPoint9_13;
    public Transform starSpawnPoint10_13;
    public Transform starSpawnPoint11_13;
    public Transform starSpawnPoint12_13;
    public Transform starSpawnPoint13_13;
    public Transform starSpawnPoint14_13;
    public Transform starSpawnPoint15_13;
    public Transform starSpawnPoint16_13;
    public Transform starSpawnPoint17_13;
    public Transform starSpawnPoint18_13;
    public Transform starSpawnPoint19_13;
    public Transform starSpawnPoint20_13;

    [Header("Row 14")]
    public Transform starSpawnPoint1_14;
    public Transform starSpawnPoint2_14;
    public Transform starSpawnPoint3_14;
    public Transform starSpawnPoint4_14;
    public Transform starSpawnPoint5_14;
    public Transform starSpawnPoint6_14;
    public Transform starSpawnPoint7_14;
    public Transform starSpawnPoint8_14;
    public Transform starSpawnPoint9_14;
    public Transform starSpawnPoint10_14;
    public Transform starSpawnPoint11_14;
    public Transform starSpawnPoint12_14;
    public Transform starSpawnPoint13_14;
    public Transform starSpawnPoint14_14;
    public Transform starSpawnPoint15_14;
    public Transform starSpawnPoint16_14;
    public Transform starSpawnPoint17_14;
    public Transform starSpawnPoint18_14;
    public Transform starSpawnPoint19_14;
    public Transform starSpawnPoint20_14;

   

    [Header("Row 15")]
    public Transform starSpawnPoint1_15;
    public Transform starSpawnPoint2_15;
    public Transform starSpawnPoint3_15;
    public Transform starSpawnPoint4_15;
    public Transform starSpawnPoint5_15;
    public Transform starSpawnPoint6_15;
    public Transform starSpawnPoint7_15;
    public Transform starSpawnPoint8_15;
    public Transform starSpawnPoint9_15;
    public Transform starSpawnPoint10_15;
    public Transform starSpawnPoint11_15;
    public Transform starSpawnPoint12_15;
    public Transform starSpawnPoint13_15;
    public Transform starSpawnPoint14_15;
    public Transform starSpawnPoint15_15;
    public Transform starSpawnPoint16_15;
    public Transform starSpawnPoint17_15;
    public Transform starSpawnPoint18_15;
    public Transform starSpawnPoint19_15;
    public Transform starSpawnPoint20_15;

    [Header("Row 16")]
    public Transform starSpawnPoint1_16;
    public Transform starSpawnPoint2_16;
    public Transform starSpawnPoint3_16;
    public Transform starSpawnPoint4_16;
    public Transform starSpawnPoint5_16;
    public Transform starSpawnPoint6_16;
    public Transform starSpawnPoint7_16;
    public Transform starSpawnPoint8_16;
    public Transform starSpawnPoint9_16;
    public Transform starSpawnPoint10_16;
    public Transform starSpawnPoint11_16;
    public Transform starSpawnPoint12_16;
    public Transform starSpawnPoint13_16;
    public Transform starSpawnPoint14_16;
    public Transform starSpawnPoint15_16;
    public Transform starSpawnPoint16_16;
    public Transform starSpawnPoint17_16;
    public Transform starSpawnPoint18_16;
    public Transform starSpawnPoint19_16;
    public Transform starSpawnPoint20_16;

    [Header("Row 17")]
    public Transform starSpawnPoint1_17;
    public Transform starSpawnPoint2_17;
    public Transform starSpawnPoint3_17;
    public Transform starSpawnPoint4_17;
    public Transform starSpawnPoint5_17;
    public Transform starSpawnPoint6_17;
    public Transform starSpawnPoint7_17;
    public Transform starSpawnPoint8_17;
    public Transform starSpawnPoint9_17;
    public Transform starSpawnPoint10_17;
    public Transform starSpawnPoint11_17;
    public Transform starSpawnPoint12_17;
    public Transform starSpawnPoint13_17;
    public Transform starSpawnPoint14_17;
    public Transform starSpawnPoint15_17;
    public Transform starSpawnPoint16_17;
    public Transform starSpawnPoint17_17;
    public Transform starSpawnPoint18_17;
    public Transform starSpawnPoint19_17;
    public Transform starSpawnPoint20_17;

    // Functions
    private GlobalController global;

    void Start()
    {
        global = GlobalController.instance;
        starSpawnCount = 0;
        SpawnStarRow1List(); // Adds rows into list if needed to be referenced
        SpawnStarRow2List();
        SpawnStarRow3List();
        SpawnStarRow4List();
        SpawnStarRow5List();
        SpawnStarRow6List();
        SpawnStarRow7List();
        SpawnStarRow8List();
        SpawnStarRow9List();
        SpawnStarRow10List();
        SpawnStarRow11List();
        SpawnStarRow12List();

        SpawnStar(baseStar);
        SpawnStar(actionHealthStar);
        SpawnStar(actionDamageStar);
    }

    public void FrameworkReset() // Public Call to be used in Reset Behavior
    {
        iEnumeratorFramework = 1;
        StartCoroutine(FrameworkResetting());
    }

    IEnumerator FrameworkResetting() // Meant for game resetting 
    {
        foreach (GameObject starThatWasSpawned in usedTransform.ToList())
        {
            usedTransform.Remove(starThatWasSpawned); // Know what stars were spawned
            Destroy(starThatWasSpawned); // Clear off spawned Stars 
        }
        iEnumeratorFramework = 0;
        yield return new WaitUntil(() => iEnumeratorFramework == 0); // Need a condition to get out of IEnumerator when I'm down
    }

    public void StarReset()
    {
        Debug.Log("Resetting Star Clicks");
        global.drawingScript.activeStarCounter = 0;
        global.drawingScript.transformHolder = new List<Vector3>();
    }

    void Update()
    {
        verticalGrid.SetActive(false);
        horizontalGrid.SetActive(false);
    }

    // First Star Map Counts 
    // Normal Stars = 39
    // Health Stars = 2
    // Damage Stars = 4

    // To be made random soon 
    void SpawnStar(StarClass star) // Hand Built Calls Per Level, meaning we have to manually change this to load as we require it to change
    {
        if (starSpawnCount == 0) // Starts at 0
        {
            GameObject starToBeSpawned1 = Instantiate(star.starPrefab, starSpawnPoint3_1.position, starSpawnPoint3_1.rotation); // By creating it here, it doesn't mess with the other stars
            Debug.Log("Star Spawned!");
            global.startingStarSpawnPointList.Add(starSpawnPoint3_1); 
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned1); 
        }
        if (starSpawnCount == 1)
        {
            GameObject starToBeSpawned2 = Instantiate(star.starPrefab, starSpawnPoint15_1.position, starSpawnPoint15_1.rotation);
            Debug.Log("Star Spawned!");
            global.startingStarSpawnPointList.Add(starSpawnPoint15_1);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned2);
        }
        if (starSpawnCount == 2)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint19_1.position, starSpawnPoint19_1.rotation);
            Debug.Log("Star Spawned!");
            global.startingStarSpawnPointList.Add(starSpawnPoint8_5);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 3)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_2.position, starSpawnPoint6_2.rotation);
            Debug.Log("Star Spawned!");
            global.startingStarSpawnPointList.Add(starSpawnPoint6_2);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 4)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_2.position, starSpawnPoint12_2.rotation);
            Debug.Log("Star Spawned!");
            global.startingStarSpawnPointList.Add(starSpawnPoint12_2);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 5) // Adding more past this
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint1_3.position, starSpawnPoint1_3.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint1_3);
            usedTransform.Add(starToBeSpawned); 
        }
        if (starSpawnCount == 6)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_3.position, starSpawnPoint17_3.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint17_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 7)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_4.position, starSpawnPoint8_5.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 8)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint11_5.position, starSpawnPoint11_5.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint11_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 9)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint20_4.position, starSpawnPoint20_4.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint20_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 10)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_5.position, starSpawnPoint5_5.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 11)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_5.position, starSpawnPoint10_5.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 12)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_4.position, starSpawnPoint2_4.rotation); // Accidentally skipped Row 4, it's okay to do here
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint2_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 13)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_8.position, starSpawnPoint6_8.rotation); // Starting again with row 8
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_8);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 14)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint9_8.position, starSpawnPoint9_8.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint9_8);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 15) // Added 10, 16
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_8.position, starSpawnPoint16_8.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_8);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 16) 
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_9.position, starSpawnPoint3_9.rotation); // Row 9
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 17)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint13_9.position, starSpawnPoint13_9.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint13_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 18)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint20_9.position, starSpawnPoint20_9.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint20_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 19)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_10.position, starSpawnPoint7_10.rotation); // Row 10
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 20)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint11_10.position, starSpawnPoint11_10.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint11_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 21)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_10.position, starSpawnPoint15_10.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 22)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_11.position, starSpawnPoint2_11.rotation); // Pick up with Row 11
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint2_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 23)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint19_11.position, starSpawnPoint19_11.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint19_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 24)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_12.position, starSpawnPoint5_12.rotation); // Row 12
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_12);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 25) // Added 10, 26
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_12.position, starSpawnPoint16_12.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_12);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 26)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint9_13.position, starSpawnPoint9_13.rotation); // Row 13
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint9_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 27)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint13_13.position, starSpawnPoint13_13.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint13_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 28)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint1_14.position, starSpawnPoint1_14.rotation); // Row 14
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint1_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 29)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_14.position, starSpawnPoint4_14.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 30)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_14.position, starSpawnPoint17_14.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint17_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 31)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_15.position, starSpawnPoint10_15.rotation); // Row 15
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_15);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 32)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_15.position, starSpawnPoint7_15.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_15);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 33)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_15.position, starSpawnPoint12_15.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_15);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 34)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_16.position, starSpawnPoint2_16.rotation); // Row 16
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint19_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 35) // Added 10, now 36
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_16.position, starSpawnPoint15_16.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_16);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 36)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_17.position, starSpawnPoint8_17.rotation); // Row 17
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_17);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 37)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint19_17.position, starSpawnPoint19_17.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint19_17);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 38) // Health Star Start 
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_4.position, starSpawnPoint17_4.rotation);
            Debug.Log("Health Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint17_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 39) // Health Star End
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_13.position, starSpawnPoint16_13.rotation);
            Debug.Log("Health Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_13);
            usedTransform.Add(starToBeSpawned);
            return; 
        }
        if (starSpawnCount == 40) // Action Star Start
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_3.position, starSpawnPoint5_3.rotation);
            Debug.Log("Action Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 41) 
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_7.position, starSpawnPoint12_7.rotation);
            Debug.Log("Action Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_7);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 42) 
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint13_14.position, starSpawnPoint13_14.rotation);
            Debug.Log("Action Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint13_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 43) // Action Star End
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_16.position, starSpawnPoint5_6.rotation);
            Debug.Log("Action Star Spawned!");
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_6);
            usedTransform.Add(starToBeSpawned);
        }
    }

    void SpawnObstacle() // Instance obstacles as well
    {

    }

    public void SpawnStar2(StarClass star) // Trigger from New Stars Script
    {

    }

    void SpawnStarRow1List()
    {
        row1.Add(starSpawnPoint1_1);
        row1.Add(starSpawnPoint2_1);
        row1.Add(starSpawnPoint3_1);
        row1.Add(starSpawnPoint4_1);
        row1.Add(starSpawnPoint5_1);
        row1.Add(starSpawnPoint6_1);
        row1.Add(starSpawnPoint7_1);
        row1.Add(starSpawnPoint8_1);
        row1.Add(starSpawnPoint9_1);
        row1.Add(starSpawnPoint10_1);
        row1.Add(starSpawnPoint11_1);
        row1.Add(starSpawnPoint12_1);
        row1.Add(starSpawnPoint13_1);
        row1.Add(starSpawnPoint14_1);
        row1.Add(starSpawnPoint15_1);
        row1.Add(starSpawnPoint16_1);
        row1.Add(starSpawnPoint17_1);
        row1.Add(starSpawnPoint18_1);
        row1.Add(starSpawnPoint19_1);
        row1.Add(starSpawnPoint20_1);
        Debug.Log("Row 1 Added");
    }
    void SpawnStarRow2List()
    {
        row2.Add(starSpawnPoint1_2);
        row2.Add(starSpawnPoint2_2);
        row2.Add(starSpawnPoint3_2);
        row2.Add(starSpawnPoint4_2);
        row2.Add(starSpawnPoint5_2);
        row2.Add(starSpawnPoint6_2);
        row2.Add(starSpawnPoint7_2);
        row2.Add(starSpawnPoint8_2);
        row2.Add(starSpawnPoint9_2);
        row2.Add(starSpawnPoint10_2);
        row2.Add(starSpawnPoint11_2);
        row2.Add(starSpawnPoint12_2);
        row2.Add(starSpawnPoint13_2);
        row2.Add(starSpawnPoint14_2);
        row2.Add(starSpawnPoint15_2);
        row2.Add(starSpawnPoint16_2);
        row2.Add(starSpawnPoint17_2);
        row2.Add(starSpawnPoint18_2);
        row2.Add(starSpawnPoint19_2);
        row2.Add(starSpawnPoint20_2);
        Debug.Log("Row 2 Added");
    }
    void SpawnStarRow3List()
    {
        row3.Add(starSpawnPoint1_3);
        row3.Add(starSpawnPoint2_3);
        row3.Add(starSpawnPoint3_3);
        row3.Add(starSpawnPoint4_3);
        row3.Add(starSpawnPoint5_3);
        row3.Add(starSpawnPoint6_3);
        row3.Add(starSpawnPoint7_3);
        row3.Add(starSpawnPoint8_3);
        row3.Add(starSpawnPoint9_3);
        row3.Add(starSpawnPoint10_3);
        row3.Add(starSpawnPoint11_3);
        row3.Add(starSpawnPoint12_3);
        row3.Add(starSpawnPoint13_3);
        row3.Add(starSpawnPoint14_3);
        row3.Add(starSpawnPoint15_3);
        row3.Add(starSpawnPoint16_3);
        row3.Add(starSpawnPoint17_3);
        row3.Add(starSpawnPoint18_3);
        row3.Add(starSpawnPoint19_3);
        row3.Add(starSpawnPoint20_3);
        Debug.Log("Row 3 Added");
    }
    void SpawnStarRow4List()
    {
        row4.Add(starSpawnPoint1_4);
        row4.Add(starSpawnPoint2_4);
        row4.Add(starSpawnPoint3_4);
        row4.Add(starSpawnPoint4_4);
        row4.Add(starSpawnPoint5_4);
        row4.Add(starSpawnPoint6_4);
        row4.Add(starSpawnPoint7_4);
        row4.Add(starSpawnPoint8_4);
        row4.Add(starSpawnPoint9_4);
        row4.Add(starSpawnPoint10_4);
        row4.Add(starSpawnPoint11_4);
        row4.Add(starSpawnPoint12_4);
        row4.Add(starSpawnPoint13_4);
        row4.Add(starSpawnPoint14_4);
        row4.Add(starSpawnPoint15_4);
        row4.Add(starSpawnPoint16_4);
        row4.Add(starSpawnPoint17_4);
        row4.Add(starSpawnPoint18_4);
        row4.Add(starSpawnPoint19_4);
        row4.Add(starSpawnPoint20_4);
        Debug.Log("Row 4 Added");
    }
    void SpawnStarRow5List()
    {
        row5.Add(starSpawnPoint1_5);
        row5.Add(starSpawnPoint2_5);
        row5.Add(starSpawnPoint3_5);
        row5.Add(starSpawnPoint4_5);
        row5.Add(starSpawnPoint5_5);
        row5.Add(starSpawnPoint6_5);
        row5.Add(starSpawnPoint7_5);
        row5.Add(starSpawnPoint8_5);
        row5.Add(starSpawnPoint9_5);
        row5.Add(starSpawnPoint10_5);
        row5.Add(starSpawnPoint11_5);
        row5.Add(starSpawnPoint12_5);
        row5.Add(starSpawnPoint13_5);
        row5.Add(starSpawnPoint14_5);
        row5.Add(starSpawnPoint15_5);
        row5.Add(starSpawnPoint16_5);
        row5.Add(starSpawnPoint17_5);
        row5.Add(starSpawnPoint18_5);
        row5.Add(starSpawnPoint19_5);
        row5.Add(starSpawnPoint20_5);
        Debug.Log("Row 5 Added");
    }
    void SpawnStarRow6List()
    {
        row6.Add(starSpawnPoint1_6);
        row6.Add(starSpawnPoint2_6);
        row6.Add(starSpawnPoint3_6);
        row6.Add(starSpawnPoint4_6);
        row6.Add(starSpawnPoint5_6);
        row6.Add(starSpawnPoint6_6);
        row6.Add(starSpawnPoint7_6);
        row6.Add(starSpawnPoint8_6);
        row6.Add(starSpawnPoint9_6);
        row6.Add(starSpawnPoint10_6);
        row6.Add(starSpawnPoint11_6);
        row6.Add(starSpawnPoint12_6);
        row6.Add(starSpawnPoint13_6);
        row6.Add(starSpawnPoint14_6);
        row6.Add(starSpawnPoint15_6);
        row6.Add(starSpawnPoint16_6);
        row6.Add(starSpawnPoint17_6);
        row6.Add(starSpawnPoint18_6);
        row6.Add(starSpawnPoint19_6);
        row6.Add(starSpawnPoint20_6);
        Debug.Log("Row 6 Added");
    }
    void SpawnStarRow7List()
    {
        row7.Add(starSpawnPoint1_7);
        row7.Add(starSpawnPoint2_7);
        row7.Add(starSpawnPoint3_7);
        row7.Add(starSpawnPoint4_7);
        row7.Add(starSpawnPoint5_7);
        row7.Add(starSpawnPoint6_7);
        row7.Add(starSpawnPoint7_7);
        row7.Add(starSpawnPoint8_7);
        row7.Add(starSpawnPoint9_7);
        row7.Add(starSpawnPoint10_7);
        row7.Add(starSpawnPoint11_7);
        row7.Add(starSpawnPoint12_7);
        row7.Add(starSpawnPoint13_7);
        row7.Add(starSpawnPoint14_7);
        row7.Add(starSpawnPoint15_7);
        row7.Add(starSpawnPoint16_7);
        row7.Add(starSpawnPoint17_7);
        row7.Add(starSpawnPoint18_7);
        row7.Add(starSpawnPoint19_7);
        row7.Add(starSpawnPoint20_7);
        Debug.Log("Row 7 Added");
    }
    void SpawnStarRow8List()
    {
        row8.Add(starSpawnPoint1_8);
        row8.Add(starSpawnPoint2_8);
        row8.Add(starSpawnPoint3_8);
        row8.Add(starSpawnPoint4_8);
        row8.Add(starSpawnPoint5_8);
        row8.Add(starSpawnPoint6_8);
        row8.Add(starSpawnPoint7_8);
        row8.Add(starSpawnPoint8_8);
        row8.Add(starSpawnPoint9_8);
        row8.Add(starSpawnPoint10_8);
        row8.Add(starSpawnPoint11_8);
        row8.Add(starSpawnPoint12_8);
        row8.Add(starSpawnPoint13_8);
        row8.Add(starSpawnPoint14_8);
        row8.Add(starSpawnPoint15_8);
        row8.Add(starSpawnPoint16_8);
        row8.Add(starSpawnPoint17_8);
        row8.Add(starSpawnPoint18_8);
        row8.Add(starSpawnPoint19_8);
        row8.Add(starSpawnPoint20_8);
        Debug.Log("Row 8 Added");
    }
    void SpawnStarRow9List()
    {
        row9.Add(starSpawnPoint1_9);
        row9.Add(starSpawnPoint2_9);
        row9.Add(starSpawnPoint3_9);
        row9.Add(starSpawnPoint4_9);
        row9.Add(starSpawnPoint5_9);
        row9.Add(starSpawnPoint6_9);
        row9.Add(starSpawnPoint7_9);
        row9.Add(starSpawnPoint8_9);
        row9.Add(starSpawnPoint9_9);
        row9.Add(starSpawnPoint10_9);
        row9.Add(starSpawnPoint11_9);
        row9.Add(starSpawnPoint12_9);
        row9.Add(starSpawnPoint13_9);
        row9.Add(starSpawnPoint14_9);
        row9.Add(starSpawnPoint15_9);
        row9.Add(starSpawnPoint16_9);
        row9.Add(starSpawnPoint17_9);
        row9.Add(starSpawnPoint18_9);
        row9.Add(starSpawnPoint19_9);
        row9.Add(starSpawnPoint20_9);
        Debug.Log("Row 9 Added");
    }
    void SpawnStarRow10List()
    {
        row10.Add(starSpawnPoint1_10);
        row10.Add(starSpawnPoint2_10);
        row10.Add(starSpawnPoint3_10);
        row10.Add(starSpawnPoint4_10);
        row10.Add(starSpawnPoint5_10);
        row10.Add(starSpawnPoint6_10);
        row10.Add(starSpawnPoint7_10);
        row10.Add(starSpawnPoint8_10);
        row10.Add(starSpawnPoint9_10);
        row10.Add(starSpawnPoint10_10);
        row10.Add(starSpawnPoint11_10);
        row10.Add(starSpawnPoint12_10);
        row10.Add(starSpawnPoint13_10);
        row10.Add(starSpawnPoint14_10);
        row10.Add(starSpawnPoint15_10);
        row10.Add(starSpawnPoint16_10);
        row10.Add(starSpawnPoint17_10);
        row10.Add(starSpawnPoint18_10);
        row10.Add(starSpawnPoint19_10);
        row10.Add(starSpawnPoint20_10);
        Debug.Log("Row 10 Added");
    }
    void SpawnStarRow11List()
    {
        row11.Add(starSpawnPoint1_11);
        row11.Add(starSpawnPoint2_11);
        row11.Add(starSpawnPoint3_11);
        row11.Add(starSpawnPoint4_11);
        row11.Add(starSpawnPoint5_11);
        row11.Add(starSpawnPoint6_11);
        row11.Add(starSpawnPoint7_11);
        row11.Add(starSpawnPoint8_11);
        row11.Add(starSpawnPoint9_11);
        row11.Add(starSpawnPoint10_11);
        row11.Add(starSpawnPoint11_11);
        row11.Add(starSpawnPoint12_11);
        row11.Add(starSpawnPoint13_11);
        row11.Add(starSpawnPoint14_11);
        row11.Add(starSpawnPoint15_11);
        row11.Add(starSpawnPoint16_11);
        row11.Add(starSpawnPoint17_11);
        row11.Add(starSpawnPoint18_11);
        row11.Add(starSpawnPoint19_11);
        row11.Add(starSpawnPoint20_11);
        Debug.Log("Row 11 Added");
    }
    void SpawnStarRow12List()
    {
        row12.Add(starSpawnPoint1_12);
        row12.Add(starSpawnPoint2_12);
        row12.Add(starSpawnPoint3_12);
        row12.Add(starSpawnPoint4_12);
        row12.Add(starSpawnPoint5_12);
        row12.Add(starSpawnPoint6_12);
        row12.Add(starSpawnPoint7_12);
        row12.Add(starSpawnPoint8_12);
        row12.Add(starSpawnPoint9_12);
        row12.Add(starSpawnPoint10_12);
        row12.Add(starSpawnPoint11_12);
        row12.Add(starSpawnPoint12_12);
        row12.Add(starSpawnPoint13_12);
        row12.Add(starSpawnPoint14_12);
        row12.Add(starSpawnPoint15_12);
        row12.Add(starSpawnPoint16_12);
        row12.Add(starSpawnPoint17_12);
        row12.Add(starSpawnPoint18_12);
        row12.Add(starSpawnPoint19_12);
        row12.Add(starSpawnPoint20_12);
        Debug.Log("Row 12 Added");
    }

    void SpawnStarRow13List()
    {
        row13.Add(starSpawnPoint1_13);
        row13.Add(starSpawnPoint2_13);
        row13.Add(starSpawnPoint3_13);
        row13.Add(starSpawnPoint4_13);
        row13.Add(starSpawnPoint5_13);
        row13.Add(starSpawnPoint6_13);
        row13.Add(starSpawnPoint7_13);
        row13.Add(starSpawnPoint8_13);
        row13.Add(starSpawnPoint9_13);
        row13.Add(starSpawnPoint10_13);
        row13.Add(starSpawnPoint11_13);
        row13.Add(starSpawnPoint12_13);
        row13.Add(starSpawnPoint13_13);
        row13.Add(starSpawnPoint14_13);
        row13.Add(starSpawnPoint15_13);
        row13.Add(starSpawnPoint16_13);
        row13.Add(starSpawnPoint17_13);
        row13.Add(starSpawnPoint18_13);
        row13.Add(starSpawnPoint19_13);
        row13.Add(starSpawnPoint20_13);
        Debug.Log("Row 13 Added");
    }

    void SpawnStarRow14List()
    {
        row14.Add(starSpawnPoint1_14);
        row14.Add(starSpawnPoint2_14);
        row14.Add(starSpawnPoint3_14);
        row14.Add(starSpawnPoint4_14);
        row14.Add(starSpawnPoint5_14);
        row14.Add(starSpawnPoint6_14);
        row14.Add(starSpawnPoint7_14);
        row14.Add(starSpawnPoint8_14);
        row14.Add(starSpawnPoint9_14);
        row14.Add(starSpawnPoint10_14);
        row14.Add(starSpawnPoint11_14);
        row14.Add(starSpawnPoint12_14);
        row14.Add(starSpawnPoint13_14);
        row14.Add(starSpawnPoint14_14);
        row14.Add(starSpawnPoint15_14);
        row14.Add(starSpawnPoint16_14);
        row14.Add(starSpawnPoint17_14);
        row14.Add(starSpawnPoint18_14);
        row14.Add(starSpawnPoint19_14);
        row14.Add(starSpawnPoint20_14);
        Debug.Log("Row 14 Added");
    }

    void SpawnStarRow15List()
    {
        row15.Add(starSpawnPoint1_15);
        row15.Add(starSpawnPoint2_15);
        row15.Add(starSpawnPoint3_15);
        row15.Add(starSpawnPoint4_15);
        row15.Add(starSpawnPoint5_15);
        row15.Add(starSpawnPoint6_15);
        row15.Add(starSpawnPoint7_15);
        row15.Add(starSpawnPoint8_15);
        row15.Add(starSpawnPoint9_15);
        row15.Add(starSpawnPoint10_15);
        row15.Add(starSpawnPoint11_15);
        row15.Add(starSpawnPoint12_15);
        row15.Add(starSpawnPoint13_15);
        row15.Add(starSpawnPoint14_15);
        row15.Add(starSpawnPoint15_15);
        row15.Add(starSpawnPoint16_15);
        row15.Add(starSpawnPoint17_15);
        row15.Add(starSpawnPoint18_15);
        row15.Add(starSpawnPoint19_15);
        row15.Add(starSpawnPoint20_15);
        Debug.Log("Row 15 Added");
    }

    void SpawnStarRow16List()
    {
        row16.Add(starSpawnPoint1_16);
        row16.Add(starSpawnPoint2_16);
        row16.Add(starSpawnPoint3_16);
        row16.Add(starSpawnPoint4_16);
        row16.Add(starSpawnPoint5_16);
        row16.Add(starSpawnPoint6_16);
        row16.Add(starSpawnPoint7_16);
        row16.Add(starSpawnPoint8_16);
        row16.Add(starSpawnPoint9_16);
        row16.Add(starSpawnPoint10_16);
        row16.Add(starSpawnPoint11_16);
        row16.Add(starSpawnPoint12_16);
        row16.Add(starSpawnPoint13_16);
        row16.Add(starSpawnPoint14_16);
        row16.Add(starSpawnPoint15_16);
        row16.Add(starSpawnPoint16_16);
        row16.Add(starSpawnPoint17_16);
        row16.Add(starSpawnPoint18_16);
        row16.Add(starSpawnPoint19_16);
        row16.Add(starSpawnPoint20_16);
        Debug.Log("Row 16 Added");
    }

    void SpawnStarRow17List()
    {
        row17.Add(starSpawnPoint1_17);
        row17.Add(starSpawnPoint2_17);
        row17.Add(starSpawnPoint3_17);
        row17.Add(starSpawnPoint4_17);
        row17.Add(starSpawnPoint5_17);
        row17.Add(starSpawnPoint6_17);
        row17.Add(starSpawnPoint7_17);
        row17.Add(starSpawnPoint8_17);
        row17.Add(starSpawnPoint9_17);
        row17.Add(starSpawnPoint10_17);
        row17.Add(starSpawnPoint11_17);
        row17.Add(starSpawnPoint12_17);
        row17.Add(starSpawnPoint13_17);
        row17.Add(starSpawnPoint14_17);
        row17.Add(starSpawnPoint15_17);
        row17.Add(starSpawnPoint16_17);
        row17.Add(starSpawnPoint17_17);
        row17.Add(starSpawnPoint18_17);
        row17.Add(starSpawnPoint19_17);
        row17.Add(starSpawnPoint20_17);
        Debug.Log("Row 17 Added");
    }
}
