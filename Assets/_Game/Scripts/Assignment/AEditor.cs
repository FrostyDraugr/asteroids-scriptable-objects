using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AsteroidSettings))]
public class AEditor : Editor
{
    public override void OnInspectorGUI()
    {
        var style = new GUIStyle(GUI.skin.label) { alignment = TextAnchor.MiddleCenter };
        GUILayout.Label("Asteroid Editor", style, GUILayout.ExpandWidth(true));

        AsteroidSettings asteroid = target as AsteroidSettings;
        asteroid.AsteroidDamage = EditorGUILayout.IntSlider("Damage: ", asteroid.AsteroidDamage, -10, 100);
        asteroid.Color = EditorGUILayout.ColorField("Color: ", asteroid.Color);
        asteroid.Scale = EditorGUILayout.Slider("Scale: ", asteroid.Scale, 0.1f, 5f);
        asteroid.speedMod = EditorGUILayout.Slider("SpeedMod: ", asteroid.speedMod, 0.1f, 5f);

    }
}
