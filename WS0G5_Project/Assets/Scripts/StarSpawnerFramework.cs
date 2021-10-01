using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawnerFramework : MonoBehaviour
{
    [Header("Other")]
    public GameObject starPrefab;
    public GameObject verticalGrid;
    public GameObject horizontalGrid;
    public int starSpawnCount;
    public int counter = 20;

    [Header("Lists")]
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

    // Functions
    void Start()
    {
        starSpawnCount = 0;
        SpawnStarRow1List();
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
    }

    void Update()
    {
        SpawnStar(starPrefab);
        verticalGrid.SetActive(false);
        horizontalGrid.SetActive(false);
    }

    void SpawnStar(GameObject star)
    {
        if (starSpawnCount == 0)
        {
            Instantiate(star, starSpawnPoint3_7.position, starSpawnPoint3_7.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
        }
        if (starSpawnCount == 1)
        {
            Instantiate(star, starSpawnPoint5_12.position, starSpawnPoint5_12.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
        }
        if (starSpawnCount == 2)
        {
            Instantiate(star, starSpawnPoint8_5.position, starSpawnPoint8_5.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
        }
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
        Debug.Log(row1);
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
        Debug.Log(row2);
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
        Debug.Log(row3);
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
        Debug.Log(row4);
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
        Debug.Log(row5);
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
        Debug.Log(row6);
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
        Debug.Log(row7);
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
        Debug.Log(row8);
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
        Debug.Log(row7);
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
        Debug.Log(row10);
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
        Debug.Log(row11);
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
        Debug.Log(row12);
    }
}
