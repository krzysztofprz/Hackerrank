const arr = [
  "This is a standard text.", // This is a standard text!
  "This is a little dramatic text!", // This is a little dramatic text!!
  "Warning! This is a regular dramatic text!!", // Warning!! This is a regular dramatic text!!!
  "Attention!!! Read carefully this text! This is a dramatic text!!!", // Attention!!!! Read carefully this text!! This is a dramatic text!!!!
];

function dramatize(input: string) {
  const exclamationMark = "!";
  let i = 0;

  let dramatizedInput = "";

  for (i; i < input.length; i++) {
    const next = i + 1;
    dramatizedInput += input[i];

    if (input[i] === exclamationMark && next <= input.length && input[next] !== exclamationMark) {
      dramatizedInput += exclamationMark;
    }
  }

  return dramatizedInput.replaceAll(".", exclamationMark);
}

for (let i = 0; i < arr.length; i++) {
  console.log(dramatize(arr[i]));
}
