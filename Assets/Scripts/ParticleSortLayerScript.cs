using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSortLayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Change Foreground to the layer you want it to display on 
        //You could prob. make a public variable for this
        GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = "Particles";
    }
}
