using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
using System.Collections.Generic;

public class S_GameManager : MonoBehaviour {

    //Objects
	public List<GameObject> ThrowableObject;
    public List<GameObject> JarObject;

    //Prefab GameObjects
    public GameObject ThrowingModeIcon;
    public GameObject FakeUILight;
    public GameObject SpacerPrefab;
    public GameObject StatPrefab;
    public GameObject GameModePrefab;
    public GameObject GameModePrefab2;
    public GameObject SmallGameModePrefab;
    public GameObject PurchasePrefab;
    public GameObject PurchaseItemPrefab;
    public GameObject ChallengePrefab;
    public GameObject ThrowableSpawn;
    public GameObject HammerThrowablePrefab;
    public GameObject FireworkSpawnablePrefab;
    public GameObject BalloonObjectPrefab;
    public GameObject MatchThrowablePrefab;
    public GameObject _AllocatedSpawnable;
    public GameObject HelpUIPrefab;

    public GameObject LoadedThrowable;
	public GameObject Camera;
	public GameObject ScoreCounter;
    public GameObject RightCounterUI;
    public GameObject LeftCounterUI;
	public GameObject ComboCounter;
    public GameObject ComboDotPrefab;
    public GameObject QuantityText;
    public GameObject CurrentJar;
    public GameObject JarSmash;
    public GameObject JarSpawn;
    public GameObject CurrentSpawnableObject;
    public GameObject BalloonSpawnRight;
    public GameObject BalloonSpawnLeft;
    public GameObject ScoreSpacer;
    public GameObject DashSpacer;
    public GameObject UI_StandardScoreboard;
    public GameObject DashBar;
    public GameObject Canvas_GalleryImage;

    //Environment GameObjects
    public GameObject FloorPiece;
    public GameObject WallPiece;
    public GameObject DirectionalLight;

    //Sound GameObjects
    public GameObject SOUNDMANAGER;
    public GameObject MUSICMANAGER;
    public GameObject Sound_GainCoin;
    public GameObject Sound_ComboComplete;
    public GameObject Sound_ChallengeComplete;
    public GameObject Sound_HitJar;
    public GameObject Sound_PopBalloon;
    public GameObject Sound_SmashJar;
    public GameObject Sound_UseItem;
    public GameObject Sound_ThrowObject;
    public GameObject Sound_HitSurface;
    public GameObject Sound_UIButtons;
    public GameObject Music_GentleGuitarLoop;

    //Checks
    public int _CurrentlyActiveTheme;
    public bool Randomiser;
    public bool FreezeJar;
    public string GameMode;
    public bool GoldBonus;
    public bool UltraGoldBonus;
    public bool ThrowableLoaded;
    public bool UsingSpecialThrowable;
    public bool AwardingCoinsProcess;
    public bool CreateSpawnable;
    public bool BalloonBonus;
    public bool ActivateBalloonOnce;
    public bool DashCounter;
    public bool WithinMenus;

    //Saving
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
    public bool Save_NoAds;
    public int Save_GameModeActive;
    public int Save_ScoreSpacer;
    public int Save_MenuTheme;

    public int Save_Level;
    public bool Save_Mute;

    //Menu
    public GameObject RemoveAdsButton;
    public GameObject HomeScreen;
    public GameObject MainMenuButton;
    public GameObject GameOverScreen;
    public GameObject MenuContainer;
    public GameObject MainMenu;
    public GameObject MM_EscalationScore;
    public GameObject MM_ClassicScore;
    public GameObject MM_Level;
    public GameObject ChallengeMenu;
    public GameObject CM_GameModeGrid;
    public GameObject CM_ThrowablesGrid;
    public GameObject CM_JarsGrid;
    public GameObject CM_ItemGrid;
    public GameObject SettingsMenu;
    public GameObject PlayMenu;
    public GameObject StoreMenu;
    public GameObject HelpMenu;
    public GameObject JarGrid;
    public GameObject ThemeGrid;
    public GameObject ThrowableGrid;
    public GameObject ItemGrid;
    public GameObject CurrencyGrid;
    public GameObject HelpGrid;
    public Text VersionNumber;
    public GameObject[] MenuThemeElements;
    public GameObject Settings_MenuThemeGrid;
    public Color MenuThemeColour;
    public Color[] MenuColourThemes;
    

    //Purchases
    public int Award_Ad_Currency;
    public int Award_MT_Currency_1;


    //Settings
    public int SelectedJar;
	public int Score;
	public int ComboCountIndex;
    public int RandomCount;
    public int Quantity;
    public int StartComboCap;
    public int ComboCap;
    public int ComboAward;
    public int ActivateAnimationPercent;
    public int GoldPercent;
    public int GoldAward;
    public int UltraGoldAward;
    public int BalloonPercent;
    public int DiamondKeysRequired;
    public int JarsSmashedSmall;
    public int JarsSmashedMedium;
    public int JarsSmashedLarge;
    public int ObjectsThrown;
    public int DiamondKeysEarned;
    public int GoldEarned;
    public int AdCountdownMax;
    public float AdCountdown;
    public int Level_StartGoal;
    public int Level_Multiplier;
    public int Level_LevelsGainedinMatch;
    public float DD_TimeAdded;
    public float DD_Counter;
    public float DD_TimeCap;
    public int DD_GroupScore;
    public int DD_GroupCap;
    public int DD_TargetScore;

    public string CurrentJarSize;
    public string CurrentBalloonType;

    public float Volume = 0.5f;
    public float MusicPitchChangeHigh = 1;
    public float MusicPitchChangeLow = 0.5f;
    public float JarSpawnRangeX = 1.9f;
    public float JarSpawnRangeY = 1;
    public float JarSpawnZDefault;
    public float FreezeCounter;
    public float FreezeCounterMax;
    public float GameOverWait;
    public float SmashJarPitchLow;
    public float SmashJarPitchHigh;
    public float HitJarPitchLow;
    public float HitJarPitchHigh;
    public float HitSurfacePitchLow;
    public float HitSurfacePitchHigh;
    public float SmashJarDelayCount;
    public float SwipeXLimits;

    //Jar Settings
    public bool AdvancedThrowing;

    //Special Jar Pack ID's
    public int PreviousThemeID;
    public int PreviousJarID;
    public int PreviousThrowableID;
    public int DiamondRoomThemeID;
    public int DiamondRoomJarsID;
    public int DiamondRoomThrowableID;

    //Random ID's
    public bool RandomJar;
    public bool RandomThrowable;
    public bool RandomTheme;

    //Materials
    public Material Gold;
    public Material Diamond;
    public Material CurrentlySelectedJarColour;

    public AudioClip Throw;

    //Challenge Info
    public string[] AvailableJarSizes;
    public int ChallengesToCreate;
    public int ChallengeMinAward;
    public int ChallengeMaxAward;
    public int ChallengeRequiredMultiplier;

    //Colour DB
    public Color PurchaseColour;
    public Color BackColour;
    public Color DiamondKeyColor;
    public Color GoldCurrencyColour;
    public Color StandardGreyTextColour;
    public Color LevelColour;

    //Sprites
    public Sprite ObjectsThrownIcon;
    public Sprite AccuracyIcon;
    public Sprite ShatterIcon;
    public Sprite HighScoreIcon;
    public Sprite HardcoreScoreIcon;
    public Sprite AxisIcon2;
    public Sprite AxisIcon4;
    public Sprite DashIcon;


    //Audio Clips
    public AudioClip Audio_Proceed;
    public AudioClip Audio_Back;
    public AudioClip Audio_Purchase;
    public AudioClip Audio_GainGold;
    public AudioClip Audio_Denied;
    public AudioClip Audio_Equip;
    public AudioClip Audio_MenuMusic;


    //Database
    public List<string> _temp_Gallery;
    public List<S_List_Jar> List_Of_Jars;
    public List<S_List_Purchases> List_Of_Purchases;
    public List<S_List_Themes> List_Of_Themes;
    public List<S_List_Throwables> List_Of_Throwables;
    public List<S_List_Challenges> List_Of_Challenges;
    public List<S_List_Items> List_Of_Items;
    public List<S_List_GameModes> List_Of_GameModes;
    public List<S_List_MenuColourThemes> List_Of_MenuColourThemes;
    public List<S_List_Gallery> List_Of_Dogs;
    public List<S_List_Help> List_Of_Hints;

    //Referances
    public S_AdManager AdManager;

    //Debug
    public bool CreateFalseLight;

    // Use this for initialization
    void Start () 
	{
        if(Application.isMobilePlatform == true)
        {
            CreateFalseLight = true;
        }

        VersionNumber.text = "ver "+Application.version;
        AdManager = GameObject.FindGameObjectWithTag("AdManager").GetComponent<S_AdManager>();
        AdCountdown = AdCountdownMax;
        Quantity = List_Of_GameModes[0].StartQuantity;
        
        AdjustVolume();
        UpdateUI();
        
        LoadGameData();
        //CreateCustomizeOptions();
        //CreatePlayMenu();
        //UpdateMainItemsUI();
        //UpdateMainMenuUI();
        //LoadTheme(Save_ThemeActive,0);
    }
	
	// Update is called once per frame
	void Update () 
	{

        if(FreezeJar == true)
        {
            FreezeCounter -= Time.deltaTime;
            CurrentJar.GetComponent<Animator>().SetFloat("animSpeed",0);
            CurrentJar.transform.GetChild(1).GetChild(0).GetComponent<Image>().fillAmount = FreezeCounter / 10;
            if (FreezeCounter < 0)
            {
                FreezeJar = false;
                CurrentJar.GetComponent<Animator>().SetFloat("animSpeed", 1);
            }
        } 

        if(GameMode == "dash" && DashCounter == true)
        {
            DD_Counter -= Time.deltaTime;
            DashBar.GetComponent<Slider>().value = DD_Counter;
            if(DD_Counter<=0)
            {
                //game over
                GameOver();
            }
        }
	}

    public void SaveGameData()
    {
        S_SaveSystem.SavePlayer(this);
    }

