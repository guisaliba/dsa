# depth first search (dfs)

depth first search (dfs) is a search algorithm that explores as far as possible along each branch before backtracking.

that is, exploring each vertex and its children all the way down to the last child before backtracking to the previous vertex and exploring its children.

it starts picking up an initial node `v`, and from this node, it randomly picks the next node (as long as it is neighbour of it).
once the next node has no more neighbours to visit, backtracks to the node currently being explored to check if it still has nodes to visit.

if it doesn't, keeps backtracking until reaching `v`, the starting node of the algorithm. this is done recursively.

1. start at the initial node `v`;
2. mark `v` as visited;
3. for each adjacent node `w` of `v`, if `w` is not visited, recursevely performs dfs on node `w`;
4. backtrack when all adjacent nodes are visited.
