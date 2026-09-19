# Data Sources

This project uses publicly available geospatial data from the Province of Nova Scotia to support LiDAR processing, RGB colourization, and 3D scene layer preparation for the Fortress of Louisbourg study area.

## LiDAR

**Provider:** Province of Nova Scotia / GeoNOVA  
**Access:** Nova Scotia DataLocator – Elevation Explorer  
**Project subset:** 12 classified LAZ tiles covering the Fortress of Louisbourg area  
**Acquisition year:** 2018  
**Coordinate reference:** NAD83(CSRS)v6 / UTM Zone 20, with CGVD2013 vertical reference

The LiDAR was used as the primary 3D source dataset for point cloud inspection, QA/QC, classification visualization, elevation and intensity rendering, and creation of the final point cloud scene layer package.

Data portal:  
https://nsgi.novascotia.ca/datalocator/elevation/

## Orthophoto Imagery

**Provider:** Province of Nova Scotia / GeoNOVA  
**Dataset:** Nova Scotia Orthophotomap Database (NSODB)  
**Project imagery:** 2024 orthophotography covering the Fortress of Louisbourg area  
**Primary project sheet/tile:** 1045850059900

The orthophoto imagery was used in ArcGIS Pro to colourize the LiDAR point cloud, providing RGB values for the application's true-colour visualization mode.

Data / imagery index:  
https://nsgi.novascotia.ca/datalocator/indexing/

GeoNOVA orthophoto information:  
https://geonova.novascotia.ca/base-mapping

## Derived Project Data

The following products were generated during the project and are not distributed through this public repository:

- processed LAS datasets
- AOI-clipped LiDAR content
- RGB-colourized LiDAR
- terrain and supporting GIS outputs
- point cloud scene layer package (SLPK)
- standalone application runtime data

These derived files are excluded mainly because of size, and because the repository is intended as a public-facing information page rather than a geospatial data distribution package.

## Software

- ArcGIS Pro
- ArcGIS Maps SDK for Unity
- Unity