    public void LoadGameData()
    {
        S_PlayerData data = S_SaveSystem.LoadPlayer(this);

        if (data != null)
        {
            Save_StandardHighScore = data.Save_StandardHighScore;
            Save_HardcoreHighScore = data.Save_HardcoreHighScore;
            Save_GlitchHighScore = data.Save_GlitchHighScore;
            Save_DiamondRoomScore = data.Save_DiamondRoomScore;
            Save_Currency = data.Save_Currency;
            Save_DiamondKeys = data.Save_DiamondKeys;
            Save_LeftItem = data.Save_LeftItem;
            Save_RightItem = data.Save_RightItem;
            Save_ThemeActive = data.Save_ThemeActive;
            Save_JarPackActive = data.Save_JarPackActive;
            Save_Throwable = data.Save_Throwable;
            Save_JarsSmashedSmall = data.Save_JarsSmashedSmall;
            Save_JarsSmashedLarge = data.Save_JarsSmashedLarge;
            Save_JarsSmashedMedium = data.Save_JarsSmashedMedium;
            Save_ObjectsThrown = data.Save_ObjectsThrown;
            Save_NoAds = data.Save_NoAds;
            Save_ScoreSpacer = data.Save_ScoreSpacer;
            Save_MenuTheme = data.Save_MenuTheme;
            Save_Level = data.Save_Levels;

            for (int i = 0; i < data.Save_JarsPurchased.Length; i++)
            {
                List_Of_Jars[i].Purchased = data.Save_JarsPurchased[i];
                List_Of_Jars[i].HighScore = data.Save_JarHighScore[i];
                List_Of_Jars[i].HardcoreScore = data.Save_JarHardcoreScore[i];
                List_Of_Jars[i].ObjectsSmashed = data.Save_JarObjectsSmashed[i];
            }

            for (int i = 0; i < data.Save_ThrowablesPurchased.Length; i++)
            {
                List_Of_Throwables[i].Purchased = data.Save_ThrowablesPurchased[i];
                List_Of_Throwables[i].HighScore = data.Save_ThrowablesHighScore[i];
                List_Of_Throwables[i].HardcoreScore = data.Save_ThrowablesHardcoreScore[i];
                List_Of_Throwables[i].ObjectsHit = data.Save_ThrowablesObjectsHit[i];
                List_Of_Throwables[i].ObjectsThrown = data.Save_ThrowablesObjectsThrown[i];
            }

            for (int i = 0; i < data.Save_ThemesPurchased.Length; i++)
            {
                List_Of_Themes[i].Purchased = data.Save_ThemesPurchased[i];
            }

            if (data.Save_GameModeScore != null && data.Save_GameModeScore.Length > 0)
            {
                for (int i = 0; i < data.Save_GameModeScore.Length; i++)
                {
                    List_Of_GameModes[i].Score = data.Save_GameModeScore[i];
                }
            }

            for (int i = 0; i < data.Save_ItemQuantity.Length; i++)
            {
                List_Of_Items[i].Quantity = data.Save_ItemQuantity[i];
                List_Of_Items[i].Uses = data.Save_ItemsUsedPack[i];
            }

            List_Of_Challenges = data.Save_ChallengeList;

            LoadEquippedItems();
            BeginStartUp();

            //if (List_Of_Challenges.Count == 0)
            //{
            //    NoLoadData();
            //}
        }
        else
        {

        }

    }

    public void NoLoadData()
    {
        CreateChallenge(4);
        BeginStartUp();
    }

    public void BeginStartUp()
    {
        LoadEquippedItems();
        CreateCustomizeOptions();
        CreatePlayMenu();
        CreateHelpMenu();
        UpdateMainItemsUI();
        UpdateMainMenuUI();
        LoadTheme(Save_ThemeActive, 0);
        CreateMenuThemeList();

        MUSICMANAGER.transform.GetChild(0).GetComponent<AudioSource>().clip = Audio_MenuMusic;
        if (Save_Mute == false)
        {
            MUSICMANAGER.transform.GetChild(0).GetComponent<AudioSource>().Play();
        }
    }

    public void PlayUIButtonSound(AudioClip _sound)
    {
        Sound_UIButtons.GetComponent<AudioSource>().clip = _sound;
        Sound_UIButtons.GetComponent<AudioSource>().Play();
    }

    public void PlayProceedSound()
    {
        PlayUIButtonSound(Audio_Proceed);
    }

    public void PlayBackSound()
    {
        PlayUIButtonSound(Audio_Back);
    }

    public void PlayEquipSound()
    {
        PlayUIButtonSound(Audio_Equip);
    }

    public void PlayGainGoldSound()
    {
        PlayUIButtonSound(Audio_GainGold);
    }

    public void CheckIfRemoveAdsIsBought()
    {
        if(Save_NoAds == true)
        {
            RemoveAdsButton.GetComponent<Image>().color = PurchaseColour;
        }
    }

    public void PlayAdOnCountdown(bool _goToMenu)
    {
        if (Save_NoAds == false)
        {
            AdCountdown-= List_Of_GameModes[Save_GameModeActive].AdWeightReducer;
            if (AdCountdown <= 0)
            {
                AdManager.PlayInterstitialAd();
                AdCountdown = AdCountdownMax;
            }
            else if (_goToMenu == true)
            {
                OpenMenuUI(MainMenu);
            }
            else if (_goToMenu == false)
            {
                NewGame(Save_GameModeActive);
            }
        }
        else if(_goToMenu == true)
        {
            OpenMenuUI(MainMenu);
        }
        else if(_goToMenu == false)
        {
            NewGame(Save_GameModeActive);
        }

    }


    public void ToggleAllAudio(bool _on) 
    {
        for (int i = 0; i < SOUNDMANAGER.transform.childCount; i++)
        {
            SOUNDMANAGER.transform.GetChild(i).GetComponent<AudioSource>().enabled = _on;
        }

        if (Save_Mute == false)
        {
            for (int i = 0; i < MUSICMANAGER.transform.childCount; i++)
            {
                MUSICMANAGER.transform.GetChild(i).GetComponent<AudioSource>().enabled = _on;
            }
        }
    }

    public void ChangeMusic(AudioClip _music)
    {
        MUSICMANAGER.transform.GetChild(0).GetComponent<AudioSource>().enabled = true;
        MUSICMANAGER.transform.GetChild(0).GetComponent<AudioSource>().clip = _music;
        MUSICMANAGER.transform.GetChild(0).GetComponent<AudioSource>().Play();
    }

    public void MuteMusic(bool _active)
    {
        if(_active == false)
        {
            MUSICMANAGER.transform.GetChild(0).GetComponent<AudioSource>().Stop();
            Save_Mute = true;
        }
        else
        {
            MUSICMANAGER.transform.GetChild(0).GetComponent<AudioSource>().Play();
            Save_Mute = false;
        }
        
    }

    public void CreatePlayMenu()
    {


        for (int i = 0; i < List_Of_GameModes.Count; i++)
        {
            GameObject _stat = Instantiate(SmallGameModePrefab, transform.position, transform.rotation, PlayMenu.transform) as GameObject;
            _stat.transform.GetChild(1).GetComponent<Text>().text = List_Of_GameModes[i].Name ;
            _stat.transform.GetChild(1).GetComponent<Text>().fontSize = 84;
            _stat.transform.GetChild(1).GetComponent<Text>().color = List_Of_GameModes[i].TextColour;
            _stat.transform.GetChild(0).GetComponent<Image>().color = List_Of_GameModes[i].TextColour;
            _stat.GetComponent<LayoutElement>().minHeight = 170;
            int _index = i;
            _stat.GetComponent<Button>().onClick.AddListener(() => NewGame(_index));
            //_stat.GetComponent<Button>().onClick.AddListener(() => SwitchToAdvancedThrowing(false));


            if (List_Of_GameModes[i].Details.Length > 0)
            {
                for (int ib = 0; ib < List_Of_GameModes[i].Details.Length; ib++)
                {
                    GameObject _stat2 = Instantiate(GameModePrefab, transform.position, transform.rotation, PlayMenu.transform) as GameObject;
                    _stat2.GetComponent<Text>().text = List_Of_GameModes[i].Details[ib];
                    _stat2.GetComponent<Text>().fontSize = 60;
                    _stat2.GetComponent<Text>().color = List_Of_GameModes[i].TextColour;
                    _stat2.GetComponent<LayoutElement>().minHeight = 70;
                    _stat2.GetComponent<Button>().enabled = false;
                }
            }

            GameObject _spacer = Instantiate(SpacerPrefab, transform.position, transform.rotation, PlayMenu.transform) as GameObject;
            _spacer.GetComponent<LayoutElement>().minHeight = 5;
            _spacer.transform.GetChild(0).gameObject.SetActive(false);


        }

        GameObject _stat0 = Instantiate(SmallGameModePrefab, transform.position, transform.rotation, PlayMenu.transform) as GameObject;
        _stat0.transform.GetChild(1).GetComponent<Text>().text = "simple throwing";
        _stat0.transform.GetChild(1).GetComponent<Text>().fontSize = 84;
        _stat0.transform.GetChild(1).GetComponent<Text>().color = Color.grey;
        _stat0.transform.GetChild(0).GetComponent<Image>().sprite = AxisIcon2;
        _stat0.GetComponent<Button>().onClick.AddListener(() => SwitchToAdvancedThrowing(false));
        _stat0.GetComponent<Button>().onClick.AddListener(() => PlayProceedSound());
        _stat0.GetComponent<LayoutElement>().minHeight = 170;

        GameObject _stat00 = Instantiate(SmallGameModePrefab, transform.position, transform.rotation, PlayMenu.transform) as GameObject;
        _stat00.transform.GetChild(1).GetComponent<Text>().text = "advanced throwing";
        _stat00.transform.GetChild(1).GetComponent<Text>().fontSize = 84;
        _stat00.transform.GetChild(1).GetComponent<Text>().color = Color.grey;
        _stat00.transform.GetChild(0).GetComponent<Image>().sprite = AxisIcon4;
        _stat00.GetComponent<Button>().onClick.AddListener(() => SwitchToAdvancedThrowing(true));
        _stat00.GetComponent<Button>().onClick.AddListener(() => PlayProceedSound());
        _stat00.GetComponent<LayoutElement>().minHeight = 170;
    }

    public void SwitchToAdvancedThrowing(bool _active)
    {
        AdvancedThrowing = _active;

        if(_active == false)
        {
            ThrowingModeIcon.GetComponent<Image>().sprite = AxisIcon2;
        }
        else
        {
            ThrowingModeIcon.GetComponent<Image>().sprite = AxisIcon4;
        }
    }


    public void CreateChallenge(int _amount)
    {
        List<int> _tempjars = new List<int>();
        List<int> _tempthrowables = new List<int>();

        for (int i = 0; i < List_Of_Jars.Count; i++)
        {
            if (List_Of_Jars[i].Purchased == true && List_Of_Jars[i].Unlisted == false)
            {
                _tempjars.Add(i);
            }
        }

        for (int i = 0; i < List_Of_Throwables.Count; i++)
        {
            if (List_Of_Throwables[i].Purchased == true && List_Of_Throwables[i].Unlisted == false)
            {
                _tempthrowables.Add(i);
            }
        }

        for (int ix = 0; ix < _amount; ix++)
        {
            int _rewardQuantity = Random.Range(ChallengeMinAward, ChallengeMaxAward + 1);
            int _requiredQuantity = _rewardQuantity * ChallengeRequiredMultiplier;

            int _jartype = _tempjars[Random.Range(0, _tempjars.Count)];
            int throwtype = _tempthrowables[Random.Range(0, _tempthrowables.Count)];
            //string _chosenSize =  List_Of_Jars[_jartype].JarObjects[Random.Range(0, List_Of_Jars[_jartype].JarObjects.Count)].JarSize;

            string _name = "smash " + _requiredQuantity + " " + List_Of_Jars[_jartype].Name + " with " + List_Of_Throwables[throwtype].Name;

            List_Of_Challenges.Add(new S_List_Challenges(_jartype, throwtype, _requiredQuantity, 0, "",_name,_rewardQuantity));
        }

        UpdateChallengesUI();
        SaveGameData();
    }

