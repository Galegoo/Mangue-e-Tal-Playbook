using UnityEngine;
using System.Collections;

public static class RendererExtensions1
{

    public static bool isVisibleFrom1(this Renderer renderer, Camera camera)
    {
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
        return GeometryUtility.TestPlanesAABB(planes, renderer.bounds);
    }
}

