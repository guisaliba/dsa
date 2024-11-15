using System;
using System.Collections.Generic;

public class Graph(List<Vertex> vertices, List<Edge> edges)
{
    private readonly List<Vertex> _vertices = vertices ?? new List<Vertex>();
    private readonly List<Edge> _edges = edges ?? new List<Edge>();

    public IReadOnlyList<Vertex> Vertices => _vertices.AsReadOnly();
    public IReadOnlyList<Edge> Edges => _edges.AsReadOnly();

    public class Vertex
    {
        public int Index { get; set; }
        public string Name { get; set; }

        public Vertex(int index, string name)
        {
            Index = index;
            Name = name;
        }

        public override string ToString()
        {
            return $"Vertex: {Index} - {Name}";
        }
    }

    public class Edge
    {
        public int Index { get; set; }
        public Vertex Source { get; set; }
        public Vertex Destination { get; set; }
        public int Weight { get; set; }

        public Edge(int index, Vertex source, Vertex destination, int weight)
        {
            Index = index;
            Source = source;
            Destination = destination;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Edge: {Index} - {Source.Index} -> {Destination.Index} ({Weight})";
        }
    }

    public Vertex GetVertex(int index)
    {
        return _vertices.Find(v => v.Index == index);
    }

    public void AddVertex(Vertex vertex)
    {
        _vertices.Add(vertex);
    }

    public void RemoveVertex(Vertex vertex)
    {
        _vertices.RemoveAll(v => v.Index == vertex.Index);
    }

    public Edge GetEdge(int index)
    {
        return _edges.Find(e => e.Index == index);
    }

    public void AddEdge(Edge edge)
    {
        _edges.Add(edge);
    }

    public void RemoveEdge(Edge edge)
    {
        _edges.RemoveAll(e => e.Index == edge.Index);
    }

    public Edge ChangeEdge(Edge edge)
    {
        var existingEdge = GetEdge(edge.Index);
        if (existingEdge != null)
        {
            existingEdge.Source = edge.Source;
            existingEdge.Destination = edge.Destination;
            existingEdge.Weight = edge.Weight;
        }
        return existingEdge;
    }

    public void Print()
    {
        foreach (var vertex in _vertices)
        {
            Console.WriteLine(vertex);
        }

        foreach (var edge in _edges)
        {
            Console.WriteLine(edge);
        }
    }
}