    public void UpdateChallengesUI()
    {
        if (GameOverScreen.transform.GetChild(1).GetChild(3).childCount > 0)
        {
            foreach (Transform child in GameOverScreen.transform.GetChild(1).GetChild(3))
            {
                Destroy(child.gameObject);
            }
        }

        if (ChallengeMenu.transform.GetChild(1).childCount > 0)
        {
            foreach (Transform child in ChallengeMenu.transform.GetChild(1))
            {
                Destroy(child.gameObject);
            }
        }

        for (int i = 0; i < List_Of_Challenges.Count; i++)
        {
            if (List_Of_Challenges[i].JarType == Save_JarPackActive && List_Of_Challenges[i].ThrowableType == Save_Throwable)
            {
                int _totalsum0 = JarsSmashedSmall + JarsSmashedMedium + JarsSmashedLarge;
                List_Of_Challenges[i].AmountCompleted += _totalsum0;
                //if (List_Of_Challenges[i].JarSize == "small")
                //{
                //    List_Of_Challenges[i].AmountCompleted += JarsSmashedSmall;
                //}
                //else if (List_Of_Challenges[i].JarSize == "medium")
                //{
                //    List_Of_Challenges[i].AmountCompleted += JarsSmashedMedium;
                //}
                //else if (List_Of_Challenges[i].JarSize == "large")
                //{
                //    List_Of_Challenges[i].AmountCompleted += JarsSmashedLarge;
                //}
            }

            //Game Over Screen - Challenges
            GameObject _challenge = Instantiate(ChallengePrefab, transform.position, transform.rotation, GameOverScreen.transform.GetChild(1).GetChild(3)) as GameObject;
            _challenge.transform.GetChild(0).GetComponent<Slider>().maxValue = List_Of_Challenges[i].AmountNeeded;
            _challenge.transform.GetChild(0).GetComponent<Slider>().value = List_Of_Challenges[i].AmountCompleted;
            _challenge.transform.GetChild(1).GetComponent<Text>().text = List_Of_Challenges[i].Name;
            _challenge.transform.GetChild(2).GetComponent<Text>().text = "+"+List_Of_Challenges[i].ChallengeValue;

            //Challenge Menu - Challenges
            GameObject _challenge2 = Instantiate(ChallengePrefab, transform.position, transform.rotation, ChallengeMenu.transform.GetChild(1)) as GameObject;
            _challenge2.transform.GetChild(0).GetComponent<Slider>().maxValue = List_Of_Challenges[i].AmountNeeded;
            _challenge2.transform.GetChild(0).GetComponent<Slider>().value = List_Of_Challenges[i].AmountCompleted;
            _challenge2.transform.GetChild(1).GetComponent<Text>().text = List_Of_Challenges[i].Name;
            _challenge2.transform.GetChild(2).GetComponent<Text>().text = "+" + List_Of_Challenges[i].ChallengeValue;
            int _index = i;
            _challenge2.GetComponent<Button>().onClick.AddListener(() => ClaimChallenge(_index));

            if (List_Of_Challenges[i].AmountCompleted >= List_Of_Challenges[i].AmountNeeded)
            {
                _challenge.transform.GetChild(3).GetComponent<Text>().text = "done!";
                _challenge2.transform.GetChild(3).GetComponent<Text>().text = "claim!";
            }
            else
            {
                _challenge.transform.GetChild(3).GetComponent<Text>().text = List_Of_Challenges[i].AmountCompleted + "/" + List_Of_Challenges[i].AmountNeeded;
                _challenge2.transform.GetChild(3).GetComponent<Text>().text = List_Of_Challenges[i].AmountCompleted + "/" + List_Of_Challenges[i].AmountNeeded;
            }
        }

        //Game Over Screen - Object Counters
        GameOverScreen.transform.GetChild(1).GetChild(5).GetChild(0).GetComponent<Text>().text = JarsSmashedSmall + " small jars";
        GameOverScreen.transform.GetChild(1).GetChild(6).GetChild(0).GetComponent<Text>().text = JarsSmashedMedium + " medium jars";
        GameOverScreen.transform.GetChild(1).GetChild(7).GetChild(0).GetComponent<Text>().text = JarsSmashedLarge + " large jars";
        GameOverScreen.transform.GetChild(1).GetChild(8).GetChild(0).GetComponent<Text>().text = ObjectsThrown + " objects thrown";
        float _totalsum = JarsSmashedSmall + JarsSmashedMedium + JarsSmashedLarge;
        _totalsum = _totalsum / ObjectsThrown;
        GameOverScreen.transform.GetChild(1).GetChild(9).GetChild(0).GetComponent<Text>().text = (_totalsum *100).ToString("f1") + "% accuracy";
        GameOverScreen.transform.GetChild(1).GetChild(10).GetChild(0).GetComponent<Text>().text = "+" + DiamondKeysEarned + " keys earned";

        //Challenge Menu - Object Counters
        ChallengeMenu.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = Save_JarsSmashedSmall + " small jars smashed";
        ChallengeMenu.transform.GetChild(4).GetChild(0).GetComponent<Text>().text = Save_JarsSmashedMedium + " medium jars smashed";
        ChallengeMenu.transform.GetChild(5).GetChild(0).GetComponent<Text>().text = Save_JarsSmashedLarge + " large jars smashed";
        ChallengeMenu.transform.GetChild(6).GetChild(0).GetComponent<Text>().text = Save_JarsSmashedSmall + Save_JarsSmashedLarge+ Save_JarsSmashedMedium + " total jars smashed";
        ChallengeMenu.transform.GetChild(7).GetChild(0).GetComponent<Text>().text = Save_ObjectsThrown + " objects thrown";
        float _totalsum2 = Save_JarsSmashedSmall + Save_JarsSmashedMedium + Save_JarsSmashedLarge;
        _totalsum2 = _totalsum2 / Save_ObjectsThrown;
        ChallengeMenu.transform.GetChild(8).GetChild(0).GetComponent<Text>().text = (_totalsum2 * 100).ToString("f1") + "% accuracy";
        ChallengeMenu.transform.GetChild(9).GetChild(0).GetComponent<Text>().text = Save_ItemsUsed.ToString() + " items used";

        JarsSmashedSmall = 0;
        JarsSmashedMedium = 0;
        JarsSmashedLarge = 0;
        ObjectsThrown = 0;
        DiamondKeysEarned = 0;
        GoldEarned = 0;

    }

    public void ClaimChallenge(int _index)
    {
        if(List_Of_Challenges[_index].AmountCompleted >= List_Of_Challenges[_index].AmountNeeded)
        {
            Save_Currency += List_Of_Challenges[_index].ChallengeValue;
            List_Of_Challenges.RemoveAt(_index);
            CreateChallenge(1);
            PlayUIButtonSound(Audio_GainGold);
            UpdateMainItemsUI();
        }
        
    }

    public void Debug_AddCoins(int _amount)
    {
        Save_Currency += _amount;
        UpdateMainItemsUI();
    }

    public void CreateStatsList()
    {
        //Create Game Mode List
        for (int ib = 0; ib < List_Of_GameModes.Count; ib++)
        {
            GameObject _statGrid = CM_GameModeGrid;
            GameObject _stat = Instantiate(StatPrefab, transform.position, transform.rotation, _statGrid.transform) as GameObject;
            _stat.transform.GetChild(0).GetComponent<Text>().text = List_Of_GameModes[ib].Name + " score: "+List_Of_GameModes[ib].Score;
            _stat.transform.GetChild(1).GetComponent<Image>().sprite = List_Of_GameModes[ib].Icon;// _icons[ib];
            _stat.transform.GetChild(1).GetComponent<Image>().color = List_Of_GameModes[ib].TextColour;
        }

        //Create Jar Options
        for (int i = 0; i < List_Of_Jars.Count; i++)
        {
            GameObject _statGrid = CM_JarsGrid;
            string[] _stats = new string[] { List_Of_Jars[i].Name, List_Of_Jars[i].ObjectsSmashed + " jars smashed" };
            Sprite[] _icons = new Sprite[] { List_Of_Jars[i].Icon, ShatterIcon };
            if (i > 0)
            {
                GameObject _spacer = Instantiate(SpacerPrefab, transform.position, transform.rotation, _statGrid.transform) as GameObject;
            }
            for (int ib = 0; ib < _stats.Length; ib++)
            {
                GameObject _stat = Instantiate(StatPrefab, transform.position, transform.rotation, _statGrid.transform) as GameObject;
                _stat.transform.GetChild(0).GetComponent<Text>().text = _stats[ib];
                _stat.transform.GetChild(1).GetComponent<Image>().sprite = List_Of_Jars[i].Icon;// _icons[ib];
            }
        }

        //Create Throwable Options
        for (int i = 0; i < List_Of_Throwables.Count; i++)
        {
            GameObject _statGrid = CM_ThrowablesGrid;
            float _acc;
            if (List_Of_Throwables[i].ObjectsThrown > 0)
            {
                _acc = List_Of_Throwables[i].ObjectsHit;
                _acc = _acc / List_Of_Throwables[i].ObjectsThrown;
            }
            else
            {
                _acc = 0;
            }
            string[] _stats = new string[] { List_Of_Throwables[i].Name, List_Of_Throwables[i].ObjectsHit + " jars smashed", List_Of_Throwables[i].ObjectsThrown + " objects thrown",
            (_acc * 100).ToString("f1") + "% accuracy"};
            Sprite[] _icons = new Sprite[] { List_Of_Throwables[i].Icon, ObjectsThrownIcon, AccuracyIcon };

            if (i > 0)
            {
                GameObject _spacer = Instantiate(SpacerPrefab, transform.position, transform.rotation, _statGrid.transform) as GameObject;
            }
            for (int ib = 0; ib < _stats.Length; ib++)
            {
                GameObject _stat = Instantiate(StatPrefab, transform.position, transform.rotation, _statGrid.transform) as GameObject;
                _stat.transform.GetChild(0).GetComponent<Text>().text = _stats[ib];
                _stat.transform.GetChild(1).GetComponent<Image>().sprite = List_Of_Throwables[i].Icon;//_icons[ib];
            }
        }

        //Create Item Options
        for (int i = 0; i < List_Of_Items.Count; i++)
        {
            GameObject _statGrid = CM_ItemGrid;
            GameObject _stat = Instantiate(StatPrefab, transform.position, transform.rotation, _statGrid.transform) as GameObject;
            _stat.transform.GetChild(0).GetComponent<Text>().text = List_Of_Items[i].Uses + "  " + List_Of_Items[i].Name + " items used";
            _stat.transform.GetChild(1).GetComponent<Image>().sprite = List_Of_Items[i].Icon;
        }
    }

    public void ClearStatsList()
    {
        //clear game mode stats
        if (CM_GameModeGrid.transform.childCount > 0)
        {
            foreach (Transform child in CM_GameModeGrid.transform)
            {
                Destroy(child.gameObject);
            }
        }

        //clear jars stats
        if (CM_JarsGrid.transform.childCount > 0)
        {
            foreach (Transform child in CM_JarsGrid.transform)
            {
                Destroy(child.gameObject);
            }
        }

        //clear throwables stats
        if (CM_ThrowablesGrid.transform.childCount > 0)
        {
            foreach (Transform child in CM_ThrowablesGrid.transform)
            {
                Destroy(child.gameObject);
            }
        }

        //clear item stats
        if (CM_ItemGrid.transform.childCount > 0)
        {
            foreach (Transform child in CM_ItemGrid.transform)
            {
                Destroy(child.gameObject);
            }
        }

        CreateStatsList();
    }

