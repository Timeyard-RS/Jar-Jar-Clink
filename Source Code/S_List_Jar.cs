using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class S_List_Jar {

    public string Name;
    public List<S_List_JarType> JarObjects;
    public bool Purchased;
    public int Cost;
    public Sprite Icon;
    public GameObject ButtonUI;
    public int HighScore;
    public int HardcoreScore;
    public int ObjectsSmashed;
    public int UnlockLevel;
    public bool UseSuppliedColours;
    public bool Unlisted;
}
