using UnityEngine;
using Esri.GameEngine.Layers;   
using Esri.GameEngine.Layers.PointCloud;
using Esri.Standard;
using Esri.Unity;


public class ClassificationRenderer : MonoBehaviour
{

    public void ConfigureRenderer(ArcGISPointCloudLayer layer)
    {
        if (layer == null)
        {
            Debug.LogError("ClassificationRenderer received a null point cloud layer.");
            return;
        }

        var uniqueValues = new ArcGISCollection<ArcGISPointCloudColorUniqueValue>();

        // 2 - Ground
        AddClass(uniqueValues, "2", "Ground", 137, 112, 68);

        // 3 - Low Vegetation
        AddClass(uniqueValues, "3", "Low Vegetation", 56, 168, 0);

        // 4 - Medium Vegetation
        AddClass(uniqueValues, "4", "Medium Vegetation", 76, 230, 0);

        // 5 - High Vegetation
        AddClass(uniqueValues, "5", "High Vegetation", 205, 245, 122);

        // 6 - Buildings
        AddClass(uniqueValues, "6", "Buildings", 140, 140, 140);

        // 9 - Water
        AddClass(uniqueValues, "9", "Water", 0, 92, 230);

        // 17 - Bridge Deck
        AddClass(uniqueValues, "17", "Bridge Deck", 130, 130, 130);


        var renderer = new ArcGISPointCloudUniqueValueRenderer("CLASS_CODE", uniqueValues);
        layer.Renderer = renderer;

    }

    private void AddClass(ArcGISCollection<ArcGISPointCloudColorUniqueValue> collection, string classCode, string label, byte red, byte green, byte blue)
    {
        var values = new ArcGISCollection<string>();

        values.Add(classCode);

        var uniqueValue =  new ArcGISPointCloudColorUniqueValue(new ArcGISRGBColor(red, green, blue, 255), values)
            {
                Label = label,
                Description = label
            };

        collection.Add(uniqueValue);
    }
}