using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MobileGame
{
    public class RandomMove : MonoBehaviour
    {
        public float minX;
        public float minY;
        public float maxX;
        public float maxY;
        public float speed = 0.75f;

        private Vector2 targetPosition;

        private void Start()
        {
            targetPosition = GetRandomPosition();
        }

        private void Update()
        {
            if ((Vector2)transform.position != targetPosition)
            {
                transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            }
            else
            {
                targetPosition = GetRandomPosition();
            }
        }
        Vector2 GetRandomPosition()
        {
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            return new Vector2(randomX, randomY);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Circles")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
    