    public void CreateCustomizeOptions()
    {
        //Create Jar Options
        for (int i = 0; i < List_Of_Jars.Count; i++)
        {
            if (List_Of_Jars[i].Unlisted == false)
            {
                GameObject _purchaser = Instantiate(PurchasePrefab, transform.position, transform.rotation, JarGrid.transform) as GameObject;
                _purchaser.transform.GetChild(0).GetComponent<Text>().text = List_Of_Jars[i].Name;
                _purchaser.transform.GetChild(1).GetComponent<Image>().sprite = List_Of_Jars[i].Icon;
                _purchaser.transform.GetChild(2).GetComponent<Text>().text = "lvl." + List_Of_Jars[i].UnlockLevel.ToString();
                _purchaser.transform.GetChild(2).GetComponent<Text>().color = LevelColour;
                _purchaser.transform.GetChild(3).GetComponent<Image>().sprite = HighScoreIcon;
                _purchaser.transform.GetChild(3).GetComponent<Image>().color = LevelColour;
                List_Of_Jars[i].ButtonUI = _purchaser;
                int _indeX = i;
                _purchaser.GetComponent<Button>().onClick.AddListener(() => PurchaseItem(_indeX, "jar", _purchaser));
                if (/*List_Of_Jars[i].Purchased==true*/ List_Of_Jars[i].UnlockLevel<= Save_Level)
                {
                    _purchaser.transform.GetChild(2).GetComponent<Text>().text = "✓";
                }
            }
        }

        //Create Theme Options
        for (int i = 0; i < List_Of_Themes.Count; i++)
        {
            if (List_Of_Themes[i].Unlisted == false)
            {
                GameObject _purchaser = Instantiate(PurchasePrefab, transform.position, transform.rotation, ThemeGrid.transform) as GameObject;
                _purchaser.transform.GetChild(0).GetComponent<Text>().text = List_Of_Themes[i].Name;
                _purchaser.transform.GetChild(1).GetComponent<Image>().sprite = List_Of_Themes[i].Icon;
                _purchaser.transform.GetChild(2).GetComponent<Text>().text = "lvl." + List_Of_Themes[i].UnlockLevel.ToString();
                _purchaser.transform.GetChild(2).GetComponent<Text>().color = LevelColour;
                _purchaser.transform.GetChild(3).GetComponent<Image>().sprite = HighScoreIcon;
                _purchaser.transform.GetChild(3).GetComponent<Image>().color = LevelColour;
                List_Of_Themes[i].ButtonUI = _purchaser;
                int _indeX = i;
                _purchaser.GetComponent<Button>().onClick.AddListener(() => PurchaseItem(_indeX, "theme", _purchaser));
                if (/*List_Of_Themes[i].Purchased == true*/List_Of_Themes[i].UnlockLevel <= Save_Level)
                {
                    _purchaser.transform.GetChild(2).GetComponent<Text>().text = "✓";
                }
            }
        }

        //Create Throwable Options
        for (int i = 0; i < List_Of_Throwables.Count; i++)
        {
            if (List_Of_Throwables[i].Unlisted == false)
            {
                GameObject _purchaser = Instantiate(PurchasePrefab, transform.position, transform.rotation, ThrowableGrid.transform) as GameObject;
                _purchaser.transform.GetChild(0).GetComponent<Text>().text = List_Of_Throwables[i].Name;
                _purchaser.transform.GetChild(1).GetComponent<Image>().sprite = List_Of_Throwables[i].Icon;
                _purchaser.transform.GetChild(2).GetComponent<Text>().text = "lvl."+List_Of_Throwables[i].UnlockLevel.ToString();
                _purchaser.transform.GetChild(2).GetComponent<Text>().color = LevelColour;
                _purchaser.transform.GetChild(3).GetComponent<Image>().sprite = HighScoreIcon;
                _purchaser.transform.GetChild(3).GetComponent<Image>().color = LevelColour;
                List_Of_Throwables[i].ButtonUI = _purchaser;
                int _indeX = i;
                _purchaser.GetComponent<Button>().onClick.AddListener(() => PurchaseItem(_indeX, "throwable", _purchaser));
                if (/*List_Of_Throwables[i].Purchased == true*/List_Of_Throwables[i].UnlockLevel <= Save_Level)
                {
                    _purchaser.transform.GetChild(2).GetComponent<Text>().text = "✓";
                }
            }
        }

        //Create Item Options
        for (int i = 0; i < List_Of_Items.Count; i++)
        {
            int _index = i;
            GameObject _purchaser = Instantiate(PurchaseItemPrefab, transform.position, transform.rotation, ItemGrid.transform) as GameObject;
            _purchaser.transform.GetChild(1).GetComponent<Text>().text = "+" + List_Of_Items[_index].Award+ " " +List_Of_Items[_index].Name;
            _purchaser.transform.GetChild(2).GetComponent<Image>().sprite = List_Of_Items[_index].Icon;
            _purchaser.transform.GetChild(3).GetComponent<Text>().text = List_Of_Items[_index].Cost.ToString();
            _purchaser.transform.GetChild(4).GetChild(0).GetComponent<Text>().text = "x" + List_Of_Items[_index].Quantity;
            
            _purchaser.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(() => PurchaseItem(_index, List_Of_Items[_index].Tag, _purchaser));
            _purchaser.transform.GetChild(4).GetComponent<Button>().onClick.AddListener(() => EquipItem(_index));
        }

        //Create MT Options
        CurrencyGrid.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = "+" + Award_Ad_Currency + " gold";

        //Adjust Additional UI
        //PlayMenu.transform.GetChild(7).GetComponent<Text>().text = DiamondKeysRequired+" keys required";

        UpdatePurchaseUI();

    }

    public void ModifyScoreSpacer(int _value)
    {
        ScoreSpacer.GetComponent<LayoutElement>().minHeight = _value;

    }

    public void UseSimpleLighting(bool _on)
    {
        CreateFalseLight = _on;
    }

    public void CreateMenuThemeList()
    {
        for (int i = 0; i < List_Of_MenuColourThemes.Count; i++)
        {
            GameObject _colour = Instantiate(PurchasePrefab, transform.position, transform.rotation, Settings_MenuThemeGrid.transform) as GameObject;
            _colour.transform.GetChild(0).GetComponent<Text>().text = List_Of_MenuColourThemes[i].Name;
            _colour.transform.GetChild(1).GetComponent<Image>().sprite = List_Of_MenuColourThemes[i].Icon;
            _colour.transform.GetChild(1).GetComponent<Image>().color = List_Of_MenuColourThemes[i].Colour;
            _colour.transform.GetComponent<Outline>().enabled = false;
            _colour.GetComponent<Image>().color = MenuThemeColour;
            _colour.transform.GetChild(2).gameObject.SetActive(false);
            _colour.transform.GetChild(3).gameObject.SetActive(false);
            int index = i;
            _colour.GetComponent<Button>().onClick.AddListener(() => UpdateMainMenuColourTheme(List_Of_MenuColourThemes[index].Colour,index));

        }

        UpdateMainMenuColourTheme(List_Of_MenuColourThemes[Save_MenuTheme].Colour, Save_MenuTheme);
    }

    public void CreateHelpMenu()
    {
        for (int i = 0; i < List_Of_Hints.Count; i++)
        {
            GameObject _hint = Instantiate(HelpUIPrefab, transform.position, transform.rotation, HelpGrid.transform) as GameObject;
            _hint.transform.GetChild(0).GetComponent<Text>().text = List_Of_Hints[i].Title+":\n"+ List_Of_Hints[i].Description;
            _hint.transform.GetChild(1).GetComponent<Image>().sprite = List_Of_Hints[i].Icon;
            if (List_Of_Hints[i].UseColour == true)
            {
                _hint.transform.GetChild(1).GetComponent<Image>().color = List_Of_Hints[i].IconColour;
            }
        }
    }

    public void EquipItem(int _item)
    {
        if(Save_LeftItem != _item && Save_RightItem != _item)
        {
            if(Save_AllocateItemToLeft == true)
            {
                Save_LeftItem = _item;
                LeftCounterUI.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(() => Use_Item(Save_LeftItem));
                LeftCounterUI.transform.GetChild(0).GetComponent<Image>().sprite = List_Of_Items[Save_LeftItem].Icon;
                Save_AllocateItemToLeft = false;
            }
            else if (Save_AllocateItemToLeft == false)
            {
                Save_RightItem = _item;
                RightCounterUI.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(() => Use_Item(Save_RightItem));
                RightCounterUI.transform.GetChild(1).GetComponent<Image>().sprite = List_Of_Items[Save_RightItem].Icon;
                Save_AllocateItemToLeft = true;
            }
            UpdateMainItemsUI();
            PlayUIButtonSound(Audio_Equip);
        }
    }

    public void LoadEquippedItems()
    {
        LeftCounterUI.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(() => Use_Item(Save_LeftItem));
        LeftCounterUI.transform.GetChild(0).GetComponent<Image>().sprite = List_Of_Items[Save_LeftItem].Icon;
        RightCounterUI.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(() => Use_Item(Save_RightItem));
        RightCounterUI.transform.GetChild(1).GetComponent<Image>().sprite = List_Of_Items[Save_RightItem].Icon;
    }

    public void PurchaseItem(int _index, string _type, GameObject _button)
    {

        if(_type == "throwable")
        {
            if(/*List_Of_Throwables[_index].Purchased == true*/List_Of_Throwables[_index].UnlockLevel <= Save_Level)
            {
                Save_Throwable = _index;
                _button.transform.GetChild(2).GetComponent<Text>().text = "✓";
                PlayUIButtonSound(Audio_Equip);
                //UpdatePurchaseUI();
            }
            //else if (List_Of_Throwables[_index].Cost <= Save_Currency)
            //{
            //    Save_Throwable = _index;
            //    List_Of_Throwables[_index].Purchased = true;
            //    Save_Currency -= List_Of_Throwables[_index].Cost;
            //    _button.transform.GetChild(2).GetComponent<Text>().text = "✓";
            //    PlayUIButtonSound(Audio_Purchase);
            //    //UpdatePurchaseUI();
            //}
            else
            {
                PlayUIButtonSound(Audio_Denied);
            }


        }
        else if (_type == "theme")
        {
            if (/*List_Of_Themes[_index].Purchased == true*/ List_Of_Themes[_index].UnlockLevel <= Save_Level)
            {
                LoadTheme(_index,Save_ThemeActive);
                Save_ThemeActive = _index;
                _button.transform.GetChild(2).GetComponent<Text>().text = "✓";
                PlayUIButtonSound(Audio_Equip);
                //UpdatePurchaseUI();
            }
            //else if (List_Of_Themes[_index].Cost <= Save_Currency || )
            //{
                
            //    List_Of_Themes[_index].Purchased = true;
            //    Save_Currency -= List_Of_Themes[_index].Cost;
            //    LoadTheme(_index,Save_ThemeActive);
            //    Save_ThemeActive = _index;
            //    _button.transform.GetChild(2).GetComponent<Text>().text = "✓";
            //    PlayUIButtonSound(Audio_Purchase);
            //    //UpdatePurchaseUI();
            //}
            else
            {
                PlayUIButtonSound(Audio_Denied);
            }

            if (List_Of_Themes[Save_ThemeActive].HardSurface == true)
            {
                Sound_HitSurface.GetComponent<AudioSource>().clip = List_Of_Throwables[Save_Throwable].HardSound;
            }
            else
            {
                Sound_HitSurface.GetComponent<AudioSource>().clip = List_Of_Throwables[Save_Throwable].SoftSound;
            }
        }
        else if (_type == "jar")
        {
            if (/*List_Of_Jars[_index].Purchased == true*/ List_Of_Throwables[_index].UnlockLevel <= Save_Level)
            {
                Save_JarPackActive = _index;
                _button.transform.GetChild(2).GetComponent<Text>().text = "✓";
                PlayUIButtonSound(Audio_Equip);
                //UpdatePurchaseUI();
            }
            //else if (List_Of_Throwables[_index].Cost <= Save_Currency)
            //{
            //    Save_JarPackActive = _index;
            //    List_Of_Jars[_index].Purchased = true;
            //    Save_Currency -= List_Of_Jars[_index].Cost;
            //    _button.transform.GetChild(2).GetComponent<Text>().text = "✓";
            //    PlayUIButtonSound(Audio_Purchase);
            //    UpdatePurchaseUI();
            //}
            else
            {
                PlayUIButtonSound(Audio_Denied);
            }
        }
        else if (_type == List_Of_Items[_index].Tag && List_Of_Items[_index].Cost <= Save_Currency)
        {
            List_Of_Items[_index].Quantity++;
            Save_Currency -= List_Of_Items[_index].Cost;
            PlayUIButtonSound(Audio_Purchase);
        }
        else
        {
            PlayUIButtonSound(Audio_Denied);
        }

        UpdatePurchaseUI();
        UpdateMainItemsUI();
        SaveGameData();
    }

