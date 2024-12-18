const graph = [
  [1, 2],
  [3],
  [3],
  [],
];

function kahn(graph) {
  const order = [];

  const inDegrees = new Array(graph.length).fill(0);

  for (let node = 0; node < graph.length; node++) {
    for (let neighbor of graph[node]) {
      inDegrees[neighbor]++;
    }
  }

  const queue = [];

  for (let node = 0; node < inDegrees.length; node++) {
    if (inDegrees[node] === 0) {
      queue.push(node);
    }
  }

  while (queue.length > 0) {
    const node = queue.shift();
    order.push(node);

    for (let neighbor of graph[node]) {
      inDegrees[neighbor]--;
      if (inDegrees[neighbor] === 0) {
        queue.push(neighbor);
      }
    }
  }

  if (order.length !== graph.length) {
    // graph is not a DAG
    return;
  }
}

kahn(graph);
