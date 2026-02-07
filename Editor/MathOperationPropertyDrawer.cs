using UnityEditor;
using UnityEngine;

namespace Zigurous.Math.Editor
{
    [CustomPropertyDrawer(typeof(MathOperation<>), true)]
    public sealed class MathOperationPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            label = EditorGUI.BeginProperty(position, label, property);

            position.height = EditorGUIUtility.singleLineHeight;
            EditorGUI.PropertyField(position, property, label, false);
            position.y += position.height + EditorGUIUtility.standardVerticalSpacing;

            EditorGUI.BeginChangeCheck();

            if (property.isExpanded)
            {
                SerializedProperty typeProperty = property.FindPropertyRelative("type");
                position = DrawProperty(position, typeProperty);

                switch (typeProperty.enumValueIndex)
                {
                    case 0: // add
                    case 1: // subtract
                    case 2: // multiply
                    case 3: // divide
                        position = DrawProperty(position, property.FindPropertyRelative("left"));
                        position = DrawProperty(position, property.FindPropertyRelative("right"));
                        break;
                    case 4: // min
                        position = DrawProperty(position, property.FindPropertyRelative("min"));
                        break;
                    case 5: // max
                        position = DrawProperty(position, property.FindPropertyRelative("max"));
                        break;
                    case 6: // clamp
                        position = DrawProperty(position, property.FindPropertyRelative("min"));
                        position = DrawProperty(position, property.FindPropertyRelative("max"));
                        break;
                    case 7: // pow
                        position = DrawProperty(position, property.FindPropertyRelative("power"));
                        break;
                }

                DrawProperty(position, property.FindPropertyRelative("register"));
            }

            if (EditorGUI.EndChangeCheck()) {
                property.serializedObject.ApplyModifiedProperties();
            }

            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = EditorGUIUtility.singleLineHeight;

            if (property.isExpanded)
            {
                height += EditorGUIUtility.standardVerticalSpacing;
                height += EditorGUIUtility.singleLineHeight;

                switch (property.FindPropertyRelative("type").enumValueIndex)
                {
                    case 0: // add
                    case 1: // subtract
                    case 2: // multiply
                    case 3: // divide
                    case 6: // clamp
                        height += EditorGUIUtility.standardVerticalSpacing * 2;
                        height += EditorGUIUtility.singleLineHeight * 2;
                        break;
                    case 4: // min
                    case 5: // max
                    case 7: // pow
                        height += EditorGUIUtility.standardVerticalSpacing;
                        height += EditorGUIUtility.singleLineHeight;
                        break;
                }

                height += EditorGUIUtility.standardVerticalSpacing;
                height += EditorGUIUtility.singleLineHeight;
            }

            return height;
        }

        private Rect DrawProperty(Rect position, SerializedProperty property, bool includeChildren = true)
        {
            EditorGUI.PropertyField(position, property, includeChildren);
            position.y += position.height + EditorGUIUtility.standardVerticalSpacing;
            return position;
        }

    }

}
