# Kahn's Algorithm

kahn's algorithm is used to perform a topological sort on a directed acyclic graph (dag). it helps in ordering the vertices such that for every directed edge uv, vertex u comes before vertex v in the ordering.

## steps

1. **compute in-degrees**:
   - calculate the number of incoming edges for each vertex in the graph.

2. **initialize the queue**:
   - add all vertices with an in-degree of 0 to a queue. these vertices have no dependencies and can be processed first.

3. **process the queue**:
   - while the queue is not empty:
     - remove a vertex from the front of the queue.
     - add it to the topological order.
     - for each neighbor of the removed vertex:
       - decrease the in-degree of the neighbor by 1.
       - if the in-degree of the neighbor becomes 0, add it to the queue.

4. **check for cycles**:
   - after processing, if the topological order contains all vertices, the graph is a dag.
   - if not, the graph contains at least one cycle, and a topological sort is not possible.

## characteristics

- **type**: graph traversal algorithm
- **use case**: scheduling tasks, resolving dependencies, course prerequisite ordering
- **complexity**:
  - time: O(v + e) where v is the number of vertices and e is the number of edges
  - space: O(v + e)

## example

consider the following directed graph:

``` txt
0 → 1 → 3 
 \
  → 2 → 3
```

- **in-degrees**:
  - 0: 0
  - 1: 1
  - 2: 1
  - 3: 2

- **queue initialization**:
  - start with vertex 0

- **processing**:
  1. remove 0, add to order → order: [0]
     - decrease in-degree of 1 to 0, add to queue
     - decrease in-degree of 2 to 0, add to queue
  2. remove 1, add to order → order: [0, 1]
     - decrease in-degree of 3 to 1
  3. remove 2, add to order → order: [0, 1, 2]
     - decrease in-degree of 3 to 0, add to queue
  4. remove 3, add to order → order: [0, 1, 2, 3]

- **result**:
  - topological order: [0, 1, 2, 3]

## pseudocode

``` txt
queue = empty queue
for each vertex in graph:
    if in_degrees[vertex] == 0:
        enqueue(queue, vertex)

top_order = empty list
while not empty(queue):
    vertex = dequeue(queue)
    append(top_order, vertex)

    for each neighbor of vertex:
        in_degrees[neighbor] -= 1
        if in_degrees[neighbor] == 0:
            enqueue(queue, neighbor)

if length(top_order) == number of vertices:
    return top_order
else:
    return "graph has a cycle"
```

## key points

- can only be applied to directed acyclic graphs
- helps in detecting cycles in a graph
- useful for problems involving dependency resolution
- ensures that all dependencies of a vertex appear before the vertex itself in the ordering
