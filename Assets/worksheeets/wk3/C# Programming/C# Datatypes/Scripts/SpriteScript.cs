using UnityEngine;

namespace GADVDataTypes
{
    public class SpriteScaler : MonoBehaviour
    {
        private Transform spriteTransform;
        private string scale = "2.0";

        private void Start()
        {
            spriteTransform = GetComponent<Transform>();

            // Convert the string scale to a float before using it in the Vector3 constructor
            if (float.TryParse(scale, out float scaleValue))
            {
                spriteTransform.localScale = new Vector3(scaleValue, scaleValue, 1f);
            }
            else
            {
                Debug.LogError("Invalid scale value. Please provide a valid numeric string.");
            }
        }
    }
}