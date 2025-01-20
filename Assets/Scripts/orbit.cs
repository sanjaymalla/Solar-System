using UnityEngine;

public class orbit : MonoBehaviour
{
    public LineRenderer circleRenderer;
    [SerializeField] private float radius=1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DrawCircle(100, radius);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DrawCircle(int steps, float radius)
    {
        circleRenderer.positionCount = steps;

        for (int currentStep = 0; currentStep < steps; currentStep++) 
        {
            float circumferenceProgress = (float)currentStep / steps;

            float currentRadian = circumferenceProgress*2*Mathf.PI;

            float xScaled = Mathf.Cos(currentRadian);
            float zScaled = Mathf.Sin(currentRadian);

            float x = xScaled * radius;
            float z = zScaled * radius; 

            Vector3 currentPosition = new Vector3(x, 0, z);

            circleRenderer.SetPosition(currentStep, currentPosition);
        }
    }
}
