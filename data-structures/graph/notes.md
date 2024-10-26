just like a tree, a graph is a non-linear data structure. it is a collection of **entities** called **nodes or vertices** connected by **edges**.

in a tree there are rules dictating those vertices. first of all, vertices and edges represent parent-child relationship. an edge connects two nodes and sets the hierarchical structure of parent-child.

if a tree has N nodes, then the number of edges is exactly N -  1, because all nodes have at least one parent except for the root node. edges connect parents to their children thus the root node not having a parent means it has no edge coming from another node to it, so N - 1.

also, in a tree any node must be reachable from the root by exactly one path. this means that if a node V belongs to a tree, there has to be one path from the root that reaches V.

for graphs, there are no rules dictating the connection among the nodes.
edges can connect a set of nodes in any way.

a tree is a special kind of graph.

a graph **G** is an ordered pair of a set **V** of vertices and a set **E** of edges.
 **G = (V, E)**

an ordered pair means that (a, b) is different from (b, a) if a != b.
"a" must always be a vertex and "b" must always be an edge.

we usually name vertices in a graph, like: V = {V1, V2, V3, V4, V5} for a graph with 5 vertices for example. for edges, they can be identified from their two endpoints. if an edge connects a vertex u to a vertex v, we can just write: u --- v to represent that edge.

edges can be of two types:

1. directed: u -> v, means that there is a path from u to v but we can not assume a path from v to u, this can be represented like: (u, v)
2. undirected: here the connection is bi-directional. origin and destination are not fixed, we only need to know what endpoints are being connected. we can represent them like:  {u, v}

a directed graph, which has all directed edges is called a **digraph**.
a graph with all undirected edges has no special name.

graphs representations:

1. social network: a social network can be represented by an undirected graph, where each vertex is a person and the edges represent a connection between them, let's call it a friendship. it's an undirected graph because a friendship is a 2-way connection: if i am friends to someone, they are also friends of mine.
2. world-wide-web: the web can be represented by a graph because pages can be linked to other pages. so the vertices of this graph would be pages and the edges would represent links: an edge connects two vertices only if one of them links to the other one. in other words, this is a directed graph, the relationship is not mutual this time, a page can link to another one that doesn't link back to it.

we can apply standard graph theory algorithms to solve problems. for the web example, a famous algorithm that can be applied is web-crawling.
web-crawling is basically graph traversal, or in simple words, the act of visiting all nodes in a graph.

graphs can be weighted, because sometimes in a graph all connections can not be treated as equal. for example, the highways between cities can have different lengths. again: vertices are cities and edges are the roads, and since they have different lengths, we can weigh them by their length.

to find the shortest path between a city A to a city B we can take the edges that creates a path between those two cities but take into account the edges with the lowest weights to find the shortest path between them.

an edge can be called a **self-loop** if it envolves only 1 vertex. a page in the web is an URL, it can contain links to other pages, but it can also contain a link to itself. that's a clear example of a self-loop.

another special type of edge is **multi-edge**, or **parallel edge**. an edge is a multi-edge if it occurs more than once in a graph, that is a vertex u that has two directed edges connecting it to a vertex v, they are the same ordered pair: (u, v) but two different edges.

if a graph contains no self-loops or multi-edges it is a **simple graph**.

the minimum possible number of edges in a graph is **zero**, because a graph is still a graph even if there are no edges linking its vertices.

the maximum number of edges in a digraph is:
 N * (N - 1)

for undirected graphs, the maximum number of edges would be:
 N * (N - 1) / 2

number of edges can be really larger than number of vertices in a graph.
let's say N = 40, then the maximum number of edges in a digraph would be:
 40 * (40 - 1) = 1560 edges

for an undirected graph, that number would be 780.

a graph is called dense if there are too many edges compared to vertices, and it is called sparse if there are too few edges in comparison.

we tipically store dense graphs in a structure called adjacency matrix, and sparse graphs in a structure called adjacency list.

a path is a sequence of vertices where each adjacent pair is connected by an edge. we can represent them like: A, B, F, H. which means there is an edge linking vertex A to B, another from B to F, and another from F to H. this is a path A -> B -> F -> H.

a simple path is a path in which no vertices and edges are not repeated. the above path is a simple path, because no vertices and edges were repeated. it can also be called a walk.

a walk is called a trail if vertices can be repeated but edges can not.

a graph can be a strongly connected graph if there is a path from any vertex to any other vertex. for undirected graphs, if there is a path from any vertex to any other vertex, we call it connected.

for a directed graph that satisfies this condition, we call it strongly connected.

a walk is called a closed walk if it starts and ends at the same vertex. the length of a walk is the number of edges in the path. in the above example, the length of that walk is 3, which is not a closed walk (it does not start and end at the same vertex).

a cycle is nonetheless a closed walk. a graph with no cycle is called an acyclic graph, e.g.: a tree with undirected edges (parent-children relationship can never form a cycle because one can not be a child of their parent and parent of their parent at the same time).

a directed acyclic graph is often called a DAG.
