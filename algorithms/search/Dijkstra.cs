using System;
using System.Collections.Generic;

public class Graph(Vertex[] vertices, Edge[,] edges)
{
  public readonly Vertex[] _vertices = vertices;
  public readonly Edge[,] _edges = edges;
}

public class Vertex
{
  public int Id { get; set; } = default;
  public Vertex? From { get; set; }
  public Vertex[]? To { get; set; }
}

public class Edge
{
  public Vertex? From { get; set; }
  public Vertex? To { get; set; }
  public int Weight { get; set; }
}

public class Program
{
  static int[] Dijkstra(Graph graph, Vertex root)
  {
    int n = graph._vertices.Length;
    int[] dist = new int[n];
    int[] prev = new int[n];
    bool[] visited = new bool[n];

    for (int i = 0; i < n; i++)
    {
      dist[i] = int.MaxValue; // Infinity
      prev[i] = -1;
      Console.WriteLine($"Inicializando a distância do vértice {i} como Infinito e seu predecessor como nulo.");
    }

    dist[root.Id] = 0;

    for (int i = 0; i < n; i++)
    {
      // Select the unvisited vertex with the smallest distance
      int u = -1;
      int minDist = int.MaxValue;
      for (int v = 0; v < n; v++)
      {
        if (!visited[v] && dist[v] < minDist)
        {
          minDist = dist[v];
          Console.WriteLine($"Atualizando a menor distância do vértice {v} para {minDist}.");
          u = v;
        }
      }

      if (u == -1)
        break;

      visited[u] = true;
      Console.WriteLine($"Marcando o vértice {u} como visitado.");

      if (graph._edges != null)
      {
        for (int v = 0; v < n; v++)
        {
          Edge edge = graph._edges[u, v]; // null if there is no edge between u and v

          if (edge != null && dist[u] != int.MaxValue && dist[v] > dist[u] + edge.Weight)
          {
            dist[v] = dist[u] + edge.Weight;
            Console.WriteLine($"Distância da raíz ao vértice {v} atualizada para {dist[v]}.");
            prev[v] = u;
            Console.WriteLine($"Predecessor do vértice {v} atualizado para {u}.");
          }
        }
      }
    }

    return dist;
  }


  public static void Main()
  {
    int size = 8;
    Vertex[] vertices = new Vertex[size];
    Console.WriteLine("Populando o grafo com os vértices...");
    for (int i = 0; i < size; i++)
    {
      vertices[i] = new Vertex { Id = i };
    }

    Edge[,] edges = new Edge[size, size];

    Console.WriteLine("Populando o grafo com as arestas...");
    edges[0, 1] = new Edge { From = vertices[0], To = vertices[1], Weight = 11 };
    edges[0, 2] = new Edge { From = vertices[0], To = vertices[2], Weight = 18 };
    edges[0, 3] = new Edge { From = vertices[0], To = vertices[3], Weight = 16 };
    edges[0, 4] = new Edge { From = vertices[0], To = vertices[4], Weight = 16 };

    edges[1, 3] = new Edge { From = vertices[1], To = vertices[2], Weight = 11 };
    edges[1, 4] = new Edge { From = vertices[1], To = vertices[4], Weight = 14 };
    edges[1, 5] = new Edge { From = vertices[1], To = vertices[5], Weight = 5 };
    edges[1, 7] = new Edge { From = vertices[1], To = vertices[7], Weight = 10 };

    edges[2, 3] = new Edge { From = vertices[2], To = vertices[3], Weight = 8 };
    edges[2, 6] = new Edge { From = vertices[2], To = vertices[6], Weight = 20 };

    edges[3, 6] = new Edge { From = vertices[3], To = vertices[6], Weight = 22 };

    edges[4, 6] = new Edge { From = vertices[4], To = vertices[6], Weight = 30 };
    edges[4, 7] = new Edge { From = vertices[4], To = vertices[7], Weight = 12 };

    edges[5, 7] = new Edge { From = vertices[5], To = vertices[7], Weight = 3 };

    // Populate the 'To' lists for each vertex
    foreach (var edge in edges)
    {
      if (edge != null)
      {
        edge.From.To = edge.From.To ?? [];
        // Resize the 'To' array to accommodate the new edge
        var toList = new List<Vertex>(edge.From.To) { edge.To };
        edge.From.To = toList.ToArray();
      }
    }

    Graph graph = new(vertices, edges);

    int[] distances = Dijkstra(graph, vertices[0]);
    Console.WriteLine(string.Format("Distâncias mínimas da raíz aos demais vértices: {0}", string.Join(", ", distances)));
  }
}