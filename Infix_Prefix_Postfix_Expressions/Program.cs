using System;
using System.Collections.Generic;
using System.Text;

//.NET Framework 4.8.1
namespace Infix_Prefix_Postfix_Expressions {
    class Program {
        static void Main(string[] args) {
            #region test speed for solve infix string
            string strInfix = "    (  200     +    4637   )  *   51   -   (   32   ^   2    -    2    )   *   4000     ";
            Console.WriteLine("Infix string: " + strInfix);
            Console.WriteLine("Postfix string: " + ConvertInfixToPostfix(strInfix));
            Console.WriteLine("Evaluate postfix: " + EvaluatePostfix(ConvertInfixToPostfix(strInfix)));
            #endregion

            Console.ReadKey();
        }
        #region solve infix string
        public static int Priority(char cOperator) {
            if (cOperator == '+' || cOperator == '-')
                return 1;
            if (cOperator == '*' || cOperator == '/')
                return 2;
            if (cOperator == '^')
                return 3;
            return 0;
        }
        /// <summary>
        /// Speed test: 120-150 ticks
        /// </summary>
        /// <param name="strInfix"></param>
        /// <returns></returns>
        public static string ConvertInfixToPostfix(string strInfix) {
            strInfix = strInfix.Trim();
            Stack<char> stackOperator = new Stack<char>();
            StringBuilder strPostfix = new StringBuilder("");
            for (int i = 0; i < strInfix.Length; i++) {
                for (; strInfix[i] == ' '; i++) ;
                if (char.IsLetterOrDigit(strInfix[i])) {
                    for (; char.IsLetterOrDigit(strInfix[i]);) {
                        strPostfix.Append(strInfix[i]);
                        if (!(++i < strInfix.Length)) break;
                    }
                    strPostfix.Append(' ');
                    i--;
                }
                else if (strInfix[i] == '(')
                    stackOperator.Push('(');
                else if (strInfix[i] == ')') {
                    while (stackOperator.Peek() != '(')
                        strPostfix.Append(stackOperator.Pop()).Append(' ');
                    stackOperator.Pop();
                }
                else {
                    while (!(stackOperator.Count == 0) && Priority(strInfix[i]) <= Priority(stackOperator.Peek()))
                        strPostfix.Append(stackOperator.Pop()).Append(' ');
                    stackOperator.Push(strInfix[i]);
                }
            }
            while (!(stackOperator.Count == 0))
                strPostfix.Append(stackOperator.Pop()).Append(' ');
            return strPostfix.Remove(strPostfix.Length - 1, 1).ToString();
        }
        /// <summary>
        /// Speed test: 20-50 ticks
        /// </summary>
        /// <param name="strPostfix"></param>
        /// <returns></returns>
        public static double EvaluatePostfix(string strPostfix) {
            Stack<double> stackTemp = new Stack<double>();
            for (int i = 0; i < strPostfix.Length; i++) {
                for (; strPostfix[i] == ' '; i++) ;
                if (char.IsDigit(strPostfix[i])) {
                    int iNumTemp = 0;
                    for (; char.IsDigit(strPostfix[i]); i++)
                        iNumTemp = iNumTemp * 10 + (strPostfix[i] - '0');
                    stackTemp.Push(iNumTemp);
                }
                else {
                    double od1 = stackTemp.Pop();
                    double od2 = stackTemp.Pop();
                    switch (strPostfix[i]) {
                        case '+': stackTemp.Push(od2 + od1); break;
                        case '-': stackTemp.Push(od2 - od1); break;
                        case '*': stackTemp.Push(od2 * od1); break;
                        case '/': stackTemp.Push(od2 / od1); break;
                        case '^': stackTemp.Push(Math.Pow(od2, od1)); break;
                    }
                }
            }
            return stackTemp.Peek();
        }
        #endregion
    }
}
