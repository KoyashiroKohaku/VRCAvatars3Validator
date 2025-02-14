﻿using Kogane;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEngine;
using VRCAvatars3Validator.Models;

namespace VRCAvatars3Validator.Views
{
    public class LanguagePackAttribute : PropertyAttribute
    {
        public LanguagePackAttribute() { }
    }

    [CustomPropertyDrawer(typeof(LanguagePackAttribute))]
    public class LanguagePackDrawer : PropertyDrawer
    {
        public static int H = 18;
        private bool enable = false;

        public class Pair
        {
            public string key;
            public string value;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var y = position.y;
            var dictionary = Deserialize(property.stringValue);
            var keys = dictionary.Dictionary.Keys.Select(key => key).ToArray();
            if (GUI.Button(NewRect(position, ref y), "Toggle Enable"))
            {
                enable = !enable;
            }
            if (GUI.Button(NewRect(position, ref y), "Copy"))
            {
                EditorGUIUtility.systemCopyBuffer = property.stringValue;
            }
            if (GUI.Button(NewRect(position, ref y), "Fetch"))
            {
                var classType = fieldInfo.DeclaringType;
                var languagePack = Activator.CreateInstance(classType) as LanguagePack;
                var masterDictionary = JsonUtility.FromJson<JsonDictionary>(languagePack.data);
                foreach (var key in masterDictionary.Dictionary.Keys)
                {
                    if(!dictionary.Dictionary.TryGetValue(key, out string value))
                    {
                        dictionary.Dictionary.Add(key, masterDictionary.Dictionary[key]);
                    }
                }
                property.stringValue = Serialize(dictionary);
            }
            using (new EditorGUI.DisabledGroupScope(!enable))
            {
                for (int i = 0; i < keys.Length; i++)
                {
                    var pair = dictionary.Dictionary.Keys;
                    using (var check = new EditorGUI.ChangeCheckScope())
                    {
                        var key = keys[i];
                        var value = dictionary.Dictionary[key];
                        var newValue = EditorGUI.TextField(NewRect(position, ref y), key, value);

                        if (check.changed)
                        {
                            dictionary.Dictionary[key] = newValue;
                            property.stringValue = Serialize(dictionary);
                        }
                    }
                }
            }
        }

        private string Serialize(JsonDictionary dictionary)
        {
            return JsonUtility.ToJson(dictionary);
        }

        private JsonDictionary Deserialize(string data)
        {
            return JsonUtility.FromJson<JsonDictionary>(data);
        }

        private Rect NewRect(Rect position, ref float y) => new Rect(position.x, y += H, position.width, position.height);
    }
}

