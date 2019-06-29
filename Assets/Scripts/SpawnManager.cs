using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MobileGame
{
    public class SpawnManager : MonoBehaviour
    {
        public GameObject[] Sphere;
        public GameObject newObject;
        public RandomMove random;


        private void Start()
        {
            random = GetComponent<RandomMove>();
        }

        private void Update()
        {
            GetValue();
            Debug.Log(newObject);
        }

        void GetValue()
        {
            newObject = Sphere[Random.Range(0, 6)];
        }
    }
}
