# LeetCode C# Problems

Las librerías de este repositorio contienen las soluciones para los problemas de [LeetCode](https://leetcode.com/). Todas ellas se encuentran en el directorio [/src](/src).

Además de las soluciones, el repositorio también incluye:

- [/src/Benchmarks.Console](/src/Benchmarks.Console) - Proyecto de consola que ejecuta _benchmarks_ para aquellos problemas que presentan varias soluciones. De este modo, se pueden comparar los tiempos de ejecución entre soluciones.
- [/test](/test) - Proyectos de pruebas unitarias para cada solución o conjunto de estas utilizando los casos de prueba iniciales proporcionados por [LeetCode](https://leetcode.com). También incluye aquellos casos de prueba que dieron lugar a error en la solución prevista.

## Ejecutar pruebas unitarias y _benchmarks_

Para ejecutar las pruebas unitarias, sitúate en la raíz del repositorio y ejecuta:

```bash
$ dotnet test
```

Para ejecutar un _benchmark_, escribe el nombre de la clase que contiene el que quieres ejecutar en [/src/Benchmarks.Console/Program.cs](/src/Benchmarks.Console/Program.cs), entre `<>`, sitúate en la raíz del repositorio y ejecuta:

```bash
$ dotnet run -c Release --project src/Benchmarks.Console
```

## Relación de problemas y soluciones

| Proyecto                                                                               | Solución                                                                             |
| -------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------ |
| [/src/Problem0001.TwoSum.Library](/src/Problem0001.TwoSum.Library)                     | [1. Two Sum](https://leetcode.com/problems/two-sum/description/)                     |
| [/src/Problem0009.PalindromeNumber.Library](/src/Problem0009.PalindromeNumber.Library) | [9. Palindrome Number](https://leetcode.com/problems/palindrome-number/description/) |
