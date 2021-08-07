using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class SampleShowPhoton : MonoBehaviour
{
    public Text showPhotonId;


    private void Start()
    {
        var text = "";
        
        text = $"Photon App ID: {PhotonNetwork.PhotonServerSettings.AppSettings.AppIdChat}\n";
        text += $"Photon Fusion ID: {PhotonNetwork.PhotonServerSettings.AppSettings.AppIdFusion}\n";
        text += $"Photon Realtime ID: {PhotonNetwork.PhotonServerSettings.AppSettings.AppIdRealtime}\n";
        text += $"Photon Voice ID: {PhotonNetwork.PhotonServerSettings.AppSettings.AppIdVoice}";
        
        showPhotonId.text = text;
    }
}