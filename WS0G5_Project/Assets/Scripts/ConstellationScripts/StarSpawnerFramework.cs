using System.Collections;
using System.Runtime; 
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
    public StarClass shieldStar;
    public StarClass stunStar;
    public StarClass nodeStar;
    // Have to be star classes due to the code used 


    [Header("Other")]
    public GameObject obstaclePrefab;
    public GameObject verticalGrid;
    public GameObject horizontalGrid;
    public int starSpawnCount; // Check star spawn count
    public int starSpawnCount2;
    public int starSpawnCount3;
    public int starSpawnCount4;
    public int starSpawnCount5;
    public int counter = 20;
    private int iEnumeratorFramework = 0;

    public int starMapCount;

    [Header("Lists")] // Lists to contain spawn points so we could iterate through them if need be
    public List<Transform> row1 = new List<Transform>();
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
    public List<GameObject> usedObstacleTransform = new List<GameObject>();
    public List<Transform> tempSpawnList = new List<Transform>();


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

    [Header("Star Spawning")]
    public List<Transform> masterRowList = new List<Transform>(); // Lists for all points
    public List<Transform> masterRowOriginList = new List<Transform>(); // Lists for all points
    public List<Transform> usedTransformList = new List<Transform>(); // Lists to grab the used transforms to exclude them
    public List<Transform> newSpawnPointList = new List<Transform>(); // Lists to use for new star generation
    public int newPointsUsed = 1; // Trigger variable
    public int pointCount = 46; // Count To variable

    [Header("Obstacles Varaiables")]
    //private int obstacleCount = 0;
    public List<Transform> obstacleStartPointRow1 = new List<Transform>();
    public List<Transform> obstacleStartPointRow2 = new List<Transform>();
    public List<Transform> obstacleStartPointRow3 = new List<Transform>();
    public List<Transform> obstacleStartPointRow4 = new List<Transform>();
    public List<Transform> obstacleStartPointRow5 = new List<Transform>();
    public List<Transform> obstacleEndPointEndRow1 = new List<Transform>();
    public List<Transform> obstacleEndPointEndRow2 = new List<Transform>();
    public List<Transform> obstacleEndPointEndRow3 = new List<Transform>();
    public List<Transform> obstacleEndPointEndRow4 = new List<Transform>();
    public List<Transform> obstacleEndPointEndRow5 = new List<Transform>();
    public List<(Transform, Transform)> obstacleRowPair1 = new List<(Transform, Transform)>();
    public List<(Transform, Transform)> obstacleRowPair2 = new List<(Transform, Transform)>();
    public List<(Transform, Transform)> obstacleRowPair3 = new List<(Transform, Transform)>();
    public List<(Transform, Transform)> obstacleRowPair4 = new List<(Transform, Transform)>();
    public List<(Transform, Transform)> obstacleRowPair5 = new List<(Transform, Transform)>();

    [Header("Obstacle Start Row 1")] // Set up to be more dynamic later, but for now just need to be there
    public Transform obstactleSpawnPoint1_1;
    public Transform obstactleSpawnPoint2_1;
    public Transform obstactleSpawnPoint3_1;
    public Transform obstactleSpawnPoint4_1;
    public Transform obstactleSpawnPoint5_1;
    public Transform obstactleSpawnPoint6_1;
    public Transform obstactleSpawnPoint7_1;
    public Transform obstactleSpawnPoint8_1;
    public Transform obstactleSpawnPoint9_1;
    public Transform obstactleSpawnPoint10_1;

    [Header("Obstacle Start Row 2")]
    public Transform obstactleSpawnPoint1_2;
    public Transform obstactleSpawnPoint2_2;
    public Transform obstactleSpawnPoint3_2;
    public Transform obstactleSpawnPoint4_2;
    public Transform obstactleSpawnPoint5_2;
    public Transform obstactleSpawnPoint6_2;
    public Transform obstactleSpawnPoint7_2;
    public Transform obstactleSpawnPoint8_2;
    public Transform obstactleSpawnPoint9_2;
    public Transform obstactleSpawnPoint10_2;

    [Header("Obstacle Start Row 3")]
    public Transform obstactleSpawnPoint1_3;
    public Transform obstactleSpawnPoint2_3;
    public Transform obstactleSpawnPoint3_3;
    public Transform obstactleSpawnPoint4_3;
    public Transform obstactleSpawnPoint5_3;
    public Transform obstactleSpawnPoint6_3;
    public Transform obstactleSpawnPoint7_3;
    public Transform obstactleSpawnPoint8_3;
    public Transform obstactleSpawnPoint9_3;
    public Transform obstactleSpawnPoint10_3;

    [Header("Obstacle Start Row 4")]
    public Transform obstactleSpawnPoint1_4;
    public Transform obstactleSpawnPoint2_4;
    public Transform obstactleSpawnPoint3_4;
    public Transform obstactleSpawnPoint4_4;
    public Transform obstactleSpawnPoint5_4;
    public Transform obstactleSpawnPoint6_4;
    public Transform obstactleSpawnPoint7_4;
    public Transform obstactleSpawnPoint8_4;
    public Transform obstactleSpawnPoint9_4;
    public Transform obstactleSpawnPoint10_4;

    [Header("Obstacle Start Row 5")]
    public Transform obstactleSpawnPoint1_5;
    public Transform obstactleSpawnPoint2_5;
    public Transform obstactleSpawnPoint3_5;
    public Transform obstactleSpawnPoint4_5;
    public Transform obstactleSpawnPoint5_5;
    public Transform obstactleSpawnPoint6_5;
    public Transform obstactleSpawnPoint7_5;
    public Transform obstactleSpawnPoint8_5;
    public Transform obstactleSpawnPoint9_5;
    public Transform obstactleSpawnPoint10_5;

    [Header("Obstacle End Row 1")]
    public Transform obstactleEndSpawnPoint1_1;
    public Transform obstactleEndSpawnPoint2_1;
    public Transform obstactleEndSpawnPoint3_1;
    public Transform obstactleEndSpawnPoint4_1;
    public Transform obstactleEndSpawnPoint5_1;
    public Transform obstactleEndSpawnPoint6_1;
    public Transform obstactleEndSpawnPoint7_1;
    public Transform obstactleEndSpawnPoint8_1;
    public Transform obstactleEndSpawnPoint9_1;
    public Transform obstactleEndSpawnPoint10_1;

    [Header("Obstacle End Row 2")]
    public Transform obstactleEndSpawnPoint1_2;
    public Transform obstactleEndSpawnPoint2_2;
    public Transform obstactleEndSpawnPoint3_2;
    public Transform obstactleEndSpawnPoint4_2;
    public Transform obstactleEndSpawnPoint5_2;
    public Transform obstactleEndSpawnPoint6_2;
    public Transform obstactleEndSpawnPoint7_2;
    public Transform obstactleEndSpawnPoint8_2;
    public Transform obstactleEndSpawnPoint9_2;
    public Transform obstactleEndSpawnPoint10_2;

    [Header("Obstacle End Row 3")]
    public Transform obstactleEndSpawnPoint1_3;
    public Transform obstactleEndSpawnPoint2_3;
    public Transform obstactleEndSpawnPoint3_3;
    public Transform obstactleEndSpawnPoint4_3;
    public Transform obstactleEndSpawnPoint5_3;
    public Transform obstactleEndSpawnPoint6_3;
    public Transform obstactleEndSpawnPoint7_3;
    public Transform obstactleEndSpawnPoint8_3;
    public Transform obstactleEndSpawnPoint9_3;
    public Transform obstactleEndSpawnPoint10_3;

    [Header("Obstacle End Row 4")]
    public Transform obstactleEndSpawnPoint1_4;
    public Transform obstactleEndSpawnPoint2_4;
    public Transform obstactleEndSpawnPoint3_4;
    public Transform obstactleEndSpawnPoint4_4;
    public Transform obstactleEndSpawnPoint5_4;
    public Transform obstactleEndSpawnPoint6_4;
    public Transform obstactleEndSpawnPoint7_4;
    public Transform obstactleEndSpawnPoint8_4;
    public Transform obstactleEndSpawnPoint9_4;
    public Transform obstactleEndSpawnPoint10_4;

    [Header("Obstacle End Row 5")]
    public Transform obstactleEndSpawnPoint1_5;
    public Transform obstactleEndSpawnPoint2_5;
    public Transform obstactleEndSpawnPoint3_5;
    public Transform obstactleEndSpawnPoint4_5;
    public Transform obstactleEndSpawnPoint5_5;
    public Transform obstactleEndSpawnPoint6_5;
    public Transform obstactleEndSpawnPoint7_5;
    public Transform obstactleEndSpawnPoint8_5;
    public Transform obstactleEndSpawnPoint9_5;
    public Transform obstactleEndSpawnPoint10_5;

    [Header("Hardoded Spawn Variables")]
    public int baseStarCount;
    // Move these vars after testing
    public int hardcodeCount = 0;
    public int numBaseStars;
    public int numDamageStars;
    public int numHealthStars;
    public int numShieldStars;
    public int healthStarDeletedInGeneration;
    public int damageStarDeletedInGeneration;
    public int obstacleDeletedInGeneration;
    private Star mainNodeStar;

    [Header("Hardcoded Maps")] // 20 of them 
    public GameObject obstaclesForMap1;
    public GameObject obstaclesForMap2;
    public GameObject obstaclesForMap3;
    public GameObject obstaclesForMap4;
    public GameObject obstaclesForMap5;
    public GameObject obstaclesForMap6;
    public GameObject obstaclesForMap7;
    public GameObject obstaclesForMap8;
    public GameObject obstaclesForMap9;
    public GameObject obstaclesForMap10;
    public GameObject obstaclesForMap11;
    public GameObject obstaclesForMap12;
    public GameObject obstaclesForMap13;
    public GameObject obstaclesForMap14;
    public GameObject obstaclesForMap15;
    public GameObject obstaclesForMap16;
    public GameObject obstaclesForMap17;
    public GameObject obstaclesForMap18;
    public GameObject obstaclesForMap19;
    public GameObject obstaclesForMap20;

    [Header("Tuple Obstacle Row Pairs")]
    // Row 1
    public (Transform, Transform) pair1_1; // There are 5 in a row
    public (Transform, Transform) pair1_2;
    public (Transform, Transform) pair1_3;
    public (Transform, Transform) pair1_4;
    public (Transform, Transform) pair1_5;

    // Row 2
    public (Transform, Transform) pair2_1;
    public (Transform, Transform) pair2_2;
    public (Transform, Transform) pair2_3;
    public (Transform, Transform) pair2_4;
    public (Transform, Transform) pair2_5;

    // Row 3
    public (Transform, Transform) pair3_1;
    public (Transform, Transform) pair3_2;
    public (Transform, Transform) pair3_3;
    public (Transform, Transform) pair3_4;
    public (Transform, Transform) pair3_5;

    // Row 4
    public (Transform, Transform) pair4_1;
    public (Transform, Transform) pair4_2;
    public (Transform, Transform) pair4_3;
    public (Transform, Transform) pair4_4;
    public (Transform, Transform) pair4_5;

    // Row 5
    public (Transform, Transform) pair5_1;
    public (Transform, Transform) pair5_2;
    public (Transform, Transform) pair5_3;
    public (Transform, Transform) pair5_4;
    public (Transform, Transform) pair5_5;

    // Functions
    private GlobalController global;

    private void Awake() // Set up lists before Starts trigger
    {
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
        SpawnStarRow13List();
        SpawnStarRow14List();
        SpawnStarRow15List();
        SpawnStarRow16List();
        SpawnStarRow17List();
        CollateStarLists();
        HandBuiltObstaclePairs();
    }

    void Start()
    {
        masterRowOriginList = masterRowList;
        global = GlobalController.instance;
        //starSpawnCount = 0;
        //SpawnStar(baseStar);
        //SpawnStar(actionHealthStar);
        //SpawnStar(actionDamageStar);
        //global.startingStarSpawnPointList.Add(global.drawingScript.NodeStar.transform);, think this is making it be deleted

        // Going to activate these as necessary, so want them disabled to start
        obstaclesForMap1.SetActive(false);
        obstaclesForMap2.SetActive(false);
        obstaclesForMap3.SetActive(false);
        obstaclesForMap4.SetActive(false);
        obstaclesForMap5.SetActive(false);
        obstaclesForMap6.SetActive(false);
        obstaclesForMap7.SetActive(false);
        obstaclesForMap8.SetActive(false);
        obstaclesForMap9.SetActive(false);
        obstaclesForMap10.SetActive(false);
        obstaclesForMap11.SetActive(false);
        obstaclesForMap12.SetActive(false);
        obstaclesForMap13.SetActive(false);
        obstaclesForMap14.SetActive(false);
        obstaclesForMap15.SetActive(false);
        HCMapPicker();
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
        ClearObstacles();
        iEnumeratorFramework = 0;
        yield return new WaitUntil(() => iEnumeratorFramework == 0); // Need a condition to get out of IEnumerator when I'm down
    }

    public void HandBuiltObstaclePairs() // Much simpler script that keeps the data points together in a tuple format
    {
        // Pairs for Row 1
        pair1_1 = (obstactleSpawnPoint1_1, obstactleEndSpawnPoint1_1);
        pair1_2 = (obstactleSpawnPoint1_2, obstactleEndSpawnPoint1_2);
        pair1_3 = (obstactleSpawnPoint1_3, obstactleEndSpawnPoint1_3);
        pair1_4 = (obstactleSpawnPoint1_4, obstactleEndSpawnPoint1_4);
        pair1_5 = (obstactleSpawnPoint1_5, obstactleEndSpawnPoint1_5);

        // Pairs for Row 2
        pair2_1 = (obstactleSpawnPoint2_1, obstactleEndSpawnPoint2_1);
        pair2_2 = (obstactleSpawnPoint2_2, obstactleEndSpawnPoint2_2);
        pair2_3 = (obstactleSpawnPoint2_3, obstactleEndSpawnPoint2_3);
        pair2_4 = (obstactleSpawnPoint2_4, obstactleEndSpawnPoint2_4);
        pair2_5 = (obstactleSpawnPoint2_5, obstactleEndSpawnPoint2_5);

        // Pairs for Row 3
        pair3_1 = (obstactleSpawnPoint3_1, obstactleEndSpawnPoint3_1);
        pair3_2 = (obstactleSpawnPoint3_2, obstactleEndSpawnPoint3_2);
        pair3_3 = (obstactleSpawnPoint3_3, obstactleEndSpawnPoint3_3);
        pair3_4 = (obstactleSpawnPoint3_4, obstactleEndSpawnPoint3_4);
        pair3_5 = (obstactleSpawnPoint3_5, obstactleEndSpawnPoint3_5);

        // Pairs for Row 4
        pair4_1 = (obstactleSpawnPoint4_1, obstactleEndSpawnPoint4_1);
        pair4_2 = (obstactleSpawnPoint4_2, obstactleEndSpawnPoint4_2);
        pair4_3 = (obstactleSpawnPoint4_3, obstactleEndSpawnPoint4_3);
        pair4_4 = (obstactleSpawnPoint4_4, obstactleEndSpawnPoint4_4);
        pair4_5 = (obstactleSpawnPoint4_5, obstactleEndSpawnPoint4_5);

        // Pairs for Row 5
        pair5_1 = (obstactleSpawnPoint5_1, obstactleEndSpawnPoint5_1);
        pair5_2 = (obstactleSpawnPoint5_2, obstactleEndSpawnPoint5_2);
        pair5_3 = (obstactleSpawnPoint5_3, obstactleEndSpawnPoint5_3);
        pair5_4 = (obstactleSpawnPoint5_4, obstactleEndSpawnPoint5_4);
        pair5_5 = (obstactleSpawnPoint5_5, obstactleEndSpawnPoint5_5);

        // Row 1 List
        obstacleRowPair1.Add(pair1_1);
        obstacleRowPair1.Add(pair1_2);
        obstacleRowPair1.Add(pair1_3);
        obstacleRowPair1.Add(pair1_4);
        obstacleRowPair1.Add(pair1_5);

        // Row 2 List
        obstacleRowPair2.Add(pair2_1);
        obstacleRowPair2.Add(pair2_2);
        obstacleRowPair2.Add(pair2_3);
        obstacleRowPair2.Add(pair2_4);
        obstacleRowPair2.Add(pair2_5);

        // Row 3 List
        obstacleRowPair3.Add(pair3_1);
        obstacleRowPair3.Add(pair3_2);
        obstacleRowPair3.Add(pair3_3);
        obstacleRowPair3.Add(pair3_4);
        obstacleRowPair3.Add(pair3_5);

        // Row 4 List
        obstacleRowPair4.Add(pair4_1);
        obstacleRowPair4.Add(pair4_2);
        obstacleRowPair4.Add(pair4_3);
        obstacleRowPair4.Add(pair4_4);
        obstacleRowPair4.Add(pair4_5);

        // Row 5 List
        obstacleRowPair5.Add(pair5_1);
        obstacleRowPair5.Add(pair5_2);
        obstacleRowPair5.Add(pair5_3);
        obstacleRowPair5.Add(pair5_4);
        obstacleRowPair5.Add(pair5_5);

    }

    public void StarReset()
    {
        Debug.Log("Resetting Star Clicks");
        global.drawingScript.activeStarCounter = 1;
        global.drawingScript.transformHolder = new List<Vector3>();
    }

    public void StarResetForClear()
    {
        Debug.Log("Resetting Star Clicks");
        global.drawingScript.activeStarCounter = 1;
        global.drawingScript.starCount = 0;
        global.drawingScript.shouldNextStar = 0;
        global.drawingScript.transformHolder = new List<Vector3>();
    }
    void Update()
    {
        verticalGrid.SetActive(false);
        horizontalGrid.SetActive(false);
        baseStarCount = Random.Range(35, 50);
    }

    public void ClearObstacles() // Get rid of the obstacles
    {
        foreach (GameObject _obstacle in global.obstacleList.ToList())
        {
            Destroy(_obstacle);
        }
    }

    // Added Functionality for what happens if things get deleted in generation
    public void DeletedObstacleReplacement()
    {

    }

    public void DeletedDamageStarReplacement()
    {

    }

    public void DeletedHealthStarReplacement()
    {

    }

    void SpawnObstacle() // Instance obstacles as well
    {
        global.obstacleNewSpawnList = new List<(Transform, Transform)>();
        int obstaclePairCount = 1; // Grab a singular pair
        int _pair = Random.Range(0, 4);
        if (_pair == 0) // Row Pair 1
        {
            for (int i = 0; i < obstaclePairCount; i++)
            {
                int _randintx = Random.Range(0, 4); // Was wonky so I made a variable with random name
                global.obstacleNewSpawnList.Add(obstacleRowPair1[_randintx]);
            }
            foreach ((Transform, Transform) _pointData in global.obstacleNewSpawnList.ToList())
            {
                Vector3 _point1 = _pointData.Item1.position;
                Vector3 _point2 = _pointData.Item2.position;
                Vector3 _spawn = Vector3.zero;
                _spawn.y = _point1.y + (_point2.y - _point1.y) / 2;
                _spawn.x = _point1.x;
                _spawn.z = _point1.z;
                // Now spawn the obstacle
                GameObject obstacle = Instantiate(obstaclePrefab, _spawn, _pointData.Item1.rotation);
            }
        }

        if (_pair == 1) // Row Pair 2
        {
            for (int i = 0; i < obstaclePairCount; i++)
            {
                int _randintx = Random.Range(0, 4);
                global.obstacleNewSpawnList.Add(obstacleRowPair2[_randintx]);
            }
            foreach ((Transform, Transform) _pointData in global.obstacleNewSpawnList.ToList())
            {
                Vector3 _point1 = _pointData.Item1.position;
                Vector3 _point2 = _pointData.Item2.position;
                Vector3 _spawn = Vector3.zero;
                _spawn.y = _point1.y + (_point2.y - _point1.y) / 2;
                _spawn.x = _point1.x;
                _spawn.z = _point1.z;
                // Now spawn the obstacle
                GameObject obstacle = Instantiate(obstaclePrefab, _spawn, _pointData.Item1.rotation);
            }
        }

        if (_pair == 2) // Row Pair 3
        {
            for (int i = 0; i < obstaclePairCount; i++)
            {
                int _randintx = Random.Range(0, 4);
                global.obstacleNewSpawnList.Add(obstacleRowPair3[_randintx]);
            }
            foreach ((Transform, Transform) _pointData in global.obstacleNewSpawnList.ToList())
            {
                Vector3 _point1 = _pointData.Item1.position;
                Vector3 _point2 = _pointData.Item2.position;
                Vector3 _spawn = Vector3.zero;
                _spawn.y = _point1.y + (_point2.y - _point1.y) / 2;
                _spawn.x = _point1.x;
                _spawn.z = _point1.z;
                // Now spawn the obstacle
                GameObject obstacle = Instantiate(obstaclePrefab, _spawn, _pointData.Item1.rotation);
            }
        }
        if (_pair == 3) // Row Pair 4
        {
            for (int i = 0; i < obstaclePairCount; i++)
            {
                int _randintx = Random.Range(0, 4);
                global.obstacleNewSpawnList.Add(obstacleRowPair4[_randintx]);
            }
            foreach ((Transform, Transform) _pointData in global.obstacleNewSpawnList.ToList())
            {
                Vector3 _point1 = _pointData.Item1.position;
                Vector3 _point2 = _pointData.Item2.position;
                Vector3 _spawn = Vector3.zero;
                _spawn.y = _point1.y + (_point2.y - _point1.y) / 2;
                _spawn.x = _point1.x;
                _spawn.z = _point1.z;
                // Now spawn the obstacle
                GameObject obstacle = Instantiate(obstaclePrefab, _spawn, _pointData.Item1.rotation);
            }
        }

        if (_pair == 4) // Row Pair 5
        {
            for (int i = 0; i < obstaclePairCount; i++)
            {
                int _randintx = Random.Range(0, 4); // Was wonky so I made a variable with random name
                global.obstacleNewSpawnList.Add(obstacleRowPair5[_randintx]);
            }
            foreach ((Transform, Transform) _pointData in global.obstacleNewSpawnList.ToList())
            {
                Vector3 _point1 = _pointData.Item1.position;
                Vector3 _point2 = _pointData.Item2.position;
                Vector3 _spawn = Vector3.zero;
                _spawn.y = _point1.y + (_point2.y - _point1.y) / 2;
                _spawn.x = _point1.x;
                _spawn.z = _point1.z;
                // Now spawn the obstacle
                GameObject obstacle = Instantiate(obstaclePrefab, _spawn, _pointData.Item1.rotation);
            }
        }
    }

    public void NewStarMap()
    {
        tempSpawnList = masterRowOriginList;
        ClearStars();
        ClearObstacles();
        starSpawnCount = 0;
        NewSpawnStars();
        NewSpawn(baseStar); // Wave 2 Base Stars
        NewSpawn(actionHealthStar); // Wave 2 Health Stars
        NewSpawn(actionDamageStar); // Wave 2 Damage Stars
        tempSpawnList = new List<Transform>();
    }

    public void ClearStars()
    {
        //Destroy(global.drawingScript.NodeStar.gameObject);, literally had a line to do it.
        foreach (GameObject _star in usedTransform.ToList())
        {
            usedTransform.Remove(_star);
            Destroy(_star);
        }
        if (usedTransform.Count() == 0)
        {
            Debug.Log("Cleared Stars");
        }
        else
        {
            Debug.Log("Error in clearing stars");
            Debug.Log(usedTransform.Count());
        }
        return;
    }

    public void NewSpawn(StarClass star) // Spawning the randomized Stars function 
    {
        if (star.starType == "Star") // Checks to see if star class is Base
        {
            foreach (Transform _transform in newSpawnPointList.ToList()) // Base Stars
            {
                if (starSpawnCount > 38)
                {
                    return;
                }
                else
                {
                    GameObject starToBeSpawned = Instantiate(star.starPrefab, _transform.position, _transform.rotation);
                    Debug.Log("New Random Base Star Spawned!");
                    starSpawnCount++;
                    usedTransform.Add(starToBeSpawned);
                }
            }
        }

        if (star.starType == "HealthStar") // Checks to see if star class given is Health
        {
            foreach (Transform _transform in newSpawnPointList.ToList()) // Base Stars
            {
                if (starSpawnCount > 40)
                {
                    return;
                }
                else
                {
                    GameObject starToBeSpawned = Instantiate(star.starPrefab, _transform.position, _transform.rotation);
                    Debug.Log("New Random Health Star Spawned!");
                    starSpawnCount++;
                    usedTransform.Add(starToBeSpawned);
                }
            }
        }
        if (star.starType == "DamageStar") // Checks to see if the star class given is Damage
        {
            foreach (Transform _transform in newSpawnPointList.ToList()) // Base Stars
            {
                if (starSpawnCount > 44)
                {
                    return;
                }
                else
                {
                    GameObject starToBeSpawned = Instantiate(star.starPrefab, _transform.position, _transform.rotation);
                    Debug.Log("New Random Health Star Spawned!");
                    starSpawnCount++;
                    usedTransform.Add(starToBeSpawned);
                }
            }
        }
    }

    public void ClearPoints()
    {
        foreach (Transform _transform in usedTransformList.ToList())
        {
            global.startingStarSpawnPointList.Remove(_transform);
        }
        Debug.Log("Cleared Points");
    }



    public void GrabNewPoints() // Helper method to grab new points if need be
    {
        ClearPoints();
        newPointsUsed = 1;
        foreach (GameObject GOtoGrabTransform in usedTransform.ToList())
        {
            usedTransformList.Add(GOtoGrabTransform.transform);
        }
        newSpawnPointList.Except(tempSpawnList); // Very handy call from Systems.Linq, removes all elements not in both lists from the original keeps the uniques. 
    }

    public void NewSpawnStars() // Iterate through master list and remove used points from the previous round
    {
        newPointsUsed = 0;
        GrabNewPoints();
        if (newPointsUsed == 1)
        {
            for (int i = 0; i < pointCount; i++)
            {
                newSpawnPointList.Add(masterRowList[Random.Range(0, 340)]);
            }
        }
    }

    public void ClearLines()
    {
        foreach (GameObject _line in global.constellationBuilding.lineFinal.ToList())
        {
            global.constellationBuilding.lineFinal.Remove(_line);
            Destroy(_line);
        }
    }

    public void HardcodedNewStarsSpawn()
    {
        Debug.Log(baseStarCount);
        hardcodeCount += 1;
        if (hardcodeCount == 1) // 2 Attack 2 Heal
        {
            Debug.Log("Instance 1");
            tempSpawnList = masterRowList;
            damageStarDeletedInGeneration = 0; // New Generation so,
            healthStarDeletedInGeneration = 0;
            obstacleDeletedInGeneration = 0; // Need to check for deletion separately each time
            ClearStars();
            ClearObstacles();
            ClearLines();
            starSpawnCount = 0;
            starSpawnCount2 = 0; // Node
            starSpawnCount3 = 0; // Damage
            starSpawnCount4 = 0; // Health
            //starSpawnCount5 = 1; No shield stars for now
            NewSpawnStars();
            SpawnObstacle();
            SpawnObstacle();
            SpawnObstacle();
            numBaseStars = baseStarCount;
            numHealthStars = 2;
            numDamageStars = 2;
            // numShieldStars = 0; 
            NewHCBaseStarSpawn(baseStar, numBaseStars);
            HCDamageStarSpawn(actionDamageStar, numDamageStars);
            HCNodeStarSpawn(nodeStar, 1);
            HCHealthStarSpawn(actionHealthStar, numHealthStars);
            //tempSpawnList = new List<Transform>();
        }
        if (hardcodeCount == 2) // 3 Attack 1 Heal
        {
            Debug.Log("Instance 2");
            tempSpawnList = masterRowList;
            damageStarDeletedInGeneration = 0; // New Generation so,
            healthStarDeletedInGeneration = 0;
            obstacleDeletedInGeneration = 0; // Need to check for deletion separately each time
            ClearStars();
            ClearObstacles();
            ClearLines();
            starSpawnCount = 0;
            starSpawnCount2 = 0; // Node
            starSpawnCount3 = 0; // Damage
            starSpawnCount4 = 0; // Health
            //starSpawnCount5 = 1; No shield stars for now
            NewSpawnStars();
            SpawnObstacle();
            SpawnObstacle();
            SpawnObstacle();
            numBaseStars = baseStarCount;
            numHealthStars = 1;
            numDamageStars = 3;
            // numShieldStars = 0; 
            NewHCBaseStarSpawn(baseStar, numBaseStars);
            HCDamageStarSpawn(actionDamageStar, numDamageStars);
            HCNodeStarSpawn(nodeStar, 1);
            HCHealthStarSpawn(actionHealthStar, numHealthStars);
        }
        if (hardcodeCount == 3) // 3 Attack 1 Heal
        {
            Debug.Log("Instance 3");
            tempSpawnList = masterRowList;
            damageStarDeletedInGeneration = 0; // New Generation so,
            healthStarDeletedInGeneration = 0;
            obstacleDeletedInGeneration = 0; // Need to check for deletion separately each time
            ClearStars();
            ClearObstacles();
            ClearLines();
            starSpawnCount = 0;
            starSpawnCount2 = 0; // Node
            starSpawnCount3 = 0; // Damage
            starSpawnCount4 = 0; // Health
            //starSpawnCount5 = 1; No shield stars for now
            NewSpawnStars();
            SpawnObstacle();
            SpawnObstacle();
            SpawnObstacle();
            numBaseStars = baseStarCount;
            numHealthStars = 1;
            numDamageStars = 3;
            // numShieldStars = 0; 
            NewHCBaseStarSpawn(baseStar, numBaseStars);
            HCNodeStarSpawn(nodeStar, 1);
            HCDamageStarSpawn(actionDamageStar, numDamageStars);
            HCHealthStarSpawn(actionHealthStar, numHealthStars);
        }
        if (hardcodeCount == 4) // 3 Attack 1 Heal
        {
            Debug.Log("Instance 4");
            tempSpawnList = masterRowList;
            damageStarDeletedInGeneration = 0; // New Generation so,
            healthStarDeletedInGeneration = 0;
            obstacleDeletedInGeneration = 0; // Need to check for deletion separately each time
            ClearStars();
            ClearObstacles();
            ClearLines();
            starSpawnCount = 0;
            starSpawnCount2 = 0; // Node
            starSpawnCount3 = 0; // Damage
            starSpawnCount4 = 0; // Health
            //starSpawnCount5 = 1; No shield stars for now
            NewSpawnStars();
            SpawnObstacle();
            SpawnObstacle();
            SpawnObstacle();
            numBaseStars = baseStarCount;
            numHealthStars = 1;
            numDamageStars = 3;
            // numShieldStars = 0; 
            NewHCBaseStarSpawn(baseStar, numBaseStars);
            HCDamageStarSpawn(actionDamageStar, numDamageStars);
            HCNodeStarSpawn(nodeStar, 1);
            HCHealthStarSpawn(actionHealthStar, numHealthStars);
        }
        if (hardcodeCount == 5) // 2 Attack 2 Heal
        {
            Debug.Log("Instance 5");
            tempSpawnList = masterRowList;
            damageStarDeletedInGeneration = 0; // New Generation so,
            healthStarDeletedInGeneration = 0;
            obstacleDeletedInGeneration = 0; // Need to check for deletion separately each time
            ClearStars();
            ClearObstacles();
            ClearLines();
            starSpawnCount = 0;
            starSpawnCount2 = 0; // Node
            starSpawnCount3 = 0; // Damage
            starSpawnCount4 = 0; // Health
            //starSpawnCount5 = 1; No shield stars for now
            NewSpawnStars();
            SpawnObstacle();
            SpawnObstacle();
            SpawnObstacle();
            numBaseStars = baseStarCount;
            numHealthStars = 2;
            numDamageStars = 2;
            // numShieldStars = 0; 
            NewHCBaseStarSpawn(baseStar, numBaseStars);
            HCDamageStarSpawn(actionDamageStar, numDamageStars);
            HCNodeStarSpawn(nodeStar, 1);
            HCHealthStarSpawn(actionHealthStar, numHealthStars);
        }
        if (hardcodeCount == 6) // 3 Attack 1 Heal
        {
            Debug.Log("Instance 6");
            tempSpawnList = masterRowList;
            damageStarDeletedInGeneration = 0; // New Generation so,
            healthStarDeletedInGeneration = 0;
            obstacleDeletedInGeneration = 0; // Need to check for deletion separately each time
            ClearStars();
            ClearObstacles();
            ClearLines();
            starSpawnCount = 0;
            starSpawnCount2 = 0; // Node
            starSpawnCount3 = 0; // Damage
            starSpawnCount4 = 0; // Health
            //starSpawnCount5 = 1; No shield stars for now
            NewSpawnStars();
            SpawnObstacle();
            SpawnObstacle();
            SpawnObstacle();
            numBaseStars = baseStarCount;
            numHealthStars = 1;
            numDamageStars = 3;
            // numShieldStars = 0; 
            NewHCBaseStarSpawn(baseStar, numBaseStars);
            HCDamageStarSpawn(actionDamageStar, numDamageStars);
            HCNodeStarSpawn(nodeStar, 1);
            HCHealthStarSpawn(actionHealthStar, numHealthStars);
        }
        if (hardcodeCount == 7) // 3 Attack 1 Heal
        {
            Debug.Log("Instance 7");
            tempSpawnList = masterRowList;
            damageStarDeletedInGeneration = 0; // New Generation so,
            healthStarDeletedInGeneration = 0;
            obstacleDeletedInGeneration = 0; // Need to check for deletion separately each time
            ClearStars();
            ClearObstacles();
            ClearLines();
            starSpawnCount = 0;
            starSpawnCount2 = 0; // Node
            starSpawnCount3 = 0; // Damage
            starSpawnCount4 = 0; // Health
            //starSpawnCount5 = 1; No shield stars for now
            NewSpawnStars();
            SpawnObstacle();
            SpawnObstacle();
            SpawnObstacle();
            numBaseStars = baseStarCount;
            numHealthStars = 1;
            numDamageStars = 3;
            // numShieldStars = 0; 
            NewHCBaseStarSpawn(baseStar, numBaseStars);
            HCDamageStarSpawn(actionDamageStar, numDamageStars);
            HCNodeStarSpawn(nodeStar, 1);
            HCHealthStarSpawn(actionHealthStar, numHealthStars);
        }
        if (hardcodeCount == 8) // 2 Attack 2 Heal
        {

            Debug.Log("Instance 8");
            tempSpawnList = masterRowList;
            damageStarDeletedInGeneration = 0; // New Generation so,
            healthStarDeletedInGeneration = 0;
            obstacleDeletedInGeneration = 0; // Need to check for deletion separately each time
            ClearStars();
            ClearObstacles();
            ClearLines();
            starSpawnCount = 0;
            starSpawnCount2 = 0; // Node
            starSpawnCount3 = 0; // Damage
            starSpawnCount4 = 0; // Health
            //starSpawnCount5 = 1; No shield stars for now
            NewSpawnStars();
            SpawnObstacle();
            SpawnObstacle();
            SpawnObstacle();
            numBaseStars = baseStarCount;
            numHealthStars = 1;
            numDamageStars = 3;
            // numShieldStars = 0; 
            NewHCBaseStarSpawn(baseStar, numBaseStars);
            HCDamageStarSpawn(actionDamageStar, numDamageStars);
            HCNodeStarSpawn(nodeStar, 1);
            HCHealthStarSpawn(actionHealthStar, numHealthStars);
        }
        if (hardcodeCount == 9) // 3 Attack 1 Heal
        {
            Debug.Log("Instance 9");
            tempSpawnList = masterRowList;
            damageStarDeletedInGeneration = 0; // New Generation so,
            healthStarDeletedInGeneration = 0;
            obstacleDeletedInGeneration = 0; // Need to check for deletion separately each time
            ClearStars();
            ClearObstacles();
            ClearLines();
            starSpawnCount = 0;
            starSpawnCount2 = 0; // Node
            starSpawnCount3 = 0; // Damage
            starSpawnCount4 = 0; // Health
            //starSpawnCount5 = 1; No shield stars for now
            NewSpawnStars();
            SpawnObstacle();
            SpawnObstacle();
            SpawnObstacle();
            numBaseStars = baseStarCount;
            numHealthStars = 1;
            numDamageStars = 3;
            // numShieldStars = 0; 
            NewHCBaseStarSpawn(baseStar, numBaseStars);
            HCDamageStarSpawn(actionDamageStar, numDamageStars);
            HCNodeStarSpawn(nodeStar, 1);
            HCHealthStarSpawn(actionHealthStar, numHealthStars);
        }
        if (hardcodeCount == 10) // 3 Attack 1 Heal
        {
            Debug.Log("Instance 10");
            tempSpawnList = masterRowList;
            damageStarDeletedInGeneration = 0; // New Generation so,
            healthStarDeletedInGeneration = 0;
            obstacleDeletedInGeneration = 0; // Need to check for deletion separately each time
            ClearStars();
            ClearObstacles();
            ClearLines();
            starSpawnCount = 0;
            starSpawnCount2 = 0; // Node
            starSpawnCount3 = 0; // Damage
            starSpawnCount4 = 0; // Health
            //starSpawnCount5 = 1; No shield stars for now
            NewSpawnStars();
            SpawnObstacle();
            SpawnObstacle();
            SpawnObstacle();
            numBaseStars = baseStarCount;
            numHealthStars = 1;
            numDamageStars = 3;
            // numShieldStars = 0; 
            NewHCBaseStarSpawn(baseStar, numBaseStars);
            HCDamageStarSpawn(actionDamageStar, numDamageStars);
            HCNodeStarSpawn(nodeStar, 1);
            HCHealthStarSpawn(actionHealthStar, numHealthStars);
            hardcodeCount = 0; // Reset count and cycle through again 
        }
    }

    public void HCNodeStarSpawn(StarClass _star, int _starNum = 1)
    {
        List<Transform> _NodeStarList = new List<Transform>();
        for (int i = 0; i < _starNum; i++)
        {
            int _randintx = Random.Range(0, 340);
            _NodeStarList.Add(masterRowList[_randintx]);
        }
        foreach (Transform _transform in _NodeStarList.ToList()) // NodeStar, needs to be spawned
        {
            if (starSpawnCount2 > 0)
            {
                return;
            }
            else
            {
                GameObject nodeStarToBeSpawned = Instantiate(nodeStar.starPrefab, _transform.position, _transform.rotation);
                global.drawingScript.NodeStar = nodeStarToBeSpawned.GetComponent<Star>();
                Debug.Log("New Random NodeStar Spawned!");
                starSpawnCount2++;
                usedTransform.Add(nodeStarToBeSpawned);
            }
        }
    }

    public void HCHealthStarSpawn(StarClass _star, int _healthNum)
    {
        List<Transform> _healthList = new List<Transform>();
        for (int i = 0; i < _healthNum; i++)
        {
            int _randintx = Random.Range(0, 340);
            _healthList.Add(masterRowList[_randintx]);
        }
        foreach (Transform _transform in _healthList.ToList()) // Health Stars x2
        {
            if (starSpawnCount3 > _healthNum)
            {
                return;
            }
            else
            {
                GameObject starToBeSpawned = Instantiate(actionHealthStar.starPrefab, _transform.position, _transform.rotation);
                Debug.Log("New Random Health Star Spawned!");
                starSpawnCount3++;
                usedTransform.Add(starToBeSpawned);
            }
        }
    }

    public void HCDamageStarSpawn(StarClass _star, int _damageNum)
    {
        List<Transform> _damageList = new List<Transform>();
        for (int i = 0; i < _damageNum; i++)
        {
            int _randintx = Random.Range(0, 340);
            _damageList.Add(masterRowList[_randintx]);
        }
        foreach (Transform _transform in _damageList.ToList()) // Damage Stars x2
        {
            if (starSpawnCount4 > _damageNum)
            {
                return;
            }
            else
            {
                GameObject starToBeSpawned = Instantiate(actionDamageStar.starPrefab, _transform.position, _transform.rotation);
                Debug.Log("New Random Damage Star Spawned!");
                starSpawnCount4++;
                usedTransform.Add(starToBeSpawned);
            }
        }
    }

    public void HCDamageShieldSpawn(StarClass _star, int _shieldNum)
    {
        List<Transform> _shieldList = new List<Transform>();
        for (int i = 0; i < _shieldNum; i++)
        {
            int _randintx = Random.Range(0, 340);
            _shieldList.Add(masterRowList[_randintx]);
        }
        foreach (Transform _transform in _shieldList.ToList()) // For shieldstars to be implemented
        {
            if (starSpawnCount5 > _shieldNum)
            {
                return;
            }
            else
            {
                Debug.LogError("Not Supposed to Occur Yet");
                GameObject starToBeSpawned = Instantiate(shieldStar.starPrefab, _transform.position, _transform.rotation);
                Debug.Log("New Random Damage Star Spawned!");
                starSpawnCount5++;
                usedTransform.Add(starToBeSpawned);
            }
        }
    }


    public void NewHCBaseStarSpawn(StarClass _star, int _baseNum) // HC Stands for Hardcoded
    {
        List<Transform> _baseStarList = new List<Transform>();
        for (int i = 0; i < _baseNum; i++)
        {
            int _randintx = Random.Range(0, 340);
            _baseStarList.Add(masterRowList[_randintx]);
        }
        foreach (Transform _transform in _baseStarList.ToList()) // Base Stars
        {
            if (starSpawnCount > _baseNum)
            {
                return;
            }
            else
            {
                GameObject starToBeSpawned = Instantiate(baseStar.starPrefab, _transform.position, _transform.rotation);
                Debug.Log("New Random Base Star Spawned!");
                starSpawnCount++;
                usedTransform.Add(starToBeSpawned);
            }
        }
    }

    /// <summary>
    /// Note for later rebuild that occured while doing this. Can trigger a lot of startup behavior in Awake calls and then have that be the "loading" of the level. 
    /// Have a loading bar screen that only untriggers when each necessary Awake call triggers to tell it to stop, this way low end machines aren't subject to bad behavior
    /// </summary>

    public void CollateStarLists() // Put all points in one list to iterate through
    {
        foreach (Transform _transform in row1.ToList())// Add Row 1
        {
            masterRowList.Add(_transform);
        }
        foreach (Transform _transform in row2.ToList()) // Add Row 2
        {
            masterRowList.Add(_transform);
        }
        foreach (Transform _transform in row3.ToList()) // Add Row 3
        {
            masterRowList.Add(_transform);
        }
        foreach (Transform _transform in row4.ToList()) // Add Row 4
        {
            masterRowList.Add(_transform);
        }
        foreach (Transform _transform in row5.ToList()) // Add Row 5
        {
            masterRowList.Add(_transform);
        }
        foreach (Transform _transform in row6.ToList()) // Add Row 6
        {
            masterRowList.Add(_transform);
        }
        foreach (Transform _transform in row7.ToList()) // Add Row 7
        {
            masterRowList.Add(_transform);
        }
        foreach (Transform _transform in row8.ToList()) // Add Row 8
        {
            masterRowList.Add(_transform);
        }
        foreach (Transform _transform in row9.ToList()) // Add Row 9
        {
            masterRowList.Add(_transform);
        }
        foreach (Transform _transform in row10.ToList()) // Add Row 10
        {
            masterRowList.Add(_transform);
        }
        foreach (Transform _transform in row11.ToList()) // Add Row 11
        {
            masterRowList.Add(_transform);
        }
        foreach (Transform _transform in row12.ToList()) // Add Row 12
        {
            masterRowList.Add(_transform);
        }
        foreach (Transform _transform in row13.ToList()) // Add Row 13
        {
            masterRowList.Add(_transform);
        }
        foreach (Transform _transform in row14.ToList()) // Add Row 14
        {
            masterRowList.Add(_transform);
        }
        foreach (Transform _transform in row15.ToList()) // Add Row 15
        {
            masterRowList.Add(_transform);
        }
        foreach (Transform _transform in row16.ToList()) // Add Row 16
        {
            masterRowList.Add(_transform);
        }
        foreach (Transform _transform in row17.ToList()) // Add Row 17
        {
            masterRowList.Add(_transform);
        }
        Debug.Log(masterRowList.Count());
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

    // Enemy functionality

    public void LegionaryEffect()
    {

    }

    // First Star Map Counts 
    // Normal Stars = 39
    // Health Stars = 2
    // Damage Stars = 4

    // 45 Total / 340

    public void HCObstacleSwitcher(int _currentMapNum) // int 1-20
    {
        if (_currentMapNum == 1) // Map 1
        {
            obstaclesForMap1.SetActive(true);
            obstaclesForMap2.SetActive(false);
            obstaclesForMap3.SetActive(false);
            obstaclesForMap4.SetActive(false);
            obstaclesForMap5.SetActive(false);
            obstaclesForMap6.SetActive(false);
            obstaclesForMap7.SetActive(false);
            obstaclesForMap8.SetActive(false);
            obstaclesForMap9.SetActive(false);
            obstaclesForMap10.SetActive(false);
            obstaclesForMap11.SetActive(false);
            obstaclesForMap12.SetActive(false);
            obstaclesForMap13.SetActive(false);
            obstaclesForMap14.SetActive(false);
            obstaclesForMap15.SetActive(false);
            obstaclesForMap16.SetActive(false);
            obstaclesForMap17.SetActive(false);
            obstaclesForMap18.SetActive(false);
            obstaclesForMap19.SetActive(false);
            obstaclesForMap20.SetActive(false);
            return;
        }

        if (_currentMapNum == 2) // Map 2
        {
            obstaclesForMap1.SetActive(false);
            obstaclesForMap2.SetActive(true);
            obstaclesForMap3.SetActive(false);
            obstaclesForMap4.SetActive(false);
            obstaclesForMap5.SetActive(false);
            obstaclesForMap6.SetActive(false);
            obstaclesForMap7.SetActive(false);
            obstaclesForMap8.SetActive(false);
            obstaclesForMap9.SetActive(false);
            obstaclesForMap10.SetActive(false);
            obstaclesForMap11.SetActive(false);
            obstaclesForMap12.SetActive(false);
            obstaclesForMap13.SetActive(false);
            obstaclesForMap14.SetActive(false);
            obstaclesForMap15.SetActive(false);
            obstaclesForMap16.SetActive(false);
            obstaclesForMap17.SetActive(false);
            obstaclesForMap18.SetActive(false);
            obstaclesForMap19.SetActive(false);
            obstaclesForMap20.SetActive(false);
            return;
        }

        if (_currentMapNum == 3) // Map 3
        {
            obstaclesForMap1.SetActive(false);
            obstaclesForMap2.SetActive(false);
            obstaclesForMap3.SetActive(true);
            obstaclesForMap4.SetActive(false);
            obstaclesForMap5.SetActive(false);
            obstaclesForMap6.SetActive(false);
            obstaclesForMap7.SetActive(false);
            obstaclesForMap8.SetActive(false);
            obstaclesForMap9.SetActive(false);
            obstaclesForMap10.SetActive(false);
            obstaclesForMap11.SetActive(false);
            obstaclesForMap12.SetActive(false);
            obstaclesForMap13.SetActive(false);
            obstaclesForMap14.SetActive(false);
            obstaclesForMap15.SetActive(false);
            obstaclesForMap16.SetActive(false);
            obstaclesForMap17.SetActive(false);
            obstaclesForMap18.SetActive(false);
            obstaclesForMap19.SetActive(false);
            obstaclesForMap20.SetActive(false);
            return;
        }

        if (_currentMapNum == 4) // Map 4
        {
            obstaclesForMap1.SetActive(false);
            obstaclesForMap2.SetActive(false);
            obstaclesForMap3.SetActive(false);
            obstaclesForMap4.SetActive(true);
            obstaclesForMap5.SetActive(false);
            obstaclesForMap6.SetActive(false);
            obstaclesForMap7.SetActive(false);
            obstaclesForMap8.SetActive(false);
            obstaclesForMap9.SetActive(false);
            obstaclesForMap10.SetActive(false);
            obstaclesForMap11.SetActive(false);
            obstaclesForMap12.SetActive(false);
            obstaclesForMap13.SetActive(false);
            obstaclesForMap14.SetActive(false);
            obstaclesForMap15.SetActive(false);
            obstaclesForMap16.SetActive(false);
            obstaclesForMap17.SetActive(false);
            obstaclesForMap18.SetActive(false);
            obstaclesForMap19.SetActive(false);
            obstaclesForMap20.SetActive(false);
            return;
        }

        if (_currentMapNum == 5) // Map 5
        {
            obstaclesForMap1.SetActive(false);
            obstaclesForMap2.SetActive(false);
            obstaclesForMap3.SetActive(false);
            obstaclesForMap4.SetActive(false);
            obstaclesForMap5.SetActive(true);
            obstaclesForMap6.SetActive(false);
            obstaclesForMap7.SetActive(false);
            obstaclesForMap8.SetActive(false);
            obstaclesForMap9.SetActive(false);
            obstaclesForMap10.SetActive(false);
            obstaclesForMap11.SetActive(false);
            obstaclesForMap12.SetActive(false);
            obstaclesForMap13.SetActive(false);
            obstaclesForMap14.SetActive(false);
            obstaclesForMap15.SetActive(false);
            obstaclesForMap16.SetActive(false);
            obstaclesForMap17.SetActive(false);
            obstaclesForMap18.SetActive(false);
            obstaclesForMap19.SetActive(false);
            obstaclesForMap20.SetActive(false);
            return;
        }

        if (_currentMapNum == 6) // Map 6
        {
            obstaclesForMap1.SetActive(false);
            obstaclesForMap2.SetActive(false);
            obstaclesForMap3.SetActive(false);
            obstaclesForMap4.SetActive(false);
            obstaclesForMap5.SetActive(false);
            obstaclesForMap6.SetActive(true);
            obstaclesForMap7.SetActive(false);
            obstaclesForMap8.SetActive(false);
            obstaclesForMap9.SetActive(false);
            obstaclesForMap10.SetActive(false);
            obstaclesForMap11.SetActive(false);
            obstaclesForMap12.SetActive(false);
            obstaclesForMap13.SetActive(false);
            obstaclesForMap14.SetActive(false);
            obstaclesForMap15.SetActive(false);
            obstaclesForMap16.SetActive(false);
            obstaclesForMap17.SetActive(false);
            obstaclesForMap18.SetActive(false);
            obstaclesForMap19.SetActive(false);
            obstaclesForMap20.SetActive(false);
            return;
        }

        if (_currentMapNum == 7) // Map 7
        {
            obstaclesForMap1.SetActive(false);
            obstaclesForMap2.SetActive(false);
            obstaclesForMap3.SetActive(false);
            obstaclesForMap4.SetActive(false);
            obstaclesForMap5.SetActive(false);
            obstaclesForMap6.SetActive(false);
            obstaclesForMap7.SetActive(true);
            obstaclesForMap8.SetActive(false);
            obstaclesForMap9.SetActive(false);
            obstaclesForMap10.SetActive(false);
            obstaclesForMap11.SetActive(false);
            obstaclesForMap12.SetActive(false);
            obstaclesForMap13.SetActive(false);
            obstaclesForMap14.SetActive(false);
            obstaclesForMap15.SetActive(false);
            obstaclesForMap16.SetActive(false);
            obstaclesForMap17.SetActive(false);
            obstaclesForMap18.SetActive(false);
            obstaclesForMap19.SetActive(false);
            obstaclesForMap20.SetActive(false);
            return;
        }

        if (_currentMapNum == 8) // Map 8
        {
            obstaclesForMap1.SetActive(false);
            obstaclesForMap2.SetActive(false);
            obstaclesForMap3.SetActive(false);
            obstaclesForMap4.SetActive(false);
            obstaclesForMap5.SetActive(false);
            obstaclesForMap6.SetActive(false);
            obstaclesForMap7.SetActive(false);
            obstaclesForMap8.SetActive(true);
            obstaclesForMap9.SetActive(false);
            obstaclesForMap10.SetActive(false);
            obstaclesForMap11.SetActive(false);
            obstaclesForMap12.SetActive(false);
            obstaclesForMap13.SetActive(false);
            obstaclesForMap14.SetActive(false);
            obstaclesForMap15.SetActive(false);
            obstaclesForMap16.SetActive(false);
            obstaclesForMap17.SetActive(false);
            obstaclesForMap18.SetActive(false);
            obstaclesForMap19.SetActive(false);
            obstaclesForMap20.SetActive(false);
            return;
        }

        if (_currentMapNum == 9) // Map 9
        {
            obstaclesForMap1.SetActive(false);
            obstaclesForMap2.SetActive(false);
            obstaclesForMap3.SetActive(false);
            obstaclesForMap4.SetActive(false);
            obstaclesForMap5.SetActive(false);
            obstaclesForMap6.SetActive(false);
            obstaclesForMap7.SetActive(false);
            obstaclesForMap8.SetActive(false);
            obstaclesForMap9.SetActive(true);
            obstaclesForMap10.SetActive(false);
            obstaclesForMap11.SetActive(false);
            obstaclesForMap12.SetActive(false);
            obstaclesForMap13.SetActive(false);
            obstaclesForMap14.SetActive(false);
            obstaclesForMap15.SetActive(false);
            obstaclesForMap16.SetActive(false);
            obstaclesForMap17.SetActive(false);
            obstaclesForMap18.SetActive(false);
            obstaclesForMap19.SetActive(false);
            obstaclesForMap20.SetActive(false);
            return;
        }

        if (_currentMapNum == 10) // Map 10
        {
            obstaclesForMap1.SetActive(false);
            obstaclesForMap2.SetActive(false);
            obstaclesForMap3.SetActive(false);
            obstaclesForMap4.SetActive(false);
            obstaclesForMap5.SetActive(false);
            obstaclesForMap6.SetActive(false);
            obstaclesForMap7.SetActive(false);
            obstaclesForMap8.SetActive(false);
            obstaclesForMap9.SetActive(false);
            obstaclesForMap10.SetActive(true);
            obstaclesForMap11.SetActive(false);
            obstaclesForMap12.SetActive(false);
            obstaclesForMap13.SetActive(false);
            obstaclesForMap14.SetActive(false);
            obstaclesForMap15.SetActive(false);
            obstaclesForMap16.SetActive(false);
            obstaclesForMap17.SetActive(false);
            obstaclesForMap18.SetActive(false);
            obstaclesForMap19.SetActive(false);
            obstaclesForMap20.SetActive(false);
            return;
        }

        if (_currentMapNum == 11) // Map 11
        {
            obstaclesForMap1.SetActive(false);
            obstaclesForMap2.SetActive(false);
            obstaclesForMap3.SetActive(false);
            obstaclesForMap4.SetActive(false);
            obstaclesForMap5.SetActive(false);
            obstaclesForMap6.SetActive(false);
            obstaclesForMap7.SetActive(false);
            obstaclesForMap8.SetActive(false);
            obstaclesForMap9.SetActive(false);
            obstaclesForMap10.SetActive(false);
            obstaclesForMap11.SetActive(true);
            obstaclesForMap12.SetActive(false);
            obstaclesForMap13.SetActive(false);
            obstaclesForMap14.SetActive(false);
            obstaclesForMap15.SetActive(false);
            obstaclesForMap16.SetActive(false);
            obstaclesForMap17.SetActive(false);
            obstaclesForMap18.SetActive(false);
            obstaclesForMap19.SetActive(false);
            obstaclesForMap20.SetActive(false);
            return;
        }

        if (_currentMapNum == 12) // Map 12
        {
            obstaclesForMap1.SetActive(false);
            obstaclesForMap2.SetActive(false);
            obstaclesForMap3.SetActive(false);
            obstaclesForMap4.SetActive(false);
            obstaclesForMap5.SetActive(false);
            obstaclesForMap6.SetActive(false);
            obstaclesForMap7.SetActive(false);
            obstaclesForMap8.SetActive(false);
            obstaclesForMap9.SetActive(false);
            obstaclesForMap10.SetActive(false);
            obstaclesForMap11.SetActive(false);
            obstaclesForMap12.SetActive(true);
            obstaclesForMap13.SetActive(false);
            obstaclesForMap14.SetActive(false);
            obstaclesForMap15.SetActive(false);
            obstaclesForMap16.SetActive(false);
            obstaclesForMap17.SetActive(false);
            obstaclesForMap18.SetActive(false);
            obstaclesForMap19.SetActive(false);
            obstaclesForMap20.SetActive(false);
            return;
        }

        if (_currentMapNum == 13) // Map 13
        {
            obstaclesForMap1.SetActive(false);
            obstaclesForMap2.SetActive(false);
            obstaclesForMap3.SetActive(false);
            obstaclesForMap4.SetActive(false);
            obstaclesForMap5.SetActive(false);
            obstaclesForMap6.SetActive(false);
            obstaclesForMap7.SetActive(false);
            obstaclesForMap8.SetActive(false);
            obstaclesForMap9.SetActive(false);
            obstaclesForMap10.SetActive(false);
            obstaclesForMap11.SetActive(false);
            obstaclesForMap12.SetActive(false);
            obstaclesForMap13.SetActive(true);
            obstaclesForMap14.SetActive(false);
            obstaclesForMap15.SetActive(false);
            obstaclesForMap16.SetActive(false);
            obstaclesForMap17.SetActive(false);
            obstaclesForMap18.SetActive(false);
            obstaclesForMap19.SetActive(false);
            obstaclesForMap20.SetActive(false);
            return;
        }

        if (_currentMapNum == 14) // Map 14
        {
            obstaclesForMap1.SetActive(false);
            obstaclesForMap2.SetActive(false);
            obstaclesForMap3.SetActive(false);
            obstaclesForMap4.SetActive(false);
            obstaclesForMap5.SetActive(false);
            obstaclesForMap6.SetActive(false);
            obstaclesForMap7.SetActive(false);
            obstaclesForMap8.SetActive(false);
            obstaclesForMap9.SetActive(false);
            obstaclesForMap10.SetActive(true);
            obstaclesForMap11.SetActive(false);
            obstaclesForMap12.SetActive(false);
            obstaclesForMap13.SetActive(false);
            obstaclesForMap14.SetActive(false);
            obstaclesForMap15.SetActive(false);
            obstaclesForMap16.SetActive(false);
            obstaclesForMap17.SetActive(false);
            obstaclesForMap18.SetActive(false);
            obstaclesForMap19.SetActive(false);
            obstaclesForMap20.SetActive(false);
            return;
        }

        if (_currentMapNum == 15) // Map 15
        {
            obstaclesForMap1.SetActive(false);
            obstaclesForMap2.SetActive(false);
            obstaclesForMap3.SetActive(false);
            obstaclesForMap4.SetActive(false);
            obstaclesForMap5.SetActive(false);
            obstaclesForMap6.SetActive(false);
            obstaclesForMap7.SetActive(false);
            obstaclesForMap8.SetActive(false);
            obstaclesForMap9.SetActive(false);
            obstaclesForMap10.SetActive(false);
            obstaclesForMap11.SetActive(false);
            obstaclesForMap12.SetActive(false);
            obstaclesForMap13.SetActive(false);
            obstaclesForMap14.SetActive(false);
            obstaclesForMap15.SetActive(true);
            obstaclesForMap16.SetActive(false);
            obstaclesForMap17.SetActive(false);
            obstaclesForMap18.SetActive(false);
            obstaclesForMap19.SetActive(false);
            obstaclesForMap20.SetActive(false);
            return;
        }
    }


    public void HCMapPicker()
    {
        mainNodeStar = global.drawingScript.NodeStar;
        int _map = Random.Range(1, 9); // Needs to be max range +1;
        if (_map == 1) // Map 1
        {
            Debug.Log("Map 1 Picked");
            ClearStars();
            ClearPoints();
            ClearLines();
            starSpawnCount = 0;
            HCObstacleSwitcher(1);
            SpawnStar(baseStar);
            SpawnStar(actionHealthStar);
            SpawnStar(actionDamageStar);
        }
        if (_map == 2) // Map 2, just damage
        {
            Debug.Log("Map 2 Picked");
            ClearStars();
            ClearPoints();
            ClearLines();
            starSpawnCount = 0;
            HCObstacleSwitcher(2);
            HCMap2(baseStar);
            HCMap2(actionDamageStar);
            HCMap2(actionHealthStar);
            HCMap2(shieldStar);
        }
        if (_map == 3) // Map 3
        {
            Debug.Log("Map 3 Picked");
            ClearStars();
            ClearPoints();
            ClearLines();
            starSpawnCount = 0;
            HCObstacleSwitcher(3);
            HCMap3(baseStar);
            HCMap3(actionDamageStar);
            HCMap3(actionHealthStar);
            HCMap3(shieldStar);
        }
        if (_map == 4) // Map 4
        {
            Debug.Log("Map 4 Picked");
            ClearStars();
            ClearPoints();
            ClearLines();
            starSpawnCount = 0;
            HCObstacleSwitcher(4);
            HCMap4(baseStar);
            HCMap4(actionDamageStar);
            HCMap4(shieldStar);
        }
        if (_map == 5) // Map 5
        {
            Debug.Log("Map 5 Picked");
            ClearStars();
            ClearPoints();
            ClearLines();
            starSpawnCount = 0;
            HCObstacleSwitcher(5);
            HCMap5(baseStar);
            HCMap5(actionDamageStar);
            HCMap5(actionHealthStar);
            HCMap5(shieldStar);
        }
        if (_map == 6) // Map 6
        {
            Debug.Log("Map 6 Picked");
            ClearStars();
            ClearPoints();
            ClearLines();
            starSpawnCount = 0;
            HCObstacleSwitcher(6);
            HCMap6(baseStar);
            HCMap6(actionDamageStar);
        }
        if (_map == 7) // Map 7
        {
            Debug.Log("Map 7 Picked");
            ClearStars();
            ClearPoints();
            ClearLines();
            starSpawnCount = 0;
            HCObstacleSwitcher(7);
            HCMap7(baseStar);
            HCMap7(actionDamageStar);
            HCMap7(actionHealthStar);
        }
        if (_map == 8) // Map 8
        {
            Debug.Log("Map 8 Picked");
            ClearStars();
            ClearPoints();
            ClearLines();
            starSpawnCount = 0;
            HCObstacleSwitcher(8);
            HCMap8(baseStar);
            HCMap8(actionDamageStar);
            HCMap8(actionHealthStar);
        }
        if (_map == 9) // Map 9
        {
            Debug.Log("Map 9 Picked");
            ClearStars();
            ClearPoints();
            ClearLines();
            starSpawnCount = 0;
            HCObstacleSwitcher(9);
            SpawnStar(baseStar);
            SpawnStar(actionHealthStar);
            SpawnStar(actionDamageStar);
        }
        if (_map == 10) // Map 10
        {
            Debug.Log("Map 10 Picked");
            ClearStars();
            ClearPoints();
            ClearLines();
            starSpawnCount = 0;
            HCObstacleSwitcher(10);
            SpawnStar(baseStar);
            SpawnStar(actionHealthStar);
            SpawnStar(actionDamageStar);
        }
        if (_map == 11) // Map 11
        {
            Debug.Log("Map 11 Picked");
            ClearStars();
            ClearPoints();
            ClearLines();
            starSpawnCount = 0;
            HCObstacleSwitcher(11);
            SpawnStar(baseStar);
            SpawnStar(actionHealthStar);
            SpawnStar(actionDamageStar);
        }
        if (_map == 12) // Map 12
        {
            Debug.Log("Map 12 Picked");
            ClearStars();
            ClearPoints();
            ClearLines();
            starSpawnCount = 0;
            HCObstacleSwitcher(12);
            SpawnStar(baseStar);
            SpawnStar(actionHealthStar);
            SpawnStar(actionDamageStar);
        }
        if (_map == 13) // Map 13
        {
            Debug.Log("Map 13 Picked");
            ClearStars();
            ClearPoints();
            ClearLines();
            starSpawnCount = 0;
            HCObstacleSwitcher(13);
            SpawnStar(baseStar);
            SpawnStar(actionHealthStar);
            SpawnStar(actionDamageStar);
        }
        if (_map == 14) // Map 14
        {
            Debug.Log("Map 14 Picked");
            ClearStars();
            ClearPoints();
            ClearLines();
            starSpawnCount = 0;
            HCObstacleSwitcher(14);
            SpawnStar(baseStar);
            SpawnStar(actionHealthStar);
            SpawnStar(actionDamageStar);
        }
        if (_map == 15) // Map 15
        {
            Debug.Log("Map 15 Picked");
            ClearStars();
            ClearPoints();
            ClearLines();
            starSpawnCount = 0;
            HCObstacleSwitcher(15);
            SpawnStar(baseStar);
            SpawnStar(actionHealthStar);
            SpawnStar(actionDamageStar);
        }
    }

    void SpawnStar(StarClass star) // Hand Built Calls Per Level, meaning we have to manually change this to load as we require it to change
    {
        if (starSpawnCount == 0) // Starts at 0
        {
            GameObject starToBeSpawned1 = Instantiate(star.starPrefab, starSpawnPoint3_1.position, starSpawnPoint3_1.rotation); // By creating it here, it doesn't mess with the other stars
            global.startingStarSpawnPointList.Add(starSpawnPoint3_1);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned1);
        }
        if (starSpawnCount == 1)
        {
            GameObject starToBeSpawned2 = Instantiate(star.starPrefab, starSpawnPoint15_1.position, starSpawnPoint15_1.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint15_1);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned2);
        }
        if (starSpawnCount == 2)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint19_1.position, starSpawnPoint19_1.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint19_1);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 3)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_2.position, starSpawnPoint6_2.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint6_2);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 4)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_2.position, starSpawnPoint12_2.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint12_2);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 5) // Adding more past this
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint1_3.position, starSpawnPoint1_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint1_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 6)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_3.position, starSpawnPoint17_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint17_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 7)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_5.position, starSpawnPoint8_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 8)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint11_5.position, starSpawnPoint11_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint11_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 9)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint20_5.position, starSpawnPoint20_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint20_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 10)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_6.position, starSpawnPoint5_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 11)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_6.position, starSpawnPoint10_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 12)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_4.position, starSpawnPoint2_4.rotation); // Accidentally skipped Row 4, it's okay to do here
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint2_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 13)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_8.position, starSpawnPoint6_8.rotation); // Starting again with row 8
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_8);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 14)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint9_8.position, starSpawnPoint9_8.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint9_8);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 15) 
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_8.position, starSpawnPoint16_8.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_8);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 16)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_9.position, starSpawnPoint3_9.rotation); // Row 9
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 17)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint13_9.position, starSpawnPoint13_9.rotation);

            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint13_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 18)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint20_9.position, starSpawnPoint20_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint20_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 19)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_10.position, starSpawnPoint7_10.rotation); // Row 10
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 20)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint11_10.position, starSpawnPoint11_10.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint11_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 21)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_10.position, starSpawnPoint15_10.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 22)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_11.position, starSpawnPoint2_11.rotation); // Pick up with Row 11
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint2_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 23)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint19_11.position, starSpawnPoint19_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint19_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 24)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_12.position, starSpawnPoint5_12.rotation); // Row 12
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_12);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 25)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_12.position, starSpawnPoint16_12.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_12);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 26)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint9_13.position, starSpawnPoint9_13.rotation); // Row 13
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint9_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 27)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint13_13.position, starSpawnPoint13_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint13_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 28)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint1_14.position, starSpawnPoint1_14.rotation); // Row 14
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint1_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 29)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_14.position, starSpawnPoint4_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 30)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_14.position, starSpawnPoint17_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint17_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 31)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_15.position, starSpawnPoint10_15.rotation); // Row 15
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_15);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 32)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_15.position, starSpawnPoint7_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_15);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 33)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_15.position, starSpawnPoint12_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_15);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 34)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_16.position, starSpawnPoint2_16.rotation); // Row 16
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint2_16);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 35) // Added 10, now 36
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_16.position, starSpawnPoint15_16.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_16);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 36)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_17.position, starSpawnPoint8_17.rotation); // Row 17
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_17);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 37)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint19_17.position, starSpawnPoint19_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint19_17);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 38)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint14_4.position, starSpawnPoint14_4.rotation); // Forgotten point
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint14_4);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 39) // Health Star Start 
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_4.position, starSpawnPoint17_4.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint17_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 40) // Health Star End
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_13.position, starSpawnPoint16_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_13);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 41) // Damage Star Start
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_3.position, starSpawnPoint5_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 42) // Damage Star End
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_7.position, starSpawnPoint12_7.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_7);
            usedTransform.Add(starToBeSpawned);
        }
        Vector3 _nodeStarVector3 = new Vector3(2f, 3.5f, 0f);
        if (starSpawnCount == 43) // Node Star
        {
            mainNodeStar.gameObject.transform.position = _nodeStarVector3;
            Debug.Log("Map 1 Spawned!");
            return;
        }
    }


    // New Maps
    void HCMap2(StarClass star) // Hand Built Calls Per Level, meaning we have to manually change this to load as we require it to change
    {
        if (starSpawnCount == 0) // Starts at 0
        {
            GameObject starToBeSpawned1 = Instantiate(star.starPrefab, starSpawnPoint11_1.position, starSpawnPoint11_1.rotation); // Only one in one
            global.startingStarSpawnPointList.Add(starSpawnPoint11_1);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned1);
        }
        if (starSpawnCount == 1)
        {
            GameObject starToBeSpawned2 = Instantiate(star.starPrefab, starSpawnPoint2_2.position, starSpawnPoint2_2.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint2_2);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned2);
        }
        if (starSpawnCount == 2)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_5.position, starSpawnPoint2_5.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint2_5);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 3)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_15.position, starSpawnPoint15_2.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint2_15);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 4)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_8.position, starSpawnPoint3_8.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_8);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 5) // Adding more past this
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_6.position, starSpawnPoint4_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 6)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_11.position, starSpawnPoint4_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 7)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_16.position, starSpawnPoint4_16.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_16);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 8)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_13.position, starSpawnPoint5_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 9)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_5.position, starSpawnPoint6_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 10)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_9.position, starSpawnPoint6_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 11)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_1.position, starSpawnPoint7_1.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_1);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 12)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_17.position, starSpawnPoint7_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_17);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 13)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_4.position, starSpawnPoint8_4.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 14)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_7.position, starSpawnPoint8_7.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_7);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 15)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_8.position, starSpawnPoint16_8.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_8);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 16)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_11.position, starSpawnPoint10_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 17)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint11_13.position, starSpawnPoint11_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint11_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 18)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_7.position, starSpawnPoint12_7.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_7);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 19)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_17.position, starSpawnPoint12_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_17);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 20)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint13_14.position, starSpawnPoint13_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint13_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 21)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint14_3.position, starSpawnPoint14_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint14_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 22)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint14_6.position, starSpawnPoint14_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint14_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 23)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_12.position, starSpawnPoint15_12.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_12);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 24)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_2.position, starSpawnPoint10_2.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_2);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 25)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_14.position, starSpawnPoint16_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 26)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_10.position, starSpawnPoint18_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint17_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 27)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint18_6.position, starSpawnPoint18_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint18_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 28)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint18_16.position, starSpawnPoint18_16.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint18_16);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 29)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint19_2.position, starSpawnPoint19_2.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint19_2);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 30)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint19_16.position, starSpawnPoint19_16.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint19_16);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 31) // Value Stars Ended, Attack
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_3.position, starSpawnPoint4_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 32)
        { 
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_15.position, starSpawnPoint8_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_15);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 33) // Health
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_1.position, starSpawnPoint15_1.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_1);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 34) // Shield
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint18_9.position, starSpawnPoint18_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint18_9);
            usedTransform.Add(starToBeSpawned);
        }
        Vector3 _nodeStarVector3 = starSpawnPoint11_9.position;
        if (starSpawnCount == 35) // Node Star
        {
            mainNodeStar.gameObject.transform.position = _nodeStarVector3;
            Debug.Log("Map 2 Spawned!");
            return;
        }

    }

    void HCMap3(StarClass star) // Caden Map 2
    {
        if (starSpawnCount == 0) // Starts at 0
        {
            GameObject starToBeSpawned1 = Instantiate(star.starPrefab, starSpawnPoint1_2.position, starSpawnPoint1_2.rotation); 
            global.startingStarSpawnPointList.Add(starSpawnPoint1_2);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned1);
        }
        if (starSpawnCount == 1)
        {
            GameObject starToBeSpawned2 = Instantiate(star.starPrefab, starSpawnPoint1_13.position, starSpawnPoint1_13.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint1_13);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned2);
        }
        if (starSpawnCount == 2)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_5.position, starSpawnPoint2_5.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint2_5);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 3)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_8.position, starSpawnPoint2_8.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint2_8);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 4)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_11.position, starSpawnPoint3_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 5) 
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_12.position, starSpawnPoint4_12.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_12);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 6)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_16.position, starSpawnPoint4_16.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_16);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 7)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_1.position, starSpawnPoint5_1.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_1);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 8)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_5.position, starSpawnPoint5_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 9)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_3.position, starSpawnPoint6_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 10)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_9.position, starSpawnPoint6_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 11)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_14.position, starSpawnPoint6_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 12)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_17.position, starSpawnPoint7_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_17);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 13)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_6.position, starSpawnPoint8_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 14)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_11.position, starSpawnPoint8_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 15)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_2.position, starSpawnPoint10_2.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_2);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 16)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_5.position, starSpawnPoint10_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 17)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_15.position, starSpawnPoint10_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_15);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 18)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_6.position, starSpawnPoint12_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 19)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_10.position, starSpawnPoint12_10.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 20)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint13_14.position, starSpawnPoint13_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint13_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 21)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint14_3.position, starSpawnPoint14_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint14_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 22)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint14_16.position, starSpawnPoint14_16.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint14_16);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 23)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_9.position, starSpawnPoint15_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 24)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_14.position, starSpawnPoint15_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 25)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_6.position, starSpawnPoint16_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 26)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_17.position, starSpawnPoint16_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_17);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 27)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_2.position, starSpawnPoint17_2.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint17_2);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 28)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint18_5.position, starSpawnPoint18_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint18_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 29)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint18_13.position, starSpawnPoint18_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint18_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 30)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint19_3.position, starSpawnPoint19_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint19_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 31)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint19_11.position, starSpawnPoint19_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint19_11);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 32) // Value Stars Ended, Attack
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_3.position, starSpawnPoint5_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_3);
            usedTransform.Add(starToBeSpawned);
            
        }
        if (starSpawnCount == 33) 
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_3.position, starSpawnPoint12_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_3);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 34) 
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_4.position, starSpawnPoint3_4.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_4);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 35) 
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_11.position, starSpawnPoint16_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_11);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        Vector3 _nodeStarVector3 = starSpawnPoint10_8.position; 
        if (starSpawnCount == 36) // Node Star
        {
            mainNodeStar.gameObject.transform.position = _nodeStarVector3;
            Debug.Log("Map 3 Spawned!");
            return;
        }
    }

    void HCMap4(StarClass star) // Caden Map 3
    {
        if (starSpawnCount == 0) // Starts at 0
        {
            GameObject starToBeSpawned1 = Instantiate(star.starPrefab, starSpawnPoint1_7.position, starSpawnPoint1_7.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint1_7);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned1);
        }
        if (starSpawnCount == 1)
        {
            GameObject starToBeSpawned2 = Instantiate(star.starPrefab, starSpawnPoint1_15.position, starSpawnPoint1_15.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint1_15);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned2);
        }
        if (starSpawnCount == 2)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_1.position, starSpawnPoint2_1.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint2_1);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 3)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_10.position, starSpawnPoint2_10.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint2_10);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 4)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_4.position, starSpawnPoint3_4.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 5) 
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_13.position, starSpawnPoint3_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 6)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_9.position, starSpawnPoint4_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 7)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_16.position, starSpawnPoint4_16.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_16);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 8)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_1.position, starSpawnPoint5_1.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_1);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 9)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_11.position, starSpawnPoint5_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 10)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_3.position, starSpawnPoint6_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 11)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_14.position, starSpawnPoint6_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 12)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_9.position, starSpawnPoint7_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 13)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_17.position, starSpawnPoint7_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_17);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 14)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_5.position, starSpawnPoint8_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 15)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_11.position, starSpawnPoint8_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 16)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_6.position, starSpawnPoint10_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 17)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_14.position, starSpawnPoint10_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 18)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint11_3.position, starSpawnPoint11_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint11_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 19)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_5.position, starSpawnPoint12_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 20)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_13.position, starSpawnPoint12_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 21)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint14_3.position, starSpawnPoint14_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint14_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 22)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint14_9.position, starSpawnPoint14_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint14_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 23)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_11.position, starSpawnPoint15_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 24)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_14.position, starSpawnPoint15_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 25)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_5.position, starSpawnPoint16_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 26)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_17.position, starSpawnPoint16_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_17);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 27)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_8.position, starSpawnPoint17_8.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint17_8);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 28)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint18_2.position, starSpawnPoint18_2.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint18_2);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 29)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint18_12.position, starSpawnPoint18_12.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint18_12);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 30)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint19_6.position, starSpawnPoint19_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint19_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 31)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint19_15.position, starSpawnPoint19_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint19_15);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 32) // Value Stars Ended, Attack
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_2.position, starSpawnPoint6_2.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_2);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 33)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_7.position, starSpawnPoint16_7.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_7);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 34) // Shield
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_7.position, starSpawnPoint7_7.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_7);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 35) 
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_16.position, starSpawnPoint16_16.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_16);
            usedTransform.Add(starToBeSpawned);
        }
        Vector3 _nodeStarVector3 = starSpawnPoint12_11.position;
        if (starSpawnCount == 36) // Node Star
        {
            mainNodeStar.gameObject.transform.position = _nodeStarVector3;
            Debug.Log("Map 4 Spawned!");
            return;
        }
    }

    void HCMap5(StarClass star) // Caden Map 4
    {
        if (starSpawnCount == 0) // Starts at 0
        {
            GameObject starToBeSpawned1 = Instantiate(star.starPrefab, starSpawnPoint1_5.position, starSpawnPoint1_5.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint1_5);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned1);
        }
        if (starSpawnCount == 1)
        {
            GameObject starToBeSpawned2 = Instantiate(star.starPrefab, starSpawnPoint1_12.position, starSpawnPoint1_12.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint1_12);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned2);
        }
        if (starSpawnCount == 2)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_2.position, starSpawnPoint2_2.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint2_2);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 3)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_10.position, starSpawnPoint2_10.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint2_10);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 4)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_6.position, starSpawnPoint3_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 5)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_11.position, starSpawnPoint3_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 6)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_7.position, starSpawnPoint4_7.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_7);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 7)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_16.position, starSpawnPoint4_16.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_16);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 8)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_4.position, starSpawnPoint5_4.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 9)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_11.position, starSpawnPoint5_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 10)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_1.position, starSpawnPoint6_1.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_1);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 11)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_14.position, starSpawnPoint6_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 12)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_9.position, starSpawnPoint7_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 13)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_17.position, starSpawnPoint7_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_17);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 14)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_5.position, starSpawnPoint8_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 15)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_13.position, starSpawnPoint8_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 16)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_10.position, starSpawnPoint10_10.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 17)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_14.position, starSpawnPoint10_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 18)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint11_1.position, starSpawnPoint11_1.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint11_1);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 19)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_4.position, starSpawnPoint12_4.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 20)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_13.position, starSpawnPoint12_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 21)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint14_3.position, starSpawnPoint14_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint14_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 22)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint14_12.position, starSpawnPoint14_12.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint14_12);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 23)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_9.position, starSpawnPoint15_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 24)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_14.position, starSpawnPoint15_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 25)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_6.position, starSpawnPoint16_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 26)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_17.position, starSpawnPoint16_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_17);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 27)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_4.position, starSpawnPoint17_4.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint17_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 28)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint18_3.position, starSpawnPoint18_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint18_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 29)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint18_11.position, starSpawnPoint18_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint18_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 30)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint19_7.position, starSpawnPoint19_7.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint19_7);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 31)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint19_15.position, starSpawnPoint19_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint19_15);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 32) // Value Stars Ended, Attack
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_13.position, starSpawnPoint4_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 33) 
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint13_2.position, starSpawnPoint13_2.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint13_2);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 34) // Health
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_8.position, starSpawnPoint2_8.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint2_8);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 35) // Shield
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_16.position, starSpawnPoint16_16.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_16);
            usedTransform.Add(starToBeSpawned);
        }
        Vector3 _nodeStarVector3 = starSpawnPoint10_7.position;
        if (starSpawnCount == 36) // Node Star
        {
            mainNodeStar.gameObject.transform.position = _nodeStarVector3;
            Debug.Log("Map 5 Spawned!");
            return;
        }
    }

    void HCMap6(StarClass star) // Caden Map 5
    {
        if (starSpawnCount == 0) // Starts at 0
        {
            GameObject starToBeSpawned1 = Instantiate(star.starPrefab, starSpawnPoint1_2.position, starSpawnPoint1_2.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint1_2);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned1);
        }
        if (starSpawnCount == 1)
        {
            GameObject starToBeSpawned2 = Instantiate(star.starPrefab, starSpawnPoint1_15.position, starSpawnPoint1_15.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint1_15);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned2);
        }
        if (starSpawnCount == 2)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_5.position, starSpawnPoint2_5.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint2_5);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 3)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_7.position, starSpawnPoint2_7.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint2_7);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 4)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_9.position, starSpawnPoint3_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 5)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_12.position, starSpawnPoint3_12.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_12);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 6)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_5.position, starSpawnPoint4_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 7)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_16.position, starSpawnPoint4_16.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_16);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 8)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_2.position, starSpawnPoint5_2.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_2);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 9)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_10.position, starSpawnPoint5_10.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 10)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_4.position, starSpawnPoint6_4.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 11)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_11.position, starSpawnPoint6_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 12)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_14.position, starSpawnPoint6_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 13)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_9.position, starSpawnPoint7_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 14)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_17.position, starSpawnPoint7_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_17);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 15)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_6.position, starSpawnPoint8_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 16)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_15.position, starSpawnPoint8_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_15);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 17)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint9_3.position, starSpawnPoint9_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint9_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 18)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_4.position, starSpawnPoint10_4.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 19)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_10.position, starSpawnPoint10_10.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 20)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint11_14.position, starSpawnPoint11_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint11_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 21)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_4.position, starSpawnPoint12_4.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 22)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_8.position, starSpawnPoint12_8.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_8);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 23)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint13_1.position, starSpawnPoint13_1.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint13_1);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 24)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint13_13.position, starSpawnPoint13_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint13_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 25)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint14_5.position, starSpawnPoint14_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint14_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 26)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_3.position, starSpawnPoint15_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 27)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_8.position, starSpawnPoint15_8.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_8);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 28)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_12.position, starSpawnPoint15_12.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_12);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 29)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_6.position, starSpawnPoint16_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 30)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_17.position, starSpawnPoint16_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_7);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 31)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_5.position, starSpawnPoint17_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint17_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 32)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint18_7.position, starSpawnPoint18_7.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint18_7);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 33)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint18_11.position, starSpawnPoint18_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint18_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 34)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint19_1.position, starSpawnPoint19_1.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint19_1);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 35)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint19_14.position, starSpawnPoint19_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint19_14);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 36) // Value Stars Ended, Attack
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_3.position, starSpawnPoint4_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 37) 
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_6.position, starSpawnPoint5_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 38)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint13_10.position, starSpawnPoint13_10.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint13_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 39) 
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_15.position, starSpawnPoint16_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_15);
            usedTransform.Add(starToBeSpawned);
        }
        Vector3 _nodeStarVector3 = starSpawnPoint10_7.position;
        if (starSpawnCount == 40) // Node Star
        {
            mainNodeStar.gameObject.transform.position = _nodeStarVector3;
            Debug.Log("Map 6 Spawned!");
            return;
        }
    }

    void HCMap7(StarClass star) // Caden Map 6
    {
        if (starSpawnCount == 0) // Starts at 0
        {
            GameObject starToBeSpawned1 = Instantiate(star.starPrefab, starSpawnPoint1_8.position, starSpawnPoint1_8.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint1_8);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned1);
        }
        if (starSpawnCount == 1)
        {
            GameObject starToBeSpawned2 = Instantiate(star.starPrefab, starSpawnPoint1_11.position, starSpawnPoint1_11.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint1_11);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned2);
        }
        if (starSpawnCount == 2)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_3.position, starSpawnPoint2_3.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint2_3);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 3)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_14.position, starSpawnPoint2_14.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint2_14);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 4)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_6.position, starSpawnPoint3_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 5)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_17.position, starSpawnPoint3_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_17);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 6) 
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_4.position, starSpawnPoint4_4.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 7)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_12.position, starSpawnPoint4_12.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_12); 
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 8)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_7.position, starSpawnPoint5_7.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_7);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 9)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_13.position, starSpawnPoint5_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 10)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_2.position, starSpawnPoint6_2.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_2);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 11)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_10.position, starSpawnPoint6_10.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 12)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_9.position, starSpawnPoint7_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 13)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_1.position, starSpawnPoint8_1.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_1);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 14)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_6.position, starSpawnPoint8_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 15)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_16.position, starSpawnPoint8_16.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_16);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 16)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint9_8.position, starSpawnPoint9_8.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint9_8);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 17)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint9_15.position, starSpawnPoint9_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint9_15);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 18)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_2.position, starSpawnPoint10_2.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_2);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 19)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_10.position, starSpawnPoint10_10.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 20)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint11_5.position, starSpawnPoint11_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint11_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 21)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint11_13.position, starSpawnPoint11_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint11_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 22)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_11.position, starSpawnPoint12_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 23)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_17.position, starSpawnPoint12_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_17);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 24)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint13_1.position, starSpawnPoint13_1.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint13_1);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 25)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint13_7.position, starSpawnPoint13_7.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint13_7);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 26)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint14_4.position, starSpawnPoint14_4.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint14_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 27)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint14_16.position, starSpawnPoint14_16.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint14_16);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 28)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_9.position, starSpawnPoint15_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 29)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_14.position, starSpawnPoint15_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 30)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_3.position, starSpawnPoint16_3.rotation); 
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 31)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_15.position, starSpawnPoint16_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_15);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 32)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_12.position, starSpawnPoint17_12.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint17_12);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 33)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint18_5.position, starSpawnPoint18_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint18_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 34)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint18_7.position, starSpawnPoint18_7.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint18_7);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 35)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint19_14.position, starSpawnPoint19_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint19_14);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 36) // Value Stars Ended, Attack
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_9.position, starSpawnPoint3_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 37) 
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_3.position, starSpawnPoint10_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 38)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_9.position, starSpawnPoint17_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint17_9);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 39) // Health
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_15.position, starSpawnPoint10_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_15);
            usedTransform.Add(starToBeSpawned);
        }
        Vector3 _nodeStarVector3 = starSpawnPoint10_9.position;
        if (starSpawnCount == 40) // Node Star
        {
            mainNodeStar.gameObject.transform.position = _nodeStarVector3;
            Debug.Log("Map 7 Spawned!");
            return;
        }
    }

    void HCMap8(StarClass star) // Caden Map 7
    {
        if (starSpawnCount == 0) // Starts at 0
        {
            GameObject starToBeSpawned1 = Instantiate(star.starPrefab, starSpawnPoint1_2.position, starSpawnPoint1_2.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint1_2);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned1);
        }
        if (starSpawnCount == 1)
        {
            GameObject starToBeSpawned2 = Instantiate(star.starPrefab, starSpawnPoint1_8.position, starSpawnPoint1_8.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint1_8);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned2);
        }
        if (starSpawnCount == 2)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_5.position, starSpawnPoint2_5.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint2_5);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 3)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_12.position, starSpawnPoint2_12.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint2_12);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 4)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_7.position, starSpawnPoint3_7.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_7);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 5)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_14.position, starSpawnPoint3_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 6)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_1.position, starSpawnPoint4_1.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_1);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 7)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_12.position, starSpawnPoint4_12.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_12);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 8)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_4.position, starSpawnPoint5_4.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 9)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_13.position, starSpawnPoint5_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 10)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_1.position, starSpawnPoint6_1.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_1);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 11)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_15.position, starSpawnPoint6_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_15);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 12)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_6.position, starSpawnPoint7_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 13)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_9.position, starSpawnPoint8_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 14)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_16.position, starSpawnPoint8_16.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_16);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 15)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint9_5.position, starSpawnPoint9_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint9_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 16)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint9_17.position, starSpawnPoint9_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint9_17);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 17)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_2.position, starSpawnPoint10_2.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_2);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 18)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_10.position, starSpawnPoint10_10.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 19)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint11_7.position, starSpawnPoint11_7.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint11_7);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 20)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint11_14.position, starSpawnPoint11_14.rotation); 
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint11_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 21)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_9.position, starSpawnPoint12_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 22)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_17.position, starSpawnPoint12_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_17);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 23)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint13_6.position, starSpawnPoint13_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint13_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 24)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint13_8.position, starSpawnPoint13_8.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint13_8);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 25)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint14_3.position, starSpawnPoint14_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint14_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 26)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint14_16.position, starSpawnPoint14_16.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint14_16);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 27)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_4.position, starSpawnPoint15_4.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 28)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_9.position, starSpawnPoint15_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 29)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_7.position, starSpawnPoint16_7.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_7);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 30)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_15.position, starSpawnPoint16_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_15);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 31)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_13.position, starSpawnPoint17_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint17_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 32)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint18_3.position, starSpawnPoint18_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint18_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 33)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint18_6.position, starSpawnPoint18_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint18_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 34)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint19_11.position, starSpawnPoint19_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint19_11);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 35) // Value Stars Ended, Attack
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_9.position, starSpawnPoint3_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 36)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_3.position, starSpawnPoint6_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 37) 
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_5.position, starSpawnPoint15_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_5);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 38) // Health
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_8.position, starSpawnPoint16_8.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_8);
            usedTransform.Add(starToBeSpawned);
        }
        Vector3 _nodeStarVector3 = starSpawnPoint10_9.position;
        if (starSpawnCount == 39) // Node Star
        {
            mainNodeStar.gameObject.transform.position = _nodeStarVector3;
            Debug.Log("Map 8 Spawned!");
            return;
        }
    }

    void HCMap9(StarClass star) // Victor Map 1
    {
        if (starSpawnCount == 0) // Starts at 0
        {
            GameObject starToBeSpawned1 = Instantiate(star.starPrefab, starSpawnPoint2_1.position, starSpawnPoint2_1.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint2_1);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned1);
        }
        if (starSpawnCount == 1)
        {
            GameObject starToBeSpawned2 = Instantiate(star.starPrefab, starSpawnPoint7_1.position, starSpawnPoint7_1.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint7_1);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned2);
        }
        if (starSpawnCount == 2)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_1.position, starSpawnPoint17_1.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint17_1);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 3)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_2.position, starSpawnPoint5_2.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint5_2);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 4)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_2.position, starSpawnPoint10_2.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_2);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 5)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_3.position, starSpawnPoint4_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 6)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_3.position, starSpawnPoint12_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 7)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_4.position, starSpawnPoint8_4.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 8)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_4.position, starSpawnPoint16_4.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 9)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_5.position, starSpawnPoint3_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 10)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_5.position, starSpawnPoint6_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 11)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_5.position, starSpawnPoint10_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 12)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint1_6.position, starSpawnPoint1_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint1_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 13)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_6.position, starSpawnPoint15_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 14)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_7.position, starSpawnPoint5_7.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_7);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 15)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_7.position, starSpawnPoint8_7.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_7);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 16)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_8.position, starSpawnPoint4_8.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_8);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 17)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_8.position, starSpawnPoint17_8.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint17_8);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 18)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint18_8.position, starSpawnPoint18_8.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint18_8);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 19) 
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_9.position, starSpawnPoint7_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 20)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint1_10.position, starSpawnPoint1_10.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint1_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 21)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint11_10.position, starSpawnPoint11_10.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint11_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 22)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_11.position, starSpawnPoint5_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 23)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_11.position, starSpawnPoint8_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 24)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_12.position, starSpawnPoint12_12.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_12);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 25)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint14_12.position, starSpawnPoint14_12.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint14_12);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 26)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_13.position, starSpawnPoint3_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 27)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint19_13.position, starSpawnPoint19_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint19_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 28)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_14.position, starSpawnPoint6_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 29)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_14.position, starSpawnPoint15_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 30)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint11_15.position, starSpawnPoint11_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint11_15);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 31)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_15.position, starSpawnPoint17_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint17_15);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 32)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_16.position, starSpawnPoint4_16.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_16);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 33)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_16.position, starSpawnPoint7_16.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_16);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 34)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_16.position, starSpawnPoint16_16.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_16);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 35) 
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint11_17.position, starSpawnPoint11_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint11_17);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 36)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint18_17.position, starSpawnPoint18_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint18_17);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 37) // Value Stars Ended, Attack
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint14_2.position, starSpawnPoint14_2.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint14_2);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 38) 
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_9.position, starSpawnPoint2_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint2_9);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 39) // Health
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_10.position, starSpawnPoint15_10.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_10);
            usedTransform.Add(starToBeSpawned);
            return; 
        }
        if(starSpawnCount == 40) // Shield
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_15.position, starSpawnPoint6_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_15);
            usedTransform.Add(starToBeSpawned);
        }
        Vector3 _nodeStarVector3 = starSpawnPoint10_8.position;
        if (starSpawnCount == 41) // Node Star
        {
            mainNodeStar.gameObject.transform.position = _nodeStarVector3;
            Debug.Log("Map 9 Spawned!");
            return;
        }
    }

    void HCMap10(StarClass star) // Victor Map 2
    {
        if (starSpawnCount == 0) // Starts at 0
        {
            GameObject starToBeSpawned1 = Instantiate(star.starPrefab, starSpawnPoint2_1.position, starSpawnPoint2_1.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint2_1);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned1);
        }
        if (starSpawnCount == 1)
        {
            GameObject starToBeSpawned2 = Instantiate(star.starPrefab, starSpawnPoint7_1.position, starSpawnPoint7_1.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint7_1);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned2);
        }
        if (starSpawnCount == 2)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_1.position, starSpawnPoint8_1.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint8_1);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 3)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_2.position, starSpawnPoint7_2.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint7_2);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 4)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_2.position, starSpawnPoint12_2.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_2);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 5)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_3.position, starSpawnPoint7_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 6)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_3.position, starSpawnPoint15_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 7)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint1_4.position, starSpawnPoint1_4.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint1_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 8)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint19_4.position, starSpawnPoint19_4.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint19_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 9)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_5.position, starSpawnPoint8_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 10)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint11_5.position, starSpawnPoint11_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint11_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 11)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_5.position, starSpawnPoint15_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 12)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_6.position, starSpawnPoint2_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint2_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 13)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_6.position, starSpawnPoint7_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 14)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_7.position, starSpawnPoint12_7.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_7);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 15)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_7.position, starSpawnPoint15_7.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_7);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 16)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_8.position, starSpawnPoint6_8.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_8);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 17)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint13_8.position, starSpawnPoint13_8.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint13_8);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 18)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_8.position, starSpawnPoint17_8.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint17_8);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 19)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_9.position, starSpawnPoint7_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 20)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint1_10.position, starSpawnPoint1_10.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint1_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 21)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_10.position, starSpawnPoint10_10.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 22)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_11.position, starSpawnPoint5_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 23)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_11.position, starSpawnPoint8_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 24)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint9_12.position, starSpawnPoint9_12.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint9_12);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 25)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_12.position, starSpawnPoint17_12.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint17_12);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 26)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_13.position, starSpawnPoint3_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 27)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_13.position, starSpawnPoint15_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 28)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint1_14.position, starSpawnPoint1_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint1_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 29)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint14_14.position, starSpawnPoint14_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint14_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 30)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint11_15.position, starSpawnPoint11_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint11_15);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 31)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_15.position, starSpawnPoint17_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint17_15);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 32)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_16.position, starSpawnPoint8_16.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_16);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 33)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_16.position, starSpawnPoint16_16.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_16);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 34)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_17.position, starSpawnPoint3_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_17);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 35)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint11_17.position, starSpawnPoint11_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint11_17);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 36)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint13_17.position, starSpawnPoint13_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint13_17);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 37) // Value Stars Ended, Attack
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint13_3.position, starSpawnPoint13_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint13_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 38)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint1_9.position, starSpawnPoint1_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint1_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 39) 
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_13.position, starSpawnPoint12_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_13);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 40) // Health
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_15.position, starSpawnPoint5_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_15);
            usedTransform.Add(starToBeSpawned);
        }
        Vector3 _nodeStarVector3 = starSpawnPoint10_8.position;
        if (starSpawnCount == 41) // Node Star
        {
            mainNodeStar.gameObject.transform.position = _nodeStarVector3;
            Debug.Log("Map 10 Spawned!");
            return;
        }
    }

    void HCMap11(StarClass star) // Victor Map 3
    {
        if (starSpawnCount == 0) // Starts at 0
        {
            GameObject starToBeSpawned1 = Instantiate(star.starPrefab, starSpawnPoint8_1.position, starSpawnPoint8_1.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint8_1);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned1);
        }
        if (starSpawnCount == 1)
        {
            GameObject starToBeSpawned2 = Instantiate(star.starPrefab, starSpawnPoint18_1.position, starSpawnPoint18_1.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint18_1);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned2);
        }
        if (starSpawnCount == 2)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_2.position, starSpawnPoint2_2.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint2_2);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 3)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_2.position, starSpawnPoint7_2.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint7_2);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 4)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_2.position, starSpawnPoint12_2.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_2);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 5)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_3.position, starSpawnPoint6_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 6)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_3.position, starSpawnPoint15_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 7)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint11_4.position, starSpawnPoint11_4.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint11_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 8)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint19_4.position, starSpawnPoint19_4.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint19_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 9)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint11_5.position, starSpawnPoint11_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint11_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 10)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_5.position, starSpawnPoint15_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 11)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_6.position, starSpawnPoint7_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 12)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_6.position, starSpawnPoint8_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 13)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_7.position, starSpawnPoint2_7.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint2_7);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 14)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_7.position, starSpawnPoint7_7.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_7);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 15)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_8.position, starSpawnPoint6_8.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_8);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 16)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_8.position, starSpawnPoint12_8.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_8);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 17)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_8.position, starSpawnPoint15_8.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_8);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 18)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_9.position, starSpawnPoint6_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 19)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint13_9.position, starSpawnPoint13_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint13_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 20)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_9.position, starSpawnPoint17_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint17_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 21)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint1_10.position, starSpawnPoint1_10.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint1_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 22)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_10.position, starSpawnPoint7_10.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 23)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_10.position, starSpawnPoint10_10.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 24)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_11.position, starSpawnPoint5_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 25)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_12.position, starSpawnPoint8_12.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_12);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 26)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_12.position, starSpawnPoint17_12.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint17_12);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 27)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint9_13.position, starSpawnPoint9_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint9_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 28)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_13.position, starSpawnPoint15_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 29)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_14.position, starSpawnPoint3_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 30)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_14.position, starSpawnPoint15_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 31)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint1_15.position, starSpawnPoint1_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint1_15);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 32)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint11_15.position, starSpawnPoint11_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint11_15);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 33)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint14_15.position, starSpawnPoint14_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint14_15);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 34)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_16.position, starSpawnPoint17_16.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint17_16);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 35)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_17.position, starSpawnPoint3_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_17);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 36)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_17.position, starSpawnPoint8_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_17);
        }
        if (starSpawnCount == 36)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint11_17.position, starSpawnPoint11_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint11_17);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 37)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint13_17.position, starSpawnPoint13_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint13_17);
            usedTransform.Add(starToBeSpawned);
            return; 
        }
        if (starSpawnCount == 38) // Value Stars Ended, Attack
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint13_4.position, starSpawnPoint13_4.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint13_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 39)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_9.position, starSpawnPoint4_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 40)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint14_13.position, starSpawnPoint14_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint14_13);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 41) // Shield
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_15.position, starSpawnPoint5_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_15);
            usedTransform.Add(starToBeSpawned);
        }
        Vector3 _nodeStarVector3 = starSpawnPoint10_8.position;
        if (starSpawnCount == 42) // Node Star
        {
            mainNodeStar.gameObject.transform.position = _nodeStarVector3;
            Debug.Log("Map 11 Spawned!");
            return;
        }
    }

    void HCMap12(StarClass star) // Victor Map 4
    {
        if (starSpawnCount == 0) // Starts at 0
        {
            GameObject starToBeSpawned1 = Instantiate(star.starPrefab, starSpawnPoint6_1.position, starSpawnPoint6_1.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint6_1);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned1);
        }
        if (starSpawnCount == 1)
        {
            GameObject starToBeSpawned2 = Instantiate(star.starPrefab, starSpawnPoint11_1.position, starSpawnPoint11_1.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint11_1);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned2);
        }
        if (starSpawnCount == 2)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_2.position, starSpawnPoint2_2.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint2_2);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 3)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint14_3.position, starSpawnPoint14_3.rotation);
            global.startingStarSpawnPointList.Add(starSpawnPoint14_3);
            starSpawnCount++;
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 4)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint18_3.position, starSpawnPoint18_3.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint18_3);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 5)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_4.position, starSpawnPoint5_4.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 6)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint12_4.position, starSpawnPoint12_4.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_4);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 7)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint1_5.position, starSpawnPoint1_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint1_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 8)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_5.position, starSpawnPoint8_5.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_5);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 9)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_6.position, starSpawnPoint3_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 10)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_6.position, starSpawnPoint16_6.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_6);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 11)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_7.position, starSpawnPoint4_7.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_7);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 12)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint19_7.position, starSpawnPoint19_7.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint19_7);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 13)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_9.position, starSpawnPoint7_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 14)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_9.position, starSpawnPoint15_9.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_9);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 15)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_10.position, starSpawnPoint2_10.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint2_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 16)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_10.position, starSpawnPoint10_10.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_10);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 17)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint3_11.position, starSpawnPoint3_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint3_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 18)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint5_11.position, starSpawnPoint5_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint5_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 19)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint18_11.position, starSpawnPoint18_11.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint18_11);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 20)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint1_12.position, starSpawnPoint1_12.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint1_12);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 21)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint14_12.position, starSpawnPoint14_12.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint14_12);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 22)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint8_13.position, starSpawnPoint8_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint8_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 23)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_13.position, starSpawnPoint12_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint12_13);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 24)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint6_14.position, starSpawnPoint6_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint6_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 25)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint10_14.position, starSpawnPoint10_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint10_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 26)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint15_14.position, starSpawnPoint15_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint15_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 27)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint17_14.position, starSpawnPoint17_14.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint17_14);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 28)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint19_15.position, starSpawnPoint19_15.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint19_15);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 29)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_16.position, starSpawnPoint4_16.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_16);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 30)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint7_17.position, starSpawnPoint7_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint7_17);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 31)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_17.position, starSpawnPoint16_17.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_17);
            usedTransform.Add(starToBeSpawned);
            return; 
        }
        if (starSpawnCount == 32) // Value Stars Ended, Attack
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint13_2.position, starSpawnPoint13_2.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint13_2);
            usedTransform.Add(starToBeSpawned);
        }
        if (starSpawnCount == 33)
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint4_13.position, starSpawnPoint4_13.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint4_13);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 34) // Health
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint2_8.position, starSpawnPoint2_8.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint2_8);
            usedTransform.Add(starToBeSpawned);
            return;
        }
        if (starSpawnCount == 45) // Shield
        {
            GameObject starToBeSpawned = Instantiate(star.starPrefab, starSpawnPoint16_16.position, starSpawnPoint16_16.rotation);
            starSpawnCount++;
            global.startingStarSpawnPointList.Add(starSpawnPoint16_16);
            usedTransform.Add(starToBeSpawned);
        }
        Vector3 _nodeStarVector3 = starSpawnPoint10_7.position;
        if (starSpawnCount == 36) // Node Star
        {
            mainNodeStar.gameObject.transform.position = _nodeStarVector3;
            Debug.Log("Map 12 Spawned!");
            return;
        }
    }
}
