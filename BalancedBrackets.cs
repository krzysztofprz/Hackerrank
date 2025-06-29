namespace ConsoleApp1
{
    // https://www.hackerrank.com/challenges/balanced-brackets/problem
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs = new()
            {
                "{[()]}",
                "{[(])}",
                "{{[[(())]]}}",
                "[]{}()",
                "({(){}[]})[]",
                "(){([])]}",
                "",
                "()[",
                "[]][{]{(({{)[})(}[[))}{}){[{]}{})()[{}]{{]]]){{}){({(}](({[{[{)]{)}}}({[)}}([{{]]({{",
                "[]()([{}])[]{}[]",
                ")}{){(]{)([)}{)]())[(})[]]))({[[[)}[((]](])][({[]())",
                "{}()[[((()(({{[]}{}{{[]}}{}}))))]]{{{{([{{{{}}}}])}}}}",
                "{{[()()]}()}(())()()[[[]]][{[]()}(())]",
                "[}}{}]{[{)}[{(([)(([)(](}(]([}(()[)])}[{[{{](([]()[[[])([}}])){}(][)]{(]{)]]()({}}}(((]{]]",
                "(}{(()[][[){{}{{[}][]{{{{[{{[](}{)}](}}()]}(}(}}]}[](]]){{{()}({[[}}{{[]}(]}{(]{}}[()(}]{[[]{){{",
                "{}{[[[[[][]]]]({})]}[[]]",
                ")}}}){}{](]}){}((]]{][)]({[{)])[{])}(]]][)[{[}()[}])}}}]}}})]))[",
                "))())][})[{)]]})[({}[){)([])[}{}]{])({]{}}[(({({])]}",
                "[{(((([]))({{}{}[]{{()}[({[{}[]]}[][([])[]]{})[{}(){{[{}({}{{}[]}{({})}{((({})))})(){}]}}]]}})))}]",
                "{[])[))[)}}]}([}()}{{]}[)}{)}[}}]])}((((])[)[[()[{({](}]",
                "{(){{}}}{}{{({})}}{({(){}})}"
            };

            foreach (var input in inputs)
            {
                Console.WriteLine($"Input: '{input}'. {nameof(IsBalanced)}: {IsBalanced(input)}");
            }
        }

        static bool IsBalanced(string input)
        {
            if (string.IsNullOrWhiteSpace(input)
                || input.Length % 2 != 0)
            {
                return false;
            }

            Stack<char> stack = new();

            // SIMPLIFIED
            //Dictionary<char, char> dict = new()
            //{
            //    { '(', ')' },
            //    { '[', ']' },
            //    { '{', '}' },
            //};


            //foreach (var ch in input)
            //{
            //    if (dict.ContainsKey(ch))
            //    {
            //        stack.Push(dict[ch]);
            //    }
            //    else
            //    {
            //        if (stack.Count == 0 || ch != stack.Pop())
            //        {
            //            return false;
            //        }
            //    }
            //}

            //return stack.Count == 0;

            for (int i = 0; i < input.Length; i++)
            {
                var ch = input[i];

                if (ch is '(' or '[' or '{')
                {
                    stack.Push(ch);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    var pop = stack.Pop();

                    switch (ch)
                    {
                        case ')' when pop == '(':
                        case ']' when pop == '[':
                        case '}' when pop == '{':
                            continue;
                        default:
                            return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
