using UnityEngine;
using Esri.GameEngine.Layers;
using Esri.GameEngine.Layers.PointCloud;
using Esri.Standard;
using Esri.Unity;


public class ElevationRenderer : MonoBehaviour
{

    public void ConfigureRenderer(ArcGISPointCloudLayer layer)
    {
        if (layer == null)
        {
            Debug.LogError("ElevationRenderer received a null point cloud layer.");
            return;
        }

        var colorStops = new ArcGISCollection<ArcGISPointCloudColorStop>();


        // minimum = 1.05m; maximum = 13.27m (ArcGIS Pro 10-90% stretch)

        colorStops.Add(new ArcGISPointCloudColorStop(new ArcGISRGBColor(88, 19, 252, 255), 1.05));

        colorStops.Add(new ArcGISPointCloudColorStop(new ArcGISRGBColor(108, 128, 254, 255), 2.59));

        colorStops.Add(new ArcGISPointCloudColorStop(new ArcGISRGBColor(75, 209, 254, 255), 4.13));

        colorStops.Add(new ArcGISPointCloudColorStop(new ArcGISRGBColor(111, 253, 221, 255), 5.67));

        colorStops.Add(new ArcGISPointCloudColorStop(new ArcGISRGBColor(192, 253, 148, 255), 7.21));

        colorStops.Add(new ArcGISPointCloudColorStop(new ArcGISRGBColor(241, 254, 46, 255), 8.75));

        colorStops.Add(new ArcGISPointCloudColorStop(new ArcGISRGBColor(254, 191, 31, 255), 10.29));

        colorStops.Add(new ArcGISPointCloudColorStop(new ArcGISRGBColor(255, 113, 25, 255), 11.83));

        colorStops.Add(new ArcGISPointCloudColorStop(new ArcGISRGBColor(255, 43, 24, 255), 13.37));

        var renderer = new ArcGISPointCloudStretchRenderer("ELEVATION",colorStops);

        layer.Renderer = renderer;

    }
}