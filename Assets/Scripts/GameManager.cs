using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] public static int gameMode = 1; //1:Ghost Chase, 2:Abyss Descend
    [SerializeField] public static int gameScore = 0;
    [SerializeField] public static int floorLevel = 0;

}
