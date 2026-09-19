using UnityEngine;
using Esri.GameEngine.Layers;
using Esri.GameEngine.Layers.PointCloud;
using Esri.Standard;
using Esri.Unity;


public class IntensityRenderer : MonoBehaviour
{

    public void ConfigureRenderer(ArcGISPointCloudLayer layer)
    {
        if (layer == null)
        {
            Debug.LogError("IntensityRenderer received a null point-cloud layer.");
            return;
        }

        var colorStops = new ArcGISCollection<ArcGISPointCloudColorStop>();
        
        // minimum = 597.96; maximum = 1360.88 (ArcGIS Pro 10-90% stretch)
        colorStops.Add(new ArcGISPointCloudColorStop(new ArcGISRGBColor(0, 0, 0, 255), 597.96));

        colorStops.Add(new ArcGISPointCloudColorStop(new ArcGISRGBColor(64, 64, 64, 255), 788.69));

        colorStops.Add(new ArcGISPointCloudColorStop(new ArcGISRGBColor(128, 128, 128, 255), 979.42));

        colorStops.Add(new ArcGISPointCloudColorStop(new ArcGISRGBColor(191, 191, 191, 255), 1170.15));

        colorStops.Add(new ArcGISPointCloudColorStop(new ArcGISRGBColor(255, 255, 255, 255), 1360.88));

        var renderer = new ArcGISPointCloudStretchRenderer("INTENSITY", colorStops);

        layer.Renderer = renderer;

    }
}