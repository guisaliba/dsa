// depth first search (dfs) is also useful to find connected
// components in a graph. finding connected disjoint components
// in a graph means assigning an id to each vertex such that all
// vertices with the same id are connected.

// this is the same idea as coloring the vertices that belong
// to the same component with a color each, but instead of colo-
// them, we assign an id to each connected component.

// time complexity: O(V + E)

const graph = [
  [1, 2, 3],
  [0, 4],
  [0, 3, 4],
  [2, 4],
  [1, 2, 3],
];

// visited = array to keep track of visited vertices.
let visited = [];

// components = array to keep track of the connected components.
let components = [];

// count = number of connected components.
let count = 0;

function findComponents() {
  for (let i = 0; i < graph.length; i++) {
    if (!visited[i]) {
      count++;
      dfs(i);
    }
  }
  return { count, components, componentsNumber: new Set(components).size };
}

function dfs(at) {
  visited[at] = true;
  components[at] = count;

  for (let next of graph[at]) {
    if (!visited[next]) {
      dfs(next);
    }
  }
}

findComponents();
