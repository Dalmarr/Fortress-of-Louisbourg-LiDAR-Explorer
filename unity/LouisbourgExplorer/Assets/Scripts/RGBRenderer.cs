using UnityEngine;

using Esri.GameEngine.Layers;
using Esri.GameEngine.Layers.PointCloud;


public class RGBRenderer : MonoBehaviour
{
    public void ConfigureRenderer(ArcGISPointCloudLayer layer)
    {
        if (layer == null)
        {
            Debug.LogError("RGBRenderer received a null point cloud layer.");

            return;
        }

        var renderer = new ArcGISPointCloudRGBRenderer("RGB");
        layer.Renderer = renderer;
    }
}