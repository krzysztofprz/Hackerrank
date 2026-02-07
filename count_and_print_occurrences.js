const arr = [
  "aabaa", // 2a1b2a
  "aaabba", // 3a2b1a
  "abbaaabbbccc", //1a2b3a3b3c
  "ddddcccbba", // 4d3c2b1a
  "aadaaaccdd", //2a1d3a2c2d
];

function countAndPrint(input) {
  const temp = {};

  for (let char of input) {
    if (Object.keys(temp).includes(char)) {
      temp[char]++;
      continue;
    }

    temp[char] = 1;
  }

  return Object.keys(temp).reduce((acc, current) => {
    return acc + temp[current] + current;
  }, "");
}

function countAndPrintInGroups(input) {
  let result = "";

  let count = 1;
  let last = "";
  let i = 0;

  for (i; i <= input.length; i++) {
    if (i === input.length) {
      result += count + last;
      continue;
    }

    if (input[i] === last) {
      count++;
      continue;
    }

    if (last !== "") {
      result += count + last;
    }

    count = 1;
    last = input[i];
  }

  return result;
}

for (let a of arr) {
  console.log("countAndPrint: ", countAndPrint(a));
}

for (let a of arr) {
  console.log("countAndPrintInGroups: ", countAndPrintInGroups(a));
}
