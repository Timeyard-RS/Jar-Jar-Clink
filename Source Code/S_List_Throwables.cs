using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class S_List_Throwables {

    public string Name;
    public List<GameObject> ThrowableObjects;
    public GameObject DestructionParticle;
    public bool Purchased;
    public int Cost;
    public Sprite Icon;
    public GameObject ButtonUI;
    public AudioClip HardSound;
    public AudioClip SoftSound;
    public int HighScore;
    public int HardcoreScore;
    public int ObjectsThrown;
    public int ObjectsHit;
    public int UnlockLevel;
    public bool Unlisted;
    public bool DestroyOnFloorImpact;

    public float Physics_ForwardMultiplier;
    public float Physics_UpMultiplier;
    public float Physics_Limitation;
}
