using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class S_List_Themes  {

    public string Name;
    public Material Backdrop;
    public Material Floor;
    public Color DirectionalLightColour;
    public float DirectionalLightIntensity;
    public bool HardSurface;
    public GameObject[] ThemeObjects;
    public bool Purchased;
    public int Cost;
    public int UnlockLevel;
    public Sprite Icon;
    public GameObject ButtonUI;
    public bool Unlisted;
    public bool UseGallery;
    public Sprite[] GalleryImages;
    public string[] GalleryNames;
    public AudioClip ThemeMusic;

}
