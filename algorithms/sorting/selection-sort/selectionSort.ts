function selectionSort(A: number[]): number[] {
  for (let i = 0; i < A.length; i++) {
    let minI = i;

    for (let j = i + 1; j < A.length; j++) {
      if (A[j] < A[minI]) {
        minI = j;
      }
    }

    let temp = A[i];
    A[i] = A[minI];
    A[minI] = temp;
  }

  return A;
}

// Testing the algorithm
const array = [8, 2, 12, 6, 45, 3, 1, 0];

selectionSort(array);

for (let i of array) {
  console.log(i); // 0, 1, 2, 3, 6, 8, 12, 45
}
