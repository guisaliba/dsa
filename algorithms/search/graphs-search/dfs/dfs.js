let startingNode = 0;
let visited = [];

function dfs(at) {
  const graph = [
    [1, 2, 3],
    [0, 4],
    [0, 3, 4],
    [2, 4],
    [1, 2, 3],
  ];

  if (visited[at]) {
    return;
  }

  visited[at] = true;

  let neighbours = graph[at];

  for (let i = 0; i < neighbours.length; i++) {
    let neighbor = neighbours[i];
    dfs(neighbor);
  }
}

dfs(startingNode);