    public void UpdateMainItemsUI()
    {
        HomeScreen.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = Save_Currency.ToString();
        HomeScreen.transform.GetChild(3).GetChild(2).GetComponent<Text>().text = List_Of_Items[Save_LeftItem].Quantity.ToString();
        HomeScreen.transform.GetChild(3).GetChild(3).GetComponent<Image>().sprite = List_Of_Items[Save_LeftItem].Icon;
        HomeScreen.transform.GetChild(3).GetChild(4).GetComponent<Text>().text = List_Of_Items[Save_RightItem].Quantity.ToString();
        HomeScreen.transform.GetChild(3).GetChild(5).GetComponent<Image>().sprite = List_Of_Items[Save_RightItem].Icon;
        HomeScreen.transform.GetChild(3).GetChild(6).GetComponent<Text>().text = Save_DiamondKeys.ToString();

        for (int i = 0; i < ItemGrid.transform.childCount; i++)
        {
            ItemGrid.transform.GetChild(i).transform.GetChild(4).GetChild(0).GetComponent<Text>().text = "x" + List_Of_Items[i].Quantity;
            if(i == Save_LeftItem || i == Save_RightItem)
            {
                ItemGrid.transform.GetChild(i).transform.GetChild(4).GetComponent<Image>().color = PurchaseColour;
            }
            else
            {
                ItemGrid.transform.GetChild(i).transform.GetChild(4).GetComponent<Image>().color = MenuThemeColour;
            }
        }
    }

    public void UpdatePurchaseUI()
    {

        for (int i = 0; i < ThrowableGrid.transform.childCount; i++)
        {
            ThrowableGrid.transform.GetChild(i).GetComponent<Image>().color = MenuThemeColour;
        }
        if (List_Of_Throwables[Save_Throwable].Unlisted == false)
        {
            List_Of_Throwables[Save_Throwable].ButtonUI.GetComponent<Image>().color = PurchaseColour;
        }

        for (int i = 0; i < ThemeGrid.transform.childCount; i++)
        {
            ThemeGrid.transform.GetChild(i).GetComponent<Image>().color = MenuThemeColour;
        }
        if (List_Of_Themes[Save_ThemeActive].Unlisted == false)
        {
            List_Of_Themes[Save_ThemeActive].ButtonUI.GetComponent<Image>().color = PurchaseColour;
        }

        for (int i = 0; i < JarGrid.transform.childCount; i++)
        {
            JarGrid.transform.GetChild(i).GetComponent<Image>().color = MenuThemeColour;
        }
        if (List_Of_Jars[Save_JarPackActive].Unlisted == false)
        {
            List_Of_Jars[Save_JarPackActive].ButtonUI.GetComponent<Image>().color = PurchaseColour;
        }

        for (int i = 0; i < ItemGrid.transform.childCount; i++)
        {
            ItemGrid.transform.GetChild(i).GetComponent<Image>().color = MenuThemeColour;
        }

    }

    public void NewGame(int _gameModeID)
    {
        print(_gameModeID);
        bool _start = false;
        int _amountOfDots = 0;
        Save_GameModeActive = _gameModeID;
        ActivateBalloonOnce = false;
        GameMode = List_Of_GameModes[Save_GameModeActive].Name;
        Quantity = List_Of_GameModes[Save_GameModeActive].StartQuantity;
        ComboAward = List_Of_GameModes[Save_GameModeActive].ComboAward;
        ComboCap = List_Of_GameModes[Save_GameModeActive].ComboRequired;
        
        GoldPercent = List_Of_GameModes[Save_GameModeActive].GoldPercent;
        _start = true;

        if (List_Of_GameModes[Save_GameModeActive].Name == "diamond room" && Save_DiamondKeys < DiamondKeysRequired)
        {
            _start = false;
        }

        if (List_Of_GameModes[Save_GameModeActive].Name == "escalation")
        {
            int _newComboCap = Mathf.CeilToInt(Save_Level / List_Of_GameModes[Save_GameModeActive].EscalationAmount);
            ComboCap = List_Of_GameModes[Save_GameModeActive].ComboRequired + _newComboCap;
            if(ComboCap > List_Of_GameModes[Save_GameModeActive].EscalationCap)
            {
                ComboCap = List_Of_GameModes[Save_GameModeActive].EscalationCap;
            }
        }

        if(List_Of_GameModes[Save_GameModeActive].Name == "dash")
        {
            DD_GroupScore = 0;
            DashBar.gameObject.SetActive(true);
            

            if (ComboCounter.transform.childCount > 0)
            {
                foreach (Transform child in ComboCounter.transform)
                {
                    Destroy(child.gameObject);
                }
            }

            int _rand = Random.Range(0, List_Of_Dogs.Count);
            int _rand2 = Random.Range(1, DD_GroupCap + 1);
            DD_TargetScore = _rand2;
            DD_TimeCap = _rand2 * DD_TimeAdded;
            DD_Counter = DD_TimeCap;
            DashBar.GetComponent<Slider>().maxValue = DD_TimeCap;
            DashCounter = true;
            _amountOfDots = _rand2;
        }
        else
        {
            DashBar.gameObject.SetActive(false);
            _amountOfDots = ComboCap;
        }

        LeftCounterUI.SetActive(List_Of_GameModes[Save_GameModeActive].UseItem);
        RightCounterUI.SetActive(List_Of_GameModes[Save_GameModeActive].UseItem);

        //if(List_Of_Themes[Save_ThemeActive].UseGallery == true)
        //{
        //    Canvas_GalleryImage.SetActive(true);
        //    int _rand3 = Random.Range(0, List_Of_Themes[Save_ThemeActive].GalleryImages.Length);
        //    Canvas_GalleryImage.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = List_Of_Themes[Save_ThemeActive].GalleryImages[_rand3];
        //    Canvas_GalleryImage.transform.GetChild(0).GetChild(2).GetComponent<Text>().text = List_Of_Themes[Save_ThemeActive].GalleryNames[_rand3];
        //}
        //else
        //{
        //    Canvas_GalleryImage.SetActive(false);
        //}



        //Reset Jar positioning to Simple for first jar
        JarSpawn.transform.position = new Vector3(Random.Range(-JarSpawnRangeX, JarSpawnRangeX), JarSpawn.transform.position.y, JarSpawnZDefault);

        if (_start == true)
        {
            WithinMenus = false;
            MUSICMANAGER.transform.GetChild(0).GetComponent<AudioSource>().clip = List_Of_Themes[Save_ThemeActive].ThemeMusic;
            if (Save_Mute == false)
            {
                MUSICMANAGER.transform.GetChild(0).GetComponent<AudioSource>().Play();
            }


            if (List_Of_GameModes[Save_GameModeActive].UseSpecificJar == true)
            {
                if (List_Of_Jars[List_Of_GameModes[Save_GameModeActive].JarID].Unlisted == false)
                {
                    PreviousJarID = Save_JarPackActive;
                }
                Save_JarPackActive = List_Of_GameModes[Save_GameModeActive].JarID;
            }
            if (List_Of_GameModes[Save_GameModeActive].UseSpecificTheme == true)
            {
                LoadTheme(List_Of_GameModes[Save_GameModeActive].ThemeID, Save_ThemeActive);
                PreviousThemeID = Save_ThemeActive;
            }
            if (List_Of_GameModes[Save_GameModeActive].UseSpecificThrowable == true)
            {
                if (List_Of_Throwables[List_Of_GameModes[Save_GameModeActive].ThrowableID].Unlisted == false)
                {
                    PreviousThrowableID = Save_Throwable;
                }
                Save_Throwable = List_Of_GameModes[Save_GameModeActive].ThrowableID;
            }


            PlayUIButtonSound(Audio_Proceed);
            Score = 0;
            Level_LevelsGainedinMatch = 0;
            NextThrowable();
            GameOverScreen.SetActive(false);
            HomeScreen.SetActive(false);
            ToggleAllAudio(true);
            GameOverScreen.transform.GetChild(2).GetChild(0).GetComponent<Text>().text = "retry";
            GameOverScreen.transform.GetChild(2).GetComponent<Button>().interactable = true;
            GameOverScreen.transform.GetChild(2).GetChild(0).GetComponent<Text>().color = BackColour;

            
            ResetCoinRequiredCounter();
            CreateComboDots(_amountOfDots);
            NextThrowable();
            Choose_New_Jar();
            UpdateUI();
        }
        else
        {
            PlayUIButtonSound(Audio_Denied);
        }

    }

