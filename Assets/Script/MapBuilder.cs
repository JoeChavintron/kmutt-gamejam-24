using UnityEngine;

namespace Script
{
    public class MapBuilder : MonoBehaviour
    {
        public float row = 10;
        public float column = 10;
        public float offset = 9.5f;
        public GameObject blockPrefab;

        public void Build()
        {
            for (var r = 0; r <= row; r++)
            {
                for (var c = 0; c <= column; c++)
                {
                    var position = transform.position;
                    var block = Instantiate(
                        blockPrefab,
                        new Vector3(
                            position.x + r * offset,
                            position.y,
                            position.z + c * offset),
                        Quaternion.identity,
                        transform);
                }
            }
        }
    }
}