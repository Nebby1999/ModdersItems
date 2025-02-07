﻿using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;
using RoR2EditorKit.Core.Inspectors;
using RoR2EditorKit.Core.Windows;
using Moonstorm.EditorUtils.EditorWindows;

namespace Moonstorm.EditorUtils.Inspectors
{
    [CustomEditor(typeof(KeyAssetDisplayPairHolder))]
    public class KADPHInspector : ExtendedInspector
    {
        [OnOpenAsset]
        public static bool OpenEditor(int instanceID, int line)
        {
            if (Settings.InspectorSettings.GetOrCreateInspectorSetting(typeof(KADPHInspector)).isEnabled)
            {
                KeyAssetDisplayPairHolder obj = EditorUtility.InstanceIDToObject(instanceID) as KeyAssetDisplayPairHolder;
                if (obj != null)
                {
                    ExtendedEditorWindow.OpenEditorWindow<KADPHEditorWindow>(obj, "Key Asset Display Pair Holder Window");
                    return true;
                }
            }
            return false;
        }
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (InspectorEnabled && GUILayout.Button("Open Editor"))
            {
                ExtendedEditorWindow.OpenEditorWindow<KADPHEditorWindow>(target, "Key Asset Display Pair Holder Window");
            }
        }
    }
}