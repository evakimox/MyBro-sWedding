using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjStates
{
    public enum KeyState
    {
        InRiver,
        InBag
    }

    public enum AppleState
    {
        OnTheTree,
        OnTheGround,
        InBag,
        Peeling,
        InBagPeeled,
        Eaten
    }

    public enum BlackRoseState
    {
        InVase,
        InBag,
        AtSwitch
    }

    public enum CardState
    {
        OnTable,
        InBag,
        MakingAirplane,
        HoldingAirplane,
        Flying,
        Dropped
    }

    public enum TissueState
    {
        OnTable,
        InBag,
        OnDesk
    }

    public enum TableSheetState
    {
        OnTable,
        InBag,
        MakingDress,
        InBagDress,
        Wearing
    }

    // microphone requires only position
    // scissors require only position
    // thread require only position
    // needle requires only position
    // globe requires only position

    public enum EarBudState
    {
        InShelf,
        InBag,
    }

    public enum BasketState
    {
        InHand,
        InHandFilled,
        InBag,
        Used
    }

    public enum DiaryState
    {
        InShelf,
        InBag,
        Unlocked
    }

    public enum ViolinCaseState
    {
        Locked,
        Opened
    }

    public enum ViolinState
    {
        Enclosed,
        Exposed,
        InBag
    }

}
