// AssetListExamplesComponent.cs
using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace CharacterLODConfig
{
    [ExecuteAlways]
    public class MechaLODGroup : MonoBehaviour
    {
        [TabGroup("LOD0")]
        [HideLabel]
        public LODStruct lod0;

        [TabGroup("LOD1")]
        [HideLabel]
        public LODStruct lod1;

        [TabGroup("LOD2")]
        [HideLabel]
        public LODStruct lod2;

        [TabGroup("LOD3")]
        [HideLabel]
        public LODStruct lod3;

        [TabGroup("LOD4")]
        [HideLabel]
        public LODStruct lod4;

        [HideInInspector]
        public List<LODStruct> LODGroup;

        [FoldoutGroup("Config")]
        [AssetList(AutoPopulate = true, Path = "Art/Characters/Players/GlobalConfig/")]
        public List<ScriptableObject> MechaGlobalConfigs;

        [FoldoutGroup("Config")]
        [ListDrawerSettings(DraggableItems = false)]
        public List<ScriptableObject> MechaFormalConfigs;


        [Button(ButtonSizes.Large), GUIColor(0, 1, 0)]
        [LabelText("获取配置信息")]
        private void GetConfigData()
        {
            if (MechaFormalConfigs.Count > 0 && MechaFormalConfigs.Count > 0)
            {
                string path = AssetDatabase.GetAssetPath(this);
                Object obj = AssetDatabase.LoadAssetAtPath<Object>(path);
                RefreshMechaData.Run(obj);

                lod0 = LODGroup[0];
                lod1 = LODGroup[1];
                lod2 = LODGroup[2];
                lod3 = LODGroup[3];
                lod4 = LODGroup[4];
            }
            else Debug.Log("无FormalConfig");
        }
    }

    [System.Serializable]
    public class LODStruct
    {
        //[HideLabel]
        //public Keys LODLevel;

        [ReadOnly]
        [Indent]
        [LabelText("使用场景")]
        public UsingSceneEnum UsingScene;

        [ReadOnly]
        [Indent]
        [LabelText("动作Rig约束")]
        public Object ActionRigConstraint;

        [ReadOnly]
        [Indent]
        [LabelText("动作IK")]
        public Object actionIK;

        [ReadOnly]
        [Indent]
        [LabelText("特效模")]
        public EffectModelEnum EffectModel;

        [ReadOnly]
        [Indent]
        [LabelText("阴影模")]
        public ShadowModelEnum ShadowModel;

        [ReadOnly]
        [Indent]
        [LabelText("逻辑部件")]
        public LogicPart[] LogicPart;

        [ReadOnly]
        [Indent]
        [LabelText("特效件")]
        public EffectPart[] EffectPart;

        [ReadOnly]
        [Indent]
        [LabelText("灯光贴花层级")]
        public LightDecalLayerEnum LightDecalLayer;
    }

    //button方法
    /*
     * public int i;
        [ReadOnly]
        [Indent]
        [LabelText("使用场景")]
        public UsingSceneEnum UsingScene;

        [ReadOnly]
        [Indent]
        [LabelText("动作Rig约束")]
        public Object ActionRigConstraint;

        [ReadOnly]
        [Indent]
        [LabelText("动作IK")]
        public Object actionIK;

        [ReadOnly]
        [Indent]
        [LabelText("特效模")]
        public EffectModelEnum EffectModel;

        [ReadOnly]
        [Indent]
        [LabelText("阴影模")]
        public ShadowModelEnum ShadowModel;

        [ReadOnly]
        [Indent]
        [LabelText("逻辑部件")]
        public Object LogicPart;

        [ReadOnly]
        [Indent]
        [LabelText("特效件")]
        public Object EffectModule;

        [ReadOnly]
        [Indent]
        [LabelText("灯光贴花层级")]
        public LightDecalLayerEnum LightDecalLayer;



        [ButtonGroup]
        [Button(ButtonSizes.Large)]
        public void Lod0()
        {
            i = 0;
            UsingScene = LODGroup[i].UsingScene;
            ActionRigConstraint = LODGroup[i].ActionRigConstraint;
            actionIK = LODGroup[i].actionIK;
            EffectModel = LODGroup[i].EffectModel;
            ShadowModel = LODGroup[i].ShadowModel;
            LogicPart = LODGroup[i].LogicPart;
            EffectModule = LODGroup[i].EffectModule;
            LightDecalLayer = LODGroup[i].LightDecalLayer;
        }

        [ButtonGroup]
        public void Lod1()
        {
            i = 1;
            UsingScene = LODGroup[i].UsingScene;
            ActionRigConstraint = LODGroup[i].ActionRigConstraint;
            actionIK = LODGroup[i].actionIK;
            EffectModel = LODGroup[i].EffectModel;
            ShadowModel = LODGroup[i].ShadowModel;
            LogicPart = LODGroup[i].LogicPart;
            EffectModule = LODGroup[i].EffectModule;
            LightDecalLayer = LODGroup[i].LightDecalLayer;
        }
        [ButtonGroup]
        public void Lod2()
        {
            i = 2;
            UsingScene = LODGroup[i].UsingScene;
            ActionRigConstraint = LODGroup[i].ActionRigConstraint;
            actionIK = LODGroup[i].actionIK;
            EffectModel = LODGroup[i].EffectModel;
            ShadowModel = LODGroup[i].ShadowModel;
            LogicPart = LODGroup[i].LogicPart;
            EffectModule = LODGroup[i].EffectModule;
            LightDecalLayer = LODGroup[i].LightDecalLayer;
        }
        [GUIColor(1,0,0)]
        [ButtonGroup]
        public void Lod3()
        {
            i = 3;
            UsingScene = LODGroup[i].UsingScene;
            ActionRigConstraint = LODGroup[i].ActionRigConstraint;
            actionIK = LODGroup[i].actionIK;
            EffectModel = LODGroup[i].EffectModel;
            ShadowModel = LODGroup[i].ShadowModel;
            LogicPart = LODGroup[i].LogicPart;
            EffectModule = LODGroup[i].EffectModule;
            LightDecalLayer = LODGroup[i].LightDecalLayer;
        }
        [GUIColor(0,1,0)]
        [ButtonGroup]
        public void Lod4()
        {
            i = 4;
            UsingScene = LODGroup[i].UsingScene;
            ActionRigConstraint = LODGroup[i].ActionRigConstraint;
            actionIK = LODGroup[i].actionIK;
            EffectModel = LODGroup[i].EffectModel;
            ShadowModel = LODGroup[i].ShadowModel;
            LogicPart = LODGroup[i].LogicPart;
            EffectModule = LODGroup[i].EffectModule;
            LightDecalLayer = LODGroup[i].LightDecalLayer;
        }
     */
}


