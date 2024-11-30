using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; // 탄알 이동 속력
    Rigidbody bulletRigidbody; // 이동에 사용할 리지드바디 컴포넌트
    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f); // 3초후 파괴
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            if (playerController != null)
            {
                playerController.Die();
            }
        }
    }
}
