const graph = [
  [1, 2],
  [0, 3, 4],
  [0, 5, 6],
  [1],
  [1],
  [2],
  [2]
];

function bfs(start, end) {
  const prev = solve(start, graph);
  const path = reconstruct(start, end, prev);

  return path;
}

function solve(start, graph) {
  const nodes = graph.length;

  let queue = [];
  queue.push(start);

  let prev = new Array(nodes).fill(null);

  let visited = new Array(nodes).fill(false);
  visited[start] = true;

  while (queue.length > 0) {
    let node = queue.shift();
    let neighbours = graph[node];

    for (let neighbour of neighbours) {
      if (!visited[neighbour]) {
        queue.push(neighbour);
        visited[neighbour] = true;
        prev[neighbour] = node;
      }
    }
  }

  return prev;
}

function reconstruct(start, end, prev) {
  let path = [];

  for (let i = end; i != null; i = prev[i]) {
    path.push(i);
  }

  path.reverse();

  if (path[0] === start) {
    console.log(`Found path: ${path}`);
    return path;
  }

  return [];
}

bfs(0, 6);
