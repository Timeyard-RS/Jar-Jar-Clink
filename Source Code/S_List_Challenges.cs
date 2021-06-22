using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class S_List_Challenges  {

    public string Name;
    public int JarType;
    public int ThrowableType;
    public string JarSize;
    public int AmountNeeded;
    public int AmountCompleted;
    public int ChallengeValue;

    public S_List_Challenges(int _jartype, int _throwable, int _amountReq, int _amountComp, string _jarsize, string _name, int _value)
    {
        JarType = _jartype;
        ThrowableType = _throwable;
        JarSize = _jarsize;
        AmountNeeded = _amountReq;
        AmountCompleted = _amountComp;
        Name = _name;
        ChallengeValue = _value;
    }

}