    public void GameOver()
    {
        WithinMenus = true;
        MUSICMANAGER.transform.GetChild(0).GetComponent<AudioSource>().clip = Audio_MenuMusic;
        MUSICMANAGER.transform.GetChild(0).GetComponent<AudioSource>().pitch = MusicPitchChangeHigh;
        if (Save_Mute == false)
        {
            MUSICMANAGER.transform.GetChild(0).GetComponent<AudioSource>().Play();
        }

        GameOverScreen.SetActive(true);
        DashCounter = false;
        if(GameMode == "diamond room")
        {
            GameOverScreen.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Text>().text = "levels earned";
            GameOverScreen.transform.GetChild(1).GetChild(1).GetChild(0).GetComponent<Text>().color = LevelColour;
            GameOverScreen.transform.GetChild(1).GetChild(1).GetChild(0).GetComponent<Text>().text ="+"+Score.ToString();
        }
        else if(GameMode == "escalation")
        {
            GameOverScreen.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Text>().text = "level reached";
            GameOverScreen.transform.GetChild(1).GetChild(1).GetChild(0).GetComponent<Text>().color = LevelColour;
            GameOverScreen.transform.GetChild(1).GetChild(1).GetChild(0).GetComponent<Text>().text = "level " + Save_Level +"\n(+"+ Level_LevelsGainedinMatch + ")";
        }
        else
        {
            GameOverScreen.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Text>().text = "jars smashed";
            GameOverScreen.transform.GetChild(1).GetChild(1).GetChild(0).GetComponent<Text>().color = StandardGreyTextColour;
            GameOverScreen.transform.GetChild(1).GetChild(1).GetChild(0).GetComponent<Text>().text = Score.ToString();
        }

        if (GameMode == "dash")
        {
            GameOverScreen.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Text>().text = "groups smashed";
            GameOverScreen.transform.GetChild(1).GetChild(1).GetChild(0).GetComponent<Text>().color = LevelColour;
            GameOverScreen.transform.GetChild(1).GetChild(1).GetChild(0).GetComponent<Text>().text = DD_GroupScore.ToString();
            Score = DD_GroupScore;
        }

        Save_JarsSmashedSmall += JarsSmashedSmall;
        Save_JarsSmashedMedium += JarsSmashedMedium;
        Save_JarsSmashedLarge += JarsSmashedLarge;
        Save_ObjectsThrown += ObjectsThrown;
        int _totaljars = JarsSmashedLarge + JarsSmashedMedium + JarsSmashedSmall;


        //List_Of_Jars[Save_JarPackActive].ObjectsSmashed += _totaljars;
        //List_Of_Throwables[Save_Throwable].ObjectsThrown += ObjectsThrown;
        //List_Of_Throwables[Save_Throwable].ObjectsHit += _totaljars;
        
        if(Score > List_Of_GameModes[Save_GameModeActive].Score)
        {
            if(AdvancedThrowing == false)
            {
                List_Of_GameModes[Save_GameModeActive].Score = Score;
            }
            else
            {
                List_Of_GameModes[Save_GameModeActive].AdvancedScore = Score;
            }
        }

        if (GameMode == "classic")
        {
            if (Score > List_Of_Jars[Save_JarPackActive].HighScore)
            {
                List_Of_Jars[Save_JarPackActive].HighScore = Score;
            }
            if (Score > List_Of_Throwables[Save_Throwable].HighScore)
            {
                List_Of_Throwables[Save_Throwable].HighScore = Score;
            }
        }
        else if (GameMode == "hardcore")
        {
            if (Score > List_Of_Jars[Save_JarPackActive].HardcoreScore)
            {
                List_Of_Jars[Save_JarPackActive].HardcoreScore = Score;
            }
            if (Score > List_Of_Throwables[Save_Throwable].HardcoreScore)
            {
                List_Of_Throwables[Save_Throwable].HardcoreScore = Score;
            }
        }

        else if (GameMode == "diamond room")
        {

            Save_Level += Score;
            Save_DiamondKeys -= DiamondKeysRequired;
            GameOverScreen.transform.GetChild(2).GetChild(0).GetComponent<Text>().color = DiamondKeyColor;

            if (DiamondKeysRequired > Save_DiamondKeys)
            {
                GameOverScreen.transform.GetChild(2).GetChild(0).GetComponent<Text>().text = "retry\n(" + Save_DiamondKeys + "/" + DiamondKeysRequired + " keys)";
                GameOverScreen.transform.GetChild(2).GetComponent<Button>().interactable = false;
            }
            else
            {
                GameOverScreen.transform.GetChild(2).GetChild(0).GetComponent<Text>().text = "retry\n(" + Save_DiamondKeys + "/" + DiamondKeysRequired + " keys)";
                GameOverScreen.transform.GetChild(2).GetComponent<Button>().interactable = true;
            }

            LoadTheme(PreviousThemeID, DiamondRoomThemeID);
            Save_Throwable = PreviousThrowableID;
            Save_JarPackActive = PreviousJarID;
        }


        UpdateMainItemsUI();
        UpdateChallengesUI();
        if (LoadedThrowable != null)
        {
            Destroy(LoadedThrowable);
        }
        ThrowableLoaded = false;
        Destroy(CurrentJar);
        UpdateMainMenuUI();
        SaveGameData();
        DeactivateBalloonBonus();
    }

    public void UpdateMainMenuUI()
    {
        MM_EscalationScore.transform.GetChild(0).GetComponent<Text>().text = "escalation score: " + List_Of_GameModes[0].Score;
        MM_ClassicScore.transform.GetChild(0).GetComponent<Text>().text = "classic score: " + List_Of_GameModes[4].Score;
        MM_Level.transform.GetChild(1).GetComponent<Text>().text = "level " + Save_Level;

        //int _closestTheme;
        //int _closestThrowable;
        //int _closestJar;

        //for (int i = 0; i < List_Of_Jars.Count; i++)
        //{
        //    if(List_Of_Jars[i].UnlockLevel > Save_Level && (List_Of_Jars[i].UnlockLevel - Save_Level) < _closestJar)
        //}

        //MM_Level.transform.GetChild(0).GetComponent<Slider>().value = List_Of_GameModes[4].EscalationAmount;
        //MM_Level.transform.GetChild(0).GetComponent<Slider>().maxValue = List_Of_GameModes[4].com;



    }

    public void UpdateMainMenuColourTheme(Color _chosenColour, int _chosenMenuThemeID)
    {
        MenuThemeColour = _chosenColour;
        Save_MenuTheme = _chosenMenuThemeID;
        for (int ib = 0; ib < MenuThemeElements.Length; ib++)
        {
            MenuThemeElements[ib].GetComponent<Image>().color = MenuThemeColour;
        }

        for (int ib = 0; ib < Settings_MenuThemeGrid.transform.childCount; ib++)
        {
            Settings_MenuThemeGrid.transform.GetChild(ib).GetComponent<Image>().color = MenuThemeColour;
        }
        PlayUIButtonSound(Audio_Equip);
        UpdatePurchaseUI();
    }

    public void CreateComboDots(int _amount)
    {
        if (ComboCounter.transform.childCount > 0)
        {
            foreach (Transform child in ComboCounter.transform)
            {
                Destroy(child.gameObject);
            }
        }

        for (int i = 0; i < _amount; i++)
        {
            GameObject _comboDots = Instantiate(ComboDotPrefab, transform.position, transform.rotation, ComboCounter.transform) as GameObject;
            if(i<ComboCountIndex)
            {
                _comboDots.GetComponent<Image>().color = Color.yellow;
            }
        }


    }

    public void ColourComboDots()
    {
        for (int i = 0; i < ComboCountIndex+1; i++)
        {
            print("colour dot " + i);
            ComboCounter.transform.GetChild(i).GetComponent<Image>().color = Color.yellow;
        }
    }

    public void CloseUIMenus()
    {
        for (int i = 0; i < MenuContainer.transform.childCount; i++)
        {
            MenuContainer.transform.GetChild(i).gameObject.SetActive(false);
        }
    }

    public void OpenMenuUI(GameObject _menu)
    {
        ToggleAllAudio(true);
        CloseUIMenus();
        HomeScreen.SetActive(true);
        _menu.SetActive(true);
        GameOverScreen.SetActive(false);
        MenuContainer.GetComponent<ScrollRect>().content = _menu.GetComponent<RectTransform>();
        MenuContainer.GetComponent<ScrollRect>().normalizedPosition = new Vector2(0, 1);
        //_menu.GetComponent<RectTransform>().pivot = new Vector2(_menu.GetComponent<RectTransform>().pivot.x, 1);

        if (_menu != MainMenu)
        {
            MainMenuButton.SetActive(true);
            MenuContainer.GetComponent<ScrollRect>().enabled = true;
        }
        else
        {
            MainMenuButton.SetActive(false);
            MenuContainer.GetComponent<ScrollRect>().enabled = false;
        }
    }

    public void LoadTheme (int _theme, int _previousTheme)
    {
        _CurrentlyActiveTheme = _theme;
        FloorPiece.GetComponent<MeshRenderer>().material = List_Of_Themes[_theme].Floor;
        WallPiece.GetComponent<MeshRenderer>().material = List_Of_Themes[_theme].Backdrop;

        DirectionalLight.GetComponent<Light>().color = List_Of_Themes[_theme].DirectionalLightColour;
        DirectionalLight.GetComponent<Light>().intensity = List_Of_Themes[_theme].DirectionalLightIntensity;

        if (List_Of_Themes[_theme].ThemeObjects.Length > 0)
        {
            for (int i = 0; i < List_Of_Themes[_theme].ThemeObjects.Length; i++)
            {
                List_Of_Themes[_theme].ThemeObjects[i].SetActive(true);
            }
        }

        if (List_Of_Themes[_previousTheme].ThemeObjects.Length > 0)
        {
            for (int i = 0; i < List_Of_Themes[_previousTheme].ThemeObjects.Length; i++)
            {
                List_Of_Themes[_previousTheme].ThemeObjects[i].SetActive(false);
            }
        }

        if (List_Of_Themes[_theme].UseGallery == true)
        {
            Canvas_GalleryImage.SetActive(true);
            int _rand3 = Random.Range(0, List_Of_Themes[_theme].GalleryImages.Length);
            Canvas_GalleryImage.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = List_Of_Themes[_theme].GalleryImages[_rand3];
            Canvas_GalleryImage.transform.GetChild(0).GetChild(2).GetComponent<Text>().text = List_Of_Themes[_theme].GalleryNames[_rand3];
        }
        else
        {
            Canvas_GalleryImage.SetActive(false);
        }

        if (WithinMenus == false)
        {
            MUSICMANAGER.transform.GetChild(0).GetComponent<AudioSource>().clip = List_Of_Themes[_theme].ThemeMusic;
            if (Save_Mute == false)
            {
                MUSICMANAGER.transform.GetChild(0).GetComponent<AudioSource>().Play();
            }
        }
    }


    public void AdjustVolume()
    {
        for (int i = 0; i < SOUNDMANAGER.transform.childCount; i++)
        {
            SOUNDMANAGER.transform.GetChild(i).GetComponent<AudioSource>().volume = Volume;
        }
    }


