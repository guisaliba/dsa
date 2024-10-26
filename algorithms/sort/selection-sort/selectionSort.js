function selectionSort(A) {
  for (let i = 0; i < A.length - 1; i++) {
    let minI = i;

    for (j = i + 1; j < A.length; j++) {
      if (A[j] < A[minI]) {
        minI = j;
      }
    }

    let temp = A[i];
    A[i] = A[minI];
    A[minI] = temp;
  }
}

// Testing the algorithm
const array = [5, 2, 4, 6, 1, 3];

selectionSort(array);

for (let i of array) {
  console.log(i); // 1, 2, 3, 4, 5, 6
}
