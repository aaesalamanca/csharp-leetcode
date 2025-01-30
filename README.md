# Leet Sharp

Este repositorio contiene las soluciones para los problemas de [LeetCode](https://leetcode.com/) en C#. Estas se encuentran en el proyecto [/src/LeetSharp.Solutions.Library/](/src/LeetSharp.Solutions.Library/) y cada una de ellas presenta tanto una interfaz para el problema como la implementación (o implementaciones si puede haber varias soluciones) de dicha interfaz.

Además del proyecto de soluciones, también hay otros dos proyectos:

- [/src/LeetSharp.Benchmarks.Console/](/src/LeetSharp.Benchmarks.Console/) - Proyecto de consola que ejecuta _benchmarks_ para las soluciones a los problemas. Si hay varias para el mismo problema, permite comparar los tiempos de ejecución y la asignación de memoria entre estas.
- [/test/LeetSharp.Solutions.Library.UnitTest/](/test/LeetSharp.Solutions.Library.UnitTest/) - Proyecto de pruebas unitarias para cada solución o conjunto de estas utilizando los casos de prueba iniciales proporcionados por [LeetCode](https://leetcode.com/). También incorpora aquellos casos de prueba que resultaron en un error en las pruebas de [LeetCode](https://leetcode.com/).

Para comprobar el resultado de las pruebas unitarias, sitúese en la raíz del repositorio y ejecute:

```zsh
dotnet test
```

Para realizar un _benchmark_, escriba el nombre de la clase que contiene el que quiere llevar a cabo en [/src/LeetSharp.Benchmarks.Console/Program.cs](/src/LeetSharp.Benchmarks.Console/Program.cs), entre `<>`, sitúese en la raíz del repositorio y ejecute:

```zsh
dotnet run -c Release --project src/LeetSharp.Benchmarks.Console/
```

## Relación de problemas y soluciones

| Problema                                                                  | Dificultad | Solución                                                                                                                                                           | Complejidad                                                                                                                                                   |
| ------------------------------------------------------------------------- | ---------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [1. Two Sum](https://leetcode.com/problems/two-sum/)                      | Fácil      | [/src/LeetSharp.Solutions.Library/Implementations/Problem0001TwoSum/](/src/LeetSharp.Solutions.Library/Implementations/Problem0001TwoSum/)                         | **BruteForce** - Tiempo: O(nˆ2) - Espacio: O(1) - **TwoPassDictionary** - Tiempo: O(n) - Espacio: O(n) - **OnePassDictionary** - Tiempo: O(n) - Espacio: O(n) |
| [13. Roman to Integer](https://leetcode.com/problems/roman-to-integer/)   | Fácil      | [/src/LeetSharp.Solutions.Library/Implementations/Problem0013RomanToInteger.cs](/src/LeetSharp.Solutions.Library/Implementations/Problem0013RomanToInteger.cs)     | Tiempo: O(n) - Espacio: O(n)                                                                                                                                  |
| [20. Valid Parentheses](https://leetcode.com/problems/valid-parentheses/) | Fácil      | [/src/LeetSharp.Solutions.Library/Implementations/Problem0020ValidParentheses.cs](/src/LeetSharp.Solutions.Library/Implementations/Problem0020ValidParentheses.cs) | Tiempo: O(n) - Espacio: O(n)                                                                                                                                  |
| [2235. Add Two Integers](https://leetcode.com/problems/add-two-integers/) | Fácil      | [/src/LeetSharp.Solutions.Library/Implementations/Problem2235AddTwoIntegers.cs](/src/LeetSharp.Solutions.Library/Implementations/Problem2235AddTwoIntegers.cs)     | Tiempo: O(1) - Espacio: O(1)                                                                                                                                  |
