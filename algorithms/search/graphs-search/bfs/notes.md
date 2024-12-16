# breadth first search (bfs)

breadth first search is a search algorithm most used in graph theory.
the basic functionality of this algorithm consists in picking a node randomly to be the first node explored.

there is also the possibility of setting a start node and an end node to find a path between them, making the selection of
the first node not to be random.

after selecting the starting node, the algorithm visits its neighbours and keeps on visiting the neighbours of the neighbours
until every node in the graph has been already visited.

this algorithm gives a layer based traversing, where the neighbours of each node represent a layer, and since every neighbour of a node must be visited before going on to the next node.

in other words, until a layer has been fully visited the algorithm won't
continue to the next layer.

1. picks a node `v`;
2. visits nodes that are neighbours of `v`;
3. when `v` has no more to-be visited neighbour, go on to the next node;
4. repeats this until every node has been visited.

bfs uses a queue to keep track of the order of visited nodes, and thus define which will be the next node to be explored.

it also makes use two lists (or arrays or anything like): one to keep track of the visited nodes (`visited = []`) and one to keep the predecessor of each node (`prev = []`).

1. puts the initial node in the queue (`v`);
2. marks it as visited (so any node won't be visited again in case it is neighbours of a not yet visited node);
3. removes the node from the queue;
4. gets all neighbours of the node;
5. for each neighbour, if they have not been visited yet, put them onto the queue;
6. marks the neighbour as visited;
7. marks the predecessor (previous node) of the neighbour as being the current explored node.
