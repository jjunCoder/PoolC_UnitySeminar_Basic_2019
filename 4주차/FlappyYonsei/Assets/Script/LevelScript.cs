using UnityEngine;

public class LevelScript : MonoBehaviour
{
    public Transform obstacleUp;
    public Transform obstacleDown;

    public float minX = -1.0f;
    public float maxX = 1.0f;
    public float minY = -1.0f;
    public float maxY = 1.0f;

    public void CreateObstacleRandomly(float playerX)
    {
        float xVariation = playerX + 10 + Random.Range(minX, maxX);
        float downY = 10 + Random.Range(minY, maxY);
        float upY = -10 + Random.Range(minY, maxY);
        Vector3 downPos = new Vector3(xVariation, downY, 0);
        Vector3 upPos= new Vector3(xVariation, upY, 0);
        Instantiate(obstacleUp, upPos, obstacleUp.rotation);
        Instantiate(obstacleDown, downPos, obstacleDown.rotation);
    }
}
