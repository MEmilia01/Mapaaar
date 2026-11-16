using CesiumForUnity;
using TMPro;
using UnityEngine;

public class UIdistancia : MonoBehaviour
{
    [SerializeField] TMP_Text LATYDIS;
    [SerializeField] CesiumGlobeAnchor scripCesium;
    public string lat;

    void Start()
    {
        LatitudyLongitud();
    }

    public void LatitudyLongitud()
    {
        float latitud = Input.location.lastData.latitude;
        float longitud = Input.location.lastData.longitude;

        float altidude = Input.location.lastData.altitude;

        LATYDIS.text = "las coordenadas: (" + latitud + ","+ longitud + "," + altidude + ") ";
    }
}
