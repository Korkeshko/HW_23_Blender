using UnityEngine;

public class MeshGeneratorSquare : MonoBehaviour
{
    Mesh mesh;

    Vector3[] vertices;
    int[] triangles;
    

    void Start()
    {
        mesh = new Mesh(); 
        GetComponent<MeshFilter>().mesh = mesh;

        CreateShape();
        UpdateMesh();
    }

    void CreateShape()
    {
        vertices = new Vector3[]
        {
            new Vector3(0, 0, 0),
            new Vector3(0, 0, 1),
            new Vector3(1, 0, 0),
            new Vector3(1, 0, 1)
        };
        
        triangles = new int[]
        {
            0, 1, 2, // first triangle
            1, 3, 2  // second triangle
        };
    }

    void UpdateMesh()
    {
        mesh.Clear();

        mesh.vertices = vertices;
        mesh.triangles = triangles;

        mesh.RecalculateNormals();
    }
}