    public void Use_Item(int _index)
    {
        if (List_Of_Items[_index].Quantity > 0) 
        {
            if (ThrowableLoaded == true && UsingSpecialThrowable == false && List_Of_Items[_index].Tag == "hammer")
            {
                Sound_UseItem.GetComponent<AudioSource>().Play();
                Destroy(LoadedThrowable);
                GameObject _spawnedItem = Instantiate(HammerThrowablePrefab, ThrowableSpawn.transform.position, transform.rotation) as GameObject;
                _spawnedItem.GetComponent<S_Flick>().ParentManager = gameObject;
                List_Of_Items[_index].Quantity--;
                List_Of_Items[_index].Uses++;
                Save_ItemsUsed++;
                UpdateUI();
                UsingSpecialThrowable = true;
                UpdateMainItemsUI();
                CreateSpawnable = false;
            }
            else if (FreezeJar == false && List_Of_Items[_index].Tag == "ice") 
            {
                Sound_UseItem.GetComponent<AudioSource>().Play();
                List_Of_Items[_index].Quantity--;
                List_Of_Items[_index].Uses++;
                Save_ItemsUsed++;
                FreezeCounter = FreezeCounterMax;
                FreezeJar = true;
                UpdateUI();
                UpdateMainItemsUI();
                CreateSpawnable = false;
            }
            else if (GoldBonus == false && List_Of_Items[_index].Tag == "gold") 
            {
                Sound_UseItem.GetComponent<AudioSource>().Play();
                List_Of_Items[_index].Quantity--;
                List_Of_Items[_index].Uses++;
                Save_ItemsUsed++;
                ActivateGoldBonus();
                UpdateUI();
                UpdateMainItemsUI();
                CreateSpawnable = false;
            }
            else if (ThrowableLoaded == true && UsingSpecialThrowable == false && List_Of_Items[_index].Tag == "firework")
            {
                Sound_UseItem.GetComponent<AudioSource>().Play();
                Destroy(LoadedThrowable);
                GameObject _spawnedItem = Instantiate(MatchThrowablePrefab, ThrowableSpawn.transform.position, transform.rotation) as GameObject;
                _spawnedItem.GetComponent<S_Flick>().ParentManager = gameObject;
                GameObject _spawnedItem2 = Instantiate(FireworkSpawnablePrefab, CurrentJar.transform.GetChild(0).position, transform.rotation) as GameObject;
                _spawnedItem2.transform.SetParent(CurrentJar.transform.GetChild(0));
                List_Of_Items[_index].Quantity--;
                List_Of_Items[_index].Uses++;
                Save_ItemsUsed++;
                UpdateUI();
                UsingSpecialThrowable = true;
                UpdateMainItemsUI();
                CreateSpawnable = true;
                _AllocatedSpawnable = FireworkSpawnablePrefab;
            }
        }
    }



    public void Choose_New_Jar()
    {

        SelectedJar = Random.Range(0, List_Of_Jars[Save_JarPackActive].JarObjects.Count);
        GameObject _spawnedJar = Instantiate(List_Of_Jars[Save_JarPackActive].JarObjects[SelectedJar].JarObject, JarSpawn.transform.position, List_Of_Jars[Save_JarPackActive].JarObjects[SelectedJar].JarObject.transform.rotation) as GameObject;
        CurrentJarSize = List_Of_Jars[Save_JarPackActive].JarObjects[SelectedJar].JarSize;
        Sound_HitJar.GetComponent<AudioSource>().clip = List_Of_Jars[Save_JarPackActive].JarObjects[SelectedJar].JarHitSound;
        Sound_SmashJar.GetComponent<AudioSource>().clip = List_Of_Jars[Save_JarPackActive].JarObjects[SelectedJar].JarSmashSound;

        print("Use Supplied Colour");
        int _temp = Random.Range(0, List_Of_Jars[Save_JarPackActive].JarObjects[SelectedJar].SuppliedColours.Length);
        _spawnedJar.transform.GetChild(0).GetComponent<Light>().color = List_Of_Jars[Save_JarPackActive].JarObjects[SelectedJar].SuppliedColours[_temp].color;
        CurrentlySelectedJarColour = List_Of_Jars[Save_JarPackActive].JarObjects[SelectedJar].SuppliedColours[_temp];

        if(List_Of_Jars[Save_JarPackActive].JarObjects[SelectedJar].UseLight == true)
        {
            if (CreateFalseLight == true)
            {
                _spawnedJar.transform.GetChild(0).GetComponent<Light>().enabled = false;
                GameObject _spawnedFakeLight = Instantiate(FakeUILight, _spawnedJar.transform.GetChild(1).GetChild(0).position, _spawnedJar.transform.GetChild(1).GetChild(0).rotation, _spawnedJar.transform.GetChild(1)) as GameObject;
                _spawnedFakeLight.GetComponent<Image>().color = List_Of_Jars[Save_JarPackActive].JarObjects[SelectedJar].SuppliedColours[_temp].color;
                _spawnedFakeLight.GetComponent<Image>().color = new Color(_spawnedFakeLight.GetComponent<Image>().color.r, _spawnedFakeLight.GetComponent<Image>().color.g, _spawnedFakeLight.GetComponent<Image>().color.b, 255);
            }
            else
            {
                _spawnedJar.transform.GetChild(0).GetComponent<Light>().enabled = true;
            }
        }

        foreach (Transform child in _spawnedJar.transform)
        {
                
            if (child.tag == "Gold")
            {
                print("Applied Gold Mat");
                child.GetComponent<MeshRenderer>().material = List_Of_Jars[Save_JarPackActive].JarObjects[SelectedJar].SuppliedColours[_temp];
            }

            if (child.childCount > 0)
            {
                foreach (Transform child2 in child)
                {
                    if (child2.tag == "Gold")
                    {
                        child2.GetComponent<MeshRenderer>().material = List_Of_Jars[Save_JarPackActive].JarObjects[SelectedJar].SuppliedColours[_temp];
                    }
                }
            }
        }

        CurrentJar = _spawnedJar;

        int playAnim = Random.Range(1, 101);
        if (playAnim <= ActivateAnimationPercent)
        {
            CurrentJar.GetComponent<Animator>().Play("Jar Slide",-1, Random.Range(0.0f, 1.0f));
            Music_GentleGuitarLoop.GetComponent<AudioSource>().pitch = MusicPitchChangeHigh;
        }
        else
        {
            
            
            CurrentJar.GetComponent<Animator>().enabled = false;

            if(AdvancedThrowing == true)
            {
                print("Advanced Throw Jar Positioning");
                float[] _zpos = new float[] { JarSpawnZDefault, JarSpawnZDefault + JarSpawnRangeY, JarSpawnZDefault-JarSpawnRangeY*2 };
                int _index = Random.Range(0, _zpos.Length);
                if (_index != 2)
                {
                    JarSpawn.transform.position = new Vector3(Random.Range(-JarSpawnRangeX, JarSpawnRangeX), JarSpawn.transform.position.y, _zpos[_index]); //zpos
                }
                else
                {
                    JarSpawn.transform.position = new Vector3(Random.Range(-JarSpawnRangeX/2, JarSpawnRangeX/2), JarSpawn.transform.position.y, _zpos[_index]); //zpos
                }
            }
            else
            {
                print("Simple Throw Jar Positioning");
                JarSpawn.transform.position = new Vector3(Random.Range(-JarSpawnRangeX, JarSpawnRangeX), JarSpawn.transform.position.y, JarSpawnZDefault);
            }
            
            Music_GentleGuitarLoop.GetComponent<AudioSource>().pitch = MusicPitchChangeLow;
        }


        if (GameMode != "diamond room")
        {
            int _chance = Random.Range(1, 101);
            print("CHANCE: " + _chance);
            if (_chance <= GoldPercent && UltraGoldBonus == false)
            {
                ActivateGoldBonus();
            }
            else
            {
                GoldBonus = false;
            }

            if (_chance <= List_Of_GameModes[Save_GameModeActive].BalloonPercent && BalloonBonus == false && ActivateBalloonOnce == false)
            {
                ActivateBalloonBonus();
            }
        }

        
    }

    public void ActivateGoldBonus()
    {
        GoldBonus = true;
        CurrentlySelectedJarColour = List_Of_Jars[Save_JarPackActive].JarObjects[SelectedJar].GoldMaterial;

        if (List_Of_Jars[Save_JarPackActive].JarObjects[SelectedJar].UseLight == true)
        {
            if (CreateFalseLight == true)
            {
                CurrentJar.transform.GetChild(1).GetChild(1).GetComponent<Image>().color = GoldCurrencyColour;
            }
        }

        foreach (Transform child in CurrentJar.transform)
        {
            if (child.tag == "Gold")
            {
                child.GetComponent<MeshRenderer>().material = List_Of_Jars[Save_JarPackActive].JarObjects[SelectedJar].GoldMaterial;
            }

            if (child.childCount > 0)
            {
                foreach (Transform child2 in child)
                {
                    if (child2.tag == "Gold")
                    {
                        child2.GetComponent<MeshRenderer>().material = List_Of_Jars[Save_JarPackActive].JarObjects[SelectedJar].GoldMaterial;
                    }
                }
            }
        }

        //Change glow to yellow for gold jars
        if(CurrentJar.transform.GetChild(0).GetComponent<Light>().enabled == true)
        {
            CurrentJar.transform.GetChild(0).GetComponent<Light>().color = Color.yellow;
        }
        print("GOLD BONUS!");
    }

    public void ActivateBalloonBonus()
    {
        BalloonBonus = true;
        ActivateBalloonOnce = true;
        int _rand0 = Random.Range(1, 101);
        GameObject _spawn;
        if (_rand0 < 50)
        {
            _spawn = BalloonSpawnLeft;
        }
        else
        {
            _spawn = BalloonSpawnRight;
        }
        GameObject _spawnedBalloon = Instantiate(BalloonObjectPrefab, _spawn.transform.position, BalloonObjectPrefab.transform.rotation) as GameObject;
        _spawnedBalloon.GetComponent<S_MoveToPoint>().Locations.Add(BalloonSpawnLeft);
        _spawnedBalloon.GetComponent<S_MoveToPoint>().Locations.Add(BalloonSpawnRight);
        CurrentSpawnableObject = _spawnedBalloon;


        if (AdvancedThrowing == false)
        {
            CurrentBalloonType = "GiveThrowables";
            _spawnedBalloon.GetComponent<MeshRenderer>().material = Gold;
            _spawnedBalloon.transform.GetChild(0).GetComponent<MeshRenderer>().material = Gold;
            _spawnedBalloon.transform.GetChild(1).GetComponent<MeshRenderer>().material = Gold;
            _spawnedBalloon.transform.GetChild(2).GetComponent<Light>().color = Color.yellow;
            print("ULTRA GOLD BALLOON BONUS!");
        }
        else
        {
            CurrentBalloonType = "GiveDiamondKeys";
            _spawnedBalloon.GetComponent<MeshRenderer>().material = Diamond;
            _spawnedBalloon.transform.GetChild(0).GetComponent<MeshRenderer>().material = Diamond;
            _spawnedBalloon.transform.GetChild(1).GetComponent<MeshRenderer>().material = Diamond;
            _spawnedBalloon.transform.GetChild(2).GetComponent<Light>().color = Color.cyan;
            print("DIAMOND KEY BALLOON BONUS!");
        }
        
    }

    public void DeactivateBalloonBonus()
    {
        if (BalloonBonus == true)
        {
            BalloonBonus = false;
            Destroy(CurrentSpawnableObject);
        }
    }

    public void StartJarDelaySmash(GameObject _jar)
    {
        StartCoroutine( DelayJarSmash(_jar));
    }

    public IEnumerator DelayJarSmash(GameObject _jar)///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    {
        if(CreateSpawnable == true)
        {
            GameObject _spawnedItem2 = Instantiate(_AllocatedSpawnable, CurrentJar.transform.GetChild(0).position, transform.rotation) as GameObject;
            if(_AllocatedSpawnable == FireworkSpawnablePrefab)
            {
                _spawnedItem2.GetComponent<S_Spawnable>().IgniteFirework();
                Destroy(CurrentJar.transform.GetChild(0).gameObject);
            }
            CreateSpawnable = false;
        }

        yield return new WaitForSeconds(SmashJarDelayCount);
        List_Of_Jars[Save_JarPackActive].ObjectsSmashed ++;
        List_Of_Throwables[Save_Throwable].ObjectsHit ++;
        SmashJar(_jar);

