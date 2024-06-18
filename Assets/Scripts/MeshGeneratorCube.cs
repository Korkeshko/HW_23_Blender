using UnityEngine;

public class MeshGeneratorCube : MonoBehaviour
{
    private Mesh mesh;
    private Vector3[] vertices;
    private int[] triangles;

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
            new Vector3(0, 0, 0), // vertex 0
            new Vector3(1, 0, 0), // vertex 1
            new Vector3(1, 1, 0), // vertex 2
            new Vector3(0, 1, 0), // vertex 3
            new Vector3(0, 0, 1), // vertex 4
            new Vector3(1, 0, 1), // vertex 5
            new Vector3(1, 1, 1), // vertex 6
            new Vector3(0, 1, 1)  // vertex 7 
        };

        triangles = new int[]
        {  
            0, 2, 1, 0, 3, 2, // front
            6, 5, 1, 1, 2, 6, // right 
            7, 4, 5, 5, 6, 7, // back 
            3, 0, 4, 4, 7, 3, // left
            6, 2, 3, 3, 7, 6, // up
            1, 5, 4, 4, 0, 1, // down
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