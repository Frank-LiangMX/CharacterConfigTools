// ChangingEditorToolExampleComponent.cs
using Sirenix.OdinInspector;
using UnityEngine;

public class ChangingEditorToolExampleComponent : MonoBehaviour
{
#if UNITY_EDITOR // UnityEditor.Tool is an editor-only type, so this example will not work in a build
    [EnumPaging, OnValueChanged("SetCurrentTool")]
    [InfoBox("Changing this property will change the current selected tool in the Unity editor.")]
    public UnityEditor.Tool sceneTool;
    
    private void SetCurrentTool()
    {
        UnityEditor.Tools.current = this.sceneTool;
    }
#endif
}