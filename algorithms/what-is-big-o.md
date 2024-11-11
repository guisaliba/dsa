# What is Big O?

**Big O is a way to categorize your algorithm on time and memory complexity based on the input.** In other words, it is a way to tell how your algorithm reacts to different given inputs.

## Growth is with respect to the input

As your input grows, how fast does computation or memory grow? The growth of these two are **directly** related to the input. If the input grows, they will too. Take a look at this example:

```typescript
function sum_char_codes(n: string): number {
  let sum = 0;
  for (let i = 0; i < n.length; i++) {
    sum += n.charCodeAt(i);
  }

  return sum;
}
```

This algorithm iterates through every element (char) of a given string, and for every iteration, it takes the char code on that position and adds it's value to a variable **sum**.
But what does that mean? It means that for every additional char on the string, there will be an additional operation for the algorithm: add the char code on that position to the sum.

**That is O(n)**, but how can you tell that? The simplest trick is to look for loops. If you see a loop, iterating through the input (in this case, a string a.k.a an array of chars), it means that you are doing operations based on the length of that input. Your algorithm's number of operations grows with the input's length: **O(n)**.

Let's take a look at another example:

```typescript
function sum_char_codes(n: string): number {
  let sum = 0;
  for (let i = 0; i < n.length; i++) {
    sum += n.charCodeAt(i);
  }

  // capital E
  if (n.charCodeAt(i) === 69) {
    return sum;
  }

  return sum;
}
```

This is the same example as before but now we're putting a conditional that says "if you run into a capital E character on the string, returns immediately the value of sum". What would be the running time for this algorithm? It would still be **O(n)**.

And why is it still O(n)? Does it mean that the "capital E condition" makes no difference? Yes, it makes absolutely no difference, and that's because in order to determine the running time of an algorithm, we always consider the worst case scenario.

Let's say the capital E is at the last position of the input. If that is the case, the algorithm would have to iterate through the entire input before returning something, meaning that if you add an element to the input while keeping the capital E at the end of it, there will still be an extra iteration. That's still O(n).

Ok so what if the capital E is at the middle of the input or at the third last position of the input? Well then that would be a O(n / 2) or an O(n - 3) which is still an O(n).

Why is that? Because you **drop constants**. Speculating those kinds of scenarios with a "what if?" statement means that you're no longer thinking about the worst case scenario, and that breaks the set of rules that determines the Big O for an algorithm. **You should always consider worst case.** The worst case scenario for an algorithm is the way you measure how it reacts to the input's growth.

### Common complexities

- **O(1)**, **constant time**. No matter how big the input is, it does the same amount of operations every single time. That's (almost) perfection for an algorithm's running time.
- **O(log n)**, it grows linear. In other words, it is pretty fast and that's a based 2 logarithm btw.
- **O(n log n)**, which is pretty ok, not the best but good.
- **O(n^2)**, this grows pretty fast and a large input here means that the running time for this will be insanely huge as well. One of the worst scenarios.
- **O(2^n) and O(n!)**, these are so huge that they cannot run on traditional computers. These could take thousands and thousand of years of running time, and that's it.

```typescript
function sum_char_codes(n: string): number {
  let sum = 0;
  for (let i = 0; i < n.length; i++) {
    for (let j = 0; j < n.length; j++) {
      sum += n.charCodeAt(i);
    }
  }

  return sum;
}
```

From this example, you can easily tell that the running time for the algorithm is **O(n^2)**. Remember the trick? "Look for the loops", that's how you can tell. There are two loops in this algorithm and they are nested, which means that for every iteration on **i** another iteration happens. If we were to imagine these nested loops as graphs, for every vertical line on the graph, we look at an horizontal line as well.

Short story short, these are the three main concepts to keep in mind when talking about Big O:

1. Growth is related to input;
2. Constants are dropped;
3. Worst case scenario is ALWAYS the way to measure time and space complexity for an algorithm.
