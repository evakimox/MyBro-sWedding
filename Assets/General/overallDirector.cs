using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObjStates;

// 单例导演类
public class overallDirector : MonoBehaviour
{
    public string _selectedItemName;

    // 用来记录物品状态的参数
    public KeyState keyState;
    public AppleState appleState;
    public Vector2 applePosition;
    public Quaternion appleRotation;
    public BlackRoseState blackRoseState;
    public CardState cardState;
    public TissueState tissueState;
    public TableSheetState tableSheetState;
    public Vector2 micPosition;
    public Vector2 scissorsPosition;
    public Vector2 threadPosition;
    public Vector2 needlePosition;
    public Vector2 globePosition;
    public EarBudState earBudState;
    public BasketState basketState;
    public DiaryState diaryState;
    public string currentPasswordDiary;
    public ViolinCaseState violinCaseState;
    public string currentPasswordViolinCase;
    public ViolinState ViolinState;

    public List<string> _inBagItems;

    public bool bDontDestroyOnLoad = true;

    public static overallDirector Instance;

    private void InitializeInstance()
    {
        if (Instance != null & Instance == this)
            return;

        if (bDontDestroyOnLoad)
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
        else
        {
            Instance = this;
        }
    }

    private void Awake()
    {
        InitializeInstance();
        InitObjectState();
    }

    private void InitObjectState()
    {
        keyState = KeyState.InRiver;
        appleState = AppleState.OnTheTree;
        blackRoseState = BlackRoseState.InVase;
        cardState = CardState.OnTable;
        tissueState = TissueState.OnTable;
        tableSheetState = TableSheetState.OnTable;
        micPosition = new Vector2(6.56f, -1f);
        scissorsPosition = new Vector2(-5.43f, -2.1f);
        threadPosition = new Vector2(10.86f, 3.095f);
        needlePosition = new Vector2(9.305f, -1.414999f);
        globePosition = new Vector2(8.65f, 0.535f);
        earBudState = EarBudState.InShelf;
        basketState = BasketState.InHand;
        diaryState = DiaryState.InShelf;
        violinCaseState = ViolinCaseState.Locked;
        currentPasswordViolinCase = "DAFUQ";
        ViolinState = ViolinState.Enclosed;
        if(_inBagItems == null)
        {
            _inBagItems = new List<string>();
        }
        
    }
}
