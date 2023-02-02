using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtHandsLightContol : MonoBehaviour
{
    static bool isLightOn = true;

    public GameObject spotLight, pointLight;//, purpleSpotLight, purplePointLight;

    public void ConfigureLight()
    {
        spotLight.SetActive(!isLightOn);
        pointLight.SetActive(!isLightOn);

        isLightOn = !isLightOn;
    }

/*    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
*/
}
