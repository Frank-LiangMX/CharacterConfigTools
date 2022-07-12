using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

public class TestOdin: MonoBehaviour
{
    [ListDrawerSettings(OnBeginListElementGUI = "BeginDrawListElement", OnEndListElementGUI = "EndDrawListElement")]
    public SomeStruct[] InjectListElementGUI;
}

[Serializable]
public struct SomeStruct
{
    public string SomeString;
    public int One;
    public int Two;
    public int Three;
}