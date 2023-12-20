using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    public SpriteRenderer playerSprite;
    private float rightScreenEdge;
    private float leftScreenEdge;
    private float playerSpriteHalfWidth;

   
    void Start()
    {
     
        Camera mainCamera = Camera.main;


        Vector2 screenTopRightCorner = new Vector2(Screen.width, Screen.height);
        Vector2 topRightCornerInWorldSpace = mainCamera.ScreenToWorldPoint(screenTopRightCorner);
        rightScreenEdge = topRightCornerInWorldSpace.x;
        

        Vector2 screenBottomLeftCorner = new Vector2(0f, 0f);
        Vector2 bottomLeftCornerInWorldSpace = mainCamera.ScreenToWorldPoint(screenBottomLeftCorner);
        leftScreenEdge = bottomLeftCornerInWorldSpace.x;

        playerSpriteHalfWidth = playerSprite.bounds.size.x / 2f;
    }


    void Update()
    {
        float inputHl = Input.GetAxis("Horizontal");

     
        if (inputHl > 0 && (transform.position.x <= rightScreenEdge - playerSpriteHalfWidth))
        {
   
            Vector3 currentPos = transform.position;

 
            Vector3 newPos = currentPos + new Vector3(1f, 0f);


            transform.position = Vector3.MoveTowards(currentPos, newPos, moveSpeed * Time.deltaTime);
        }
        else if (inputHl < 0 && (transform.position.x >= leftScreenEdge + playerSpriteHalfWidth))
        {
     
            Vector3 currentPos = transform.position;

    
            Vector3 newPos = currentPos - new Vector3(1f, 0f);

            transform.position = Vector3.MoveTowards(currentPos, newPos, moveSpeed * Time.deltaTime);
        }
    }
}
