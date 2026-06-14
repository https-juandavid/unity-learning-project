using UnityEngine;

public class SwitchCaseExample : MonoBehaviour
{
    [SerializeField] private int temperature = 10;

    void Awake()
    {
        
    }


    // Update is called once per frame
    void Update()
    {

        switch (temperature)
        {
            case <20:
                Debug.Log("El clima esta templado");
                break;
            case <30:
                Debug.Log("El clima esta acalorado");
                break;
            case <40:
                Debug.Log("Jueputa esta mierda se volvio barranca mk");
                break;
            default:
                Debug.Log("La temperatura es de 10 grados, estable");
                break;
        }

    }
}