        if (ComboCountIndex == ComboCap  || GoldBonus == true)
        {
            yield return new WaitForSeconds(1);
            if (ComboCountIndex == ComboCap)
            {
                Quantity += ComboAward;
                Sound_GainCoin.GetComponent<AudioSource>().Play();
                ResetCoinRequiredCounter();
                UpdateUI();

                //AwardCombo();
            }
            if (GoldBonus == true && UltraGoldBonus == false)
            {
                Quantity += GoldAward;
                Sound_GainCoin.GetComponent<AudioSource>().Play();
                UpdateUI();
                //AwardCoins(GoldAward);
            }
            else if (UltraGoldBonus == true && GoldBonus == true)
            {
                Quantity += UltraGoldAward;
                Sound_GainCoin.GetComponent<AudioSource>().Play();
                UpdateUI();
                UltraGoldBonus = false;
            }
            //yield return new WaitForSeconds(1);
        }

        if (List_Of_GameModes[Save_GameModeActive].Name == "escalation" && ComboCap < List_Of_GameModes[Save_GameModeActive].EscalationCap && Save_Level % List_Of_GameModes[Save_GameModeActive].EscalationAmount == 0 && Save_Level > 0 && Score == 0)
        {
            print("Escalate!");
            //ComboCap
            ComboCap++;
            CreateComboDots(ComboCap);
        }

        if (List_Of_GameModes[Save_GameModeActive].Name == "dash")
        {
            if(Score == DD_TargetScore)
            {
                //New match
                int _rand2 = Random.Range(1, DD_GroupCap+1);
                DD_TargetScore = _rand2;
                Score = 0;
                DD_TimeCap = _rand2 * DD_TimeAdded;
                DD_Counter = DD_TimeCap;
                DD_GroupScore++;
                DashBar.GetComponent<Slider>().maxValue = DD_TimeCap;
                Quantity = List_Of_GameModes[Save_GameModeActive].StartQuantity;
                print("New Dash Required: " + DD_TargetScore);
                ComboCountIndex = 0;
                CreateComboDots(_rand2);
                UpdateUI();
            }

        }

        List<int> _tempjars = new List<int>();
        List<int> _tempthrowables = new List<int>();
        List<int> _tempTheme = new List<int>();

        bool _randomiseType = false;
        if(List_Of_GameModes[Save_GameModeActive].Name == "escalation")
        {
            //int _level = Save_Level * Level_Multiplier;
            //_level += Level_StartGoal;
            //print("esc level: " + _level);
            //if (Score == _level)
            //{
            //    _randomiseType = true;
            //}

            if (Score == 0)
            {
                _randomiseType = true;
            }
        }
        else
        {
            if(Score % List_Of_GameModes[Save_GameModeActive].RandomiseEveryXLevels == 0 && Score > 0)
            {
                _randomiseType = true;
            }
        }


        if (List_Of_Themes[Save_ThemeActive].UseGallery == true)
        {
            int _rand3 = Random.Range(0, List_Of_Themes[Save_ThemeActive].GalleryImages.Length);
            Canvas_GalleryImage.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = List_Of_Themes[Save_ThemeActive].GalleryImages[_rand3];
            Canvas_GalleryImage.transform.GetChild(0).GetChild(2).GetComponent<Text>().text = List_Of_Themes[Save_ThemeActive].GalleryNames[_rand3];
        }


        if (List_Of_GameModes[Save_GameModeActive].RandomiseJars == true && _randomiseType == true)
        {
            for (int i = 0; i < List_Of_Jars.Count; i++)
            {
                if (List_Of_Jars[i].UnlockLevel <= Save_Level && List_Of_Jars[i].Unlisted == false /*&& i != Save_JarPackActive*/)
                {
                    _tempjars.Add(i);
                }
            }
            Save_JarPackActive = _tempjars[ Random.Range(0, _tempjars.Count)];
        }

        if (List_Of_GameModes[Save_GameModeActive].RandomiseThemes == true && _randomiseType == true)
        {
            for (int i = 0; i < List_Of_Themes.Count; i++)
            {
                if (List_Of_Themes[i].UnlockLevel <= Save_Level && List_Of_Themes[i].Unlisted == false /*&& i != Save_ThemeActive*/)
                {
                    _tempTheme.Add(i);
                }
            }
            int _rand = Random.Range(0, _tempTheme.Count);
            LoadTheme(_tempTheme[_rand], Save_ThemeActive);
            Save_ThemeActive = _tempTheme[_rand];
        }

        if(List_Of_GameModes[Save_GameModeActive].RandomiseThrowables == true && _randomiseType == true)
        {
            for (int i = 0; i < List_Of_Throwables.Count; i++)
            {
                if (List_Of_Throwables[i].UnlockLevel <= Save_Level && List_Of_Throwables[i].Unlisted == false /*&& i != Save_Throwable*/)
                {
                    _tempthrowables.Add(i);
                }
            }
            Save_Throwable = _tempthrowables[ Random.Range(0, _tempthrowables.Count)];
        }

        Choose_New_Jar();
        NextThrowable();
    }


    public void UpdateUI()
    {
        ScoreCounter.GetComponent<Text>().text = Score.ToString();

        if(List_Of_GameModes[Save_GameModeActive].Name == "escalation")
        {
            int _level = Save_Level * Level_Multiplier;
            _level += Level_StartGoal;
            if (Score == _level)
            {
                Score = 0;
                Save_Level++;
                _level = Save_Level * Level_Multiplier;
                _level += Level_StartGoal;
                Level_LevelsGainedinMatch++;
            }
            ScoreCounter.GetComponent<Text>().text = "level "+Save_Level+"\n"+Score+"/"+_level;

        }

        if (List_Of_GameModes[Save_GameModeActive].Name == "dash")
        {
            ScoreCounter.GetComponent<Text>().text = DD_GroupScore.ToString();


        }

        QuantityText.GetComponent<Text>().text = "x" + Quantity.ToString();
        RightCounterUI.transform.GetChild(0).GetComponent<Text>().text = List_Of_Items[Save_RightItem].Quantity.ToString();
        LeftCounterUI.transform.GetChild(1).GetComponent<Text>().text = List_Of_Items[Save_LeftItem].Quantity.ToString();
    }

	public void NextThrowable()
	{
        if (Quantity > 0 && ThrowableLoaded == false)
        {
            ThrowableLoaded = true;
            GameObject _spawnedItem = Instantiate(List_Of_Throwables[Save_Throwable].ThrowableObjects[Random.Range(0, List_Of_Throwables[Save_Throwable].ThrowableObjects.Count)], ThrowableSpawn.transform.position, transform.rotation) as GameObject;
            _spawnedItem.GetComponent<S_Flick>().ParentManager = gameObject;
            LoadedThrowable = _spawnedItem;

            if (List_Of_Themes[_CurrentlyActiveTheme].HardSurface == true)
            {
                Sound_HitSurface.GetComponent<AudioSource>().clip = List_Of_Throwables[Save_Throwable].HardSound;
            }
            else
            {
                Sound_HitSurface.GetComponent<AudioSource>().clip = List_Of_Throwables[Save_Throwable].SoftSound;
            }
        }
        else if(AwardingCoinsProcess == false)
        {
            CheckForGameOver();
            //StartCoroutine(CheckForGameOver());
        }
        
	}

    public void ThrowSound()
    {
        ThrowableLoaded = false;
        Sound_ThrowObject.GetComponent<AudioSource>().Play();
        ObjectsThrown++;
        List_Of_Throwables[Save_Throwable].ObjectsThrown++;
        if (UsingSpecialThrowable == true)
        {
            UsingSpecialThrowable = false;
        }
    }

    public void AwardCombo()
    {
        AwardCoins(ComboAward);
        Sound_ComboComplete.GetComponent<AudioSource>().Play();
        ResetCoinRequiredCounter();
        UpdateUI();
    }

    public void AwardCoins(int _amount)
    {
        bool _extraLife = false;
        if (Quantity <= 0)
        {
            _extraLife = true;
        }
        //yield return new WaitForSeconds(1);
        Quantity += _amount;
        Sound_GainCoin.GetComponent<AudioSource>().Play();
        UpdateUI();
        if(ThrowableLoaded == false && _extraLife == true)
        {
            NextThrowable();
        }
        AwardingCoinsProcess = false;
    }

    public void CheckForGameOver()
    {
        if(Quantity <= 0)
        {
            print("GAME OVER");
            GameOver();
            //GAMEOVER
        }
    }

    public void HitJar()
    {
        Sound_HitJar.GetComponent<AudioSource>().pitch = Random.Range(HitJarPitchLow, HitJarPitchHigh);
        Sound_HitJar.GetComponent<AudioSource>().Play();
    }

    public void HitSurface()
    {
        Sound_HitSurface.GetComponent<AudioSource>().pitch = Random.Range(HitSurfacePitchLow, HitSurfacePitchHigh);
        Sound_HitSurface.GetComponent<AudioSource>().Play();
    }

    public void SmashJar(GameObject _object)
    {
        print("SmashJar");

        Sound_SmashJar.GetComponent<AudioSource>().pitch = Random.Range(SmashJarPitchLow, SmashJarPitchHigh);
        Sound_SmashJar.GetComponent<AudioSource>().Play();
        GameObject _spawnedSmash = Instantiate(JarSmash, _object.transform.position, transform.rotation) as GameObject;
        _spawnedSmash.GetComponent<ParticleSystemRenderer>().material = CurrentlySelectedJarColour;


        if(CurrentJarSize == "small")
        {
            JarsSmashedSmall++;
        }
        else if (CurrentJarSize == "medium")
        {
            JarsSmashedMedium++;
        }
        else if (CurrentJarSize == "large")
        {
            JarsSmashedLarge++;
        }

        Destroy(_object);
        Destroy(_spawnedSmash, 5);
        

    }

    public void PopBalloon(GameObject _balloon)
    {
        GameObject _spawnedSmash = Instantiate(JarSmash, _balloon.transform.position, transform.rotation) as GameObject;
        _spawnedSmash.GetComponent<ParticleSystemRenderer>().material = _balloon.GetComponent<MeshRenderer>().material;
        Sound_PopBalloon.GetComponent<AudioSource>().Play();
        print("POP BALLOON");
        if(CurrentBalloonType == "GiveThrowables")
        {

            ActivateGoldBonus();
            UltraGoldBonus = true;
            DeactivateBalloonBonus();
        }
        else if (CurrentBalloonType == "GiveDiamondKeys")
        {
            DiamondKeysEarned++;
            Save_DiamondKeys++;
        }
        
        Destroy(_balloon);
    }

    public void ResetCoinRequiredCounter()
    {
        ComboCountIndex = 0;
        for (int i = 0; i < ComboCounter.transform.childCount; i++)
        {
            ComboCounter.transform.GetChild(i).GetComponent<Image>().color = Color.white;
        }
        UpdateUI();
    }

    public void DecreaseCoinRequiredCounter()
    {
        if (List_Of_GameModes[Save_GameModeActive].ComboRequired > 0)
        {
            ComboCountIndex--;
            if (ComboCountIndex < 0)
            {
                ComboCountIndex = 0;
            }

            if (ComboCounter.transform.childCount > 0 )
            {
                ComboCounter.transform.GetChild(ComboCountIndex).GetComponent<Image>().color = Color.white;
            }
            UpdateUI();
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    public void QuitMatch()
    {

        GameOver();
    }

}
