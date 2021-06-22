using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class S_List_GameModes  {
    [Header("General Settings")]
    public string Name;
    public string[] Details;
    public Color TextColour;
    public int StartQuantity;
    public int ComboAward;
    public int ComboRequired;
    public int RandomiseEveryXLevels;
    public int EscalationAmount;
    public int EscalationCap;
    public int GoldPercent;
    public int BalloonPercent;
    public int Score;
    public int AdvancedScore;
    public float AdWeightReducer;
    public bool UseItem;
    public bool AdvancedThrowing;
    public Sprite Icon; 
    [Header("Fixed Settings")]
    public bool UseSpecificTheme;
    public int ThemeID;
    public bool UseSpecificThrowable;
    public int ThrowableID;
    public bool UseSpecificJar;
    public int JarID;
    [Header("Randomise Settings")]
    public bool RandomiseJars;
    public bool RandomiseThemes;
    public bool RandomiseThrowables;

}
