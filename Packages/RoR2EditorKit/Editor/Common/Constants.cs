﻿using UnityEditor;
using UnityEngine;

namespace RoR2EditorKit.Common
{
    public static class Constants
    {
        public const string RoR2EditorKit = nameof(RoR2EditorKit);

        public const string RoR2EditorKitContextRoot = "Assets/Create/RoR2EditorKit/";
        public const int RoR2EditorKitContextPriority = 1;
        public const string RoR2EditorKitMenuRoot = "Tools/RoR2EditorKit/";
        public const string RoR2KitSettingsRoot = "Assets/ThunderkitSettings/RoR2EditorKit/";

        private const string nullMaterialGUID = "732339a737ef9a144812666d298e2357";
        private const string nullMeshGUID = "9bef9cd9cd0c4b244ad1ff166c26f57e";
        private const string nullSpriteGUID = "1a8e7e70058f32f4483753ec5be3838b";
        private const string nullPrefabGUID = "f6317a68216520848aaef2c2f470c8b2";

        public static Material NullMaterial { get => AssetDatabase.LoadAssetAtPath<Material>(AssetDatabase.GUIDToAssetPath(nullMaterialGUID)); }
        public static Mesh NullMesh { get => AssetDatabase.LoadAssetAtPath<Mesh>(AssetDatabase.GUIDToAssetPath(nullMeshGUID)); }
        public static Sprite NullSprite { get => AssetDatabase.LoadAssetAtPath<Sprite>(AssetDatabase.GUIDToAssetPath(nullSpriteGUID)); }
        public static GameObject NullPrefab { get => AssetDatabase.LoadAssetAtPath<GameObject>(AssetDatabase.GUIDToAssetPath(nullPrefabGUID)); }
    }
}
