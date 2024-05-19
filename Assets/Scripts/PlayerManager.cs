using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Charakter
{
    public class PlayerManager : IPlayerManager
    {
        Rigidbody rgb;

        [Header("Animator referance")]
        [SerializeField] private Animator animator;

        [Header("ChatSceane")]
        [SerializeField] GameObject chatGameObejct;

        [SerializeField] SpriteRenderer spriteRenderer;

        private void Awake()
        {
            rgb = gameObject.GetComponent<Rigidbody>();
        }

        #region 
        void Update()
        {
            animator.SetBool("run_on", false);

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
                animator.SetBool("run_on", true);
                spriteRenderer.flipX = false;
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
                animator.SetBool("run_on", true);
                spriteRenderer.flipX = true;
            }

            if (Input.GetKeyDown(KeyCode.Space) && �sGround)
            {
                rgb.AddForce(new Vector3(0, 30f, 0));
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                if (chatGameObejct != null && �sEarea == true)
                {
                    u�Acticite = !u�Acticite;
                    chatGameObejct.SetActive(u�Acticite);
                }
                else
                {
                    Debug.Log("Empty Object");
                }
            }
        }
        #endregion

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("GameController"))
            {
                �sEarea = true;
                Debug.Log("Chat Screan On");
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("GameController"))
            {
                �sEarea = false;
                Debug.Log("Chat Screan Off");
            }
        }

        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                �sGround = true;
            }
        }

        public void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                �sGround = false;
            }
        }
    }
}


