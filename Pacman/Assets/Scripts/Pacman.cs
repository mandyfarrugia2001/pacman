using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Pacman : MonoBehaviour
{
    [SerializeField] int lives = 3;

    [SerializeField] float movementSpeed = 30f;
    SpriteRenderer spriteRenderer;
    ManageScene sceneManagement;

    [SerializeField] AudioClip deathClip;

    [SerializeField] Vector3 startingPoint;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        sceneManagement = FindObjectOfType<ManageScene>();
    }

    void Update() => Move();

    void Move()
    {
        float deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        float newXPos = transform.position.x + deltaX;

        float deltaY = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        float newYPos = transform.position.y + deltaY;

        transform.position = new Vector3(newXPos, newYPos, transform.position.z);

        Flip();
    }

    void Flip()
    {
        if (Input.GetAxis("Horizontal") < 0)
            spriteRenderer.flipX = true;
        else if (Input.GetAxis("Horizontal") > 0)
            spriteRenderer.flipX = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ghost"))
        {
            lives--;
            Debug.Log($"{lives} - {gameObject.name} was hit by {collision.gameObject.name}");
            AudioSource.PlayClipAtPoint(deathClip, Camera.main.transform.position);

            if (lives > 0)
                transform.position = new Vector3(64, 49, transform.position.z);
            else
                sceneManagement.LoadScene(ManageScene.Scenes.Lose);
        }
    }
}
