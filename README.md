# CSharp Leetcode

Este repositorio contiene las soluciones para los problemas de [LeetCode](https://leetcode.com/) en C#. Estas se encuentran en el proyecto [/src/CSharpLeetCode.Solutions.Library/](/src/CSharpLeetCode.Solutions.Library/) y cada una de ellas presenta tanto una interfaz para el problema como la implementación (o implementaciones si puede haber varias soluciones) de dicha interfaz.

Además del proyecto de soluciones, también hay otros dos proyectos:

- [/src/CSharpLeetCode.Benchmarks.Console/](/src/CSharpLeetCode.Benchmarks.Console/) - Proyecto de consola que ejecuta _benchmarks_ para las soluciones a los problemas. Si hay varias para el mismo problema, permite comparar los tiempos de ejecución y la asignación de memoria entre estas.
- [/test/CSharpLeetCode.Solutions.Library.UnitTest/](/test/CSharpLeetCode.Solutions.Library.UnitTest/) - Proyecto de pruebas unitarias para cada solución o conjunto de estas utilizando los casos de prueba iniciales proporcionados por [LeetCode](https://leetcode.com/). También incorpora aquellos casos de prueba que resultaron en un error en las pruebas de [LeetCode](https://leetcode.com/).

Para comprobar el resultado de las pruebas unitarias, sitúese en la raíz del repositorio y ejecute:

```zsh
dotnet test
```

Para realizar un _benchmark_, escriba el nombre de la clase que contiene el que quiere llevar a cabo en [/src/CSharpLeetCode.Benchmarks.Console/Program.cs](/src/CSharpLeetCode.Benchmarks.Console/Program.cs), entre `<>`, sitúese en la raíz del repositorio y ejecute:

```zsh
dotnet run -c Release --project src/CSharpLeetCode.Benchmarks.Console/
```

## Relación de problemas y soluciones

| Problema                                                                  | Solución                                                                                                                                                                     |
| ------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [1. Two Sum](https://leetcode.com/problems/two-sum/)                      | [/src/CSharpLeetCode.Solutions.Library/Implementations/Problem0001TwoSum/](/src/CSharpLeetCode.Solutions.Library/Implementations/Problem0001TwoSum/)                         |
| [13. Roman to Integer](https://leetcode.com/problems/roman-to-integer/)   | [/src/CSharpLeetCode.Solutions.Library/Implementations/Problem0013RomanToInteger.cs](/src/CSharpLeetCode.Solutions.Library/Implementations/Problem0013RomanToInteger.cs)     |
| [20. Valid Parentheses](https://leetcode.com/problems/valid-parentheses/) | [/src/CSharpLeetCode.Solutions.Library/Implementations/Problem0020ValidParentheses.cs](/src/CSharpLeetCode.Solutions.Library/Implementations/Problem0020ValidParentheses.cs) |
| [2235. Add Two Integers](https://leetcode.com/problems/add-two-integers/) | [/src/CSharpLeetCode.Solutions.Library/Implementations/Problem2235AddTwoIntegers.cs](/src/CSharpLeetCode.Solutions.Library/Implementations/Problem2235AddTwoIntegers.cs)     |
