using UnityEngine;

public class PlayerController : MonoBehaviour
{

  [SerializeField] private int velocityInitial = 10;
  [SerializeField] private int velocityActual;
  [SerializeField] private float altura = 1.60f;
  [SerializeField] private bool isJumping = true;
  [SerializeField] private string playerName = "";

  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {
    velocityActual = GetVelocity();
    Debug.Log("La velocidad actual es:" + velocityActual);
  }

  protected internal void PrintLogs()
  {
    var newPlayer = new
    {
      name = "Player1",
      score = 0
    };

    Debug.Log(newPlayer);
  }

  public int GetVelocity()
  {
    velocityActual = velocityInitial + 20;
    return velocityActual;
  }

  
}
