using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class S_PlayerData 
{
    public int Save_StandardHighScore;
    public int Save_HardcoreHighScore;
    public int Save_GlitchHighScore;
    public int Save_DiamondRoomScore;
    public int Save_Currency;
    public int Save_DiamondKeys;
    public int Save_LeftItem;
    public int Save_RightItem;
    public bool Save_AllocateItemToLeft;
    public int Save_ThemeActive;
    public int Save_JarPackActive;
    public int Save_Throwable;
    public int Save_JarsSmashedSmall;
    public int Save_JarsSmashedLarge;
    public int Save_JarsSmashedMedium;
    public int Save_ObjectsThrown;
    public int Save_ItemsUsed;
    public int Save_ScoreSpacer;
    public int Save_MenuTheme;
    public int Save_Levels;
    public bool Save_NoAds;
    public bool[] Save_JarsPurchased;
    public bool[] Save_ThrowablesPurchased;
    public bool[] Save_ThemesPurchased;
    public int[] Save_ThrowablesHighScore;
    public int[] Save_ThrowablesHardcoreScore;
    public int[] Save_ThrowablesObjectsThrown;
    public int[] Save_ThrowablesObjectsHit;
    public int[] Save_JarHighScore;
    public int[] Save_JarHardcoreScore;
    public int[] Save_JarObjectsSmashed;
    public int[] Save_ItemsUsedPack;
    public int[] Save_ItemQuantity;
    public int[] Save_GameModeScore;
    public List<S_List_Challenges> Save_ChallengeList;

    public S_PlayerData(S_GameManager player)
    {
        Save_StandardHighScore = player.Save_StandardHighScore;
        Save_HardcoreHighScore = player.Save_HardcoreHighScore;
        Save_GlitchHighScore = player.Save_GlitchHighScore;
        Save_DiamondRoomScore = player.Save_DiamondRoomScore;
        Save_Currency = player.Save_Currency;
        Save_DiamondKeys = player.Save_DiamondKeys;
        Save_LeftItem = player.Save_LeftItem;
        Save_RightItem = player.Save_RightItem;
        Save_ThemeActive = player.Save_ThemeActive;
        Save_JarPackActive = player.Save_JarPackActive;
        Save_Throwable = player.Save_Throwable;
        Save_JarsSmashedSmall = player.Save_JarsSmashedSmall;
        Save_JarsSmashedLarge = player.Save_JarsSmashedLarge;
        Save_JarsSmashedMedium = player.Save_JarsSmashedMedium;
        Save_ObjectsThrown = player.Save_ObjectsThrown;
        Save_ItemsUsed = player.Save_ItemsUsed;
        Save_NoAds = player.Save_NoAds;
        Save_ScoreSpacer = player.Save_ScoreSpacer;
        Save_MenuTheme = player.Save_MenuTheme;
        Save_Levels = player.Save_Level;

        Save_JarsPurchased = new bool[player.List_Of_Jars.Count];
        Save_ThrowablesPurchased = new bool[player.List_Of_Throwables.Count];
        Save_ThemesPurchased = new bool[player.List_Of_Themes.Count];
        Save_ItemQuantity = new int[player.List_Of_Items.Count];

        Save_ThrowablesHighScore = new int[player.List_Of_Throwables.Count];
        Save_ThrowablesHardcoreScore = new int[player.List_Of_Throwables.Count];
        Save_ThrowablesObjectsThrown = new int[player.List_Of_Throwables.Count];
        Save_ThrowablesObjectsHit = new int[player.List_Of_Throwables.Count];

        Save_JarHighScore = new int[player.List_Of_Jars.Count];
        Save_JarHardcoreScore = new int[player.List_Of_Jars.Count];
        Save_JarObjectsSmashed = new int[player.List_Of_Jars.Count];
        Save_GameModeScore = new int[player.List_Of_GameModes.Count];

        Save_ItemsUsedPack = new int[player.List_Of_Items.Count];

        for (int i = 0; i < player.List_Of_Jars.Count; i++)
        {
            Save_JarsPurchased[i] = player.List_Of_Jars[i].Purchased;
            Save_JarHighScore[i] = player.List_Of_Jars[i].HighScore;
            Save_JarHardcoreScore[i] = player.List_Of_Jars[i].HardcoreScore;
            Save_JarObjectsSmashed[i] = player.List_Of_Jars[i].ObjectsSmashed;
        }

        for (int i = 0; i < player.List_Of_Throwables.Count; i++)
        {
            Save_ThrowablesPurchased[i] = player.List_Of_Throwables[i].Purchased;
            Save_ThrowablesHighScore[i] = player.List_Of_Throwables[i].HighScore;
            Save_ThrowablesHardcoreScore[i] = player.List_Of_Throwables[i].HardcoreScore;
            Save_ThrowablesObjectsHit[i] = player.List_Of_Throwables[i].ObjectsHit;
            Save_ThrowablesObjectsThrown[i] = player.List_Of_Throwables[i].ObjectsThrown;
        }

        for (int i = 0; i < player.List_Of_Themes.Count; i++)
        {
            Save_ThemesPurchased[i] = player.List_Of_Themes[i].Purchased;
        }

        for (int i = 0; i < player.List_Of_GameModes.Count; i++)
        {
            Save_GameModeScore[i] = player.List_Of_GameModes[i].Score;
        }

        for (int i = 0; i < player.List_Of_Items.Count; i++)
        {
            Save_ItemQuantity[i] = player.List_Of_Items[i].Quantity;
            Save_ItemsUsedPack[i] = player.List_Of_Items[i].Uses;
        }

        Save_ChallengeList = player.List_Of_Challenges;

    }
}
