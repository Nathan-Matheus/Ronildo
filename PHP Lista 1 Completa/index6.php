<!--
Data: 02/03/2026
Autor: Nathan Nabas e Matheus Theodoro
Objetivo:

Exercício 6 - Série de Fibonacci
Leia um número n e mostre os n primeiros termos da sequência de Fibonacci.

Exemplo:
n = 12
Resultado:
0 1 1 2 3 5 8 13 21 34 55 89
-->

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Fibonacci</title>
</head>

<body>

<h1>Série de Fibonacci</h1>

<p>Digite quantos números da sequência você quer ver.</p>

<form action="fibonacci.php" method="get">

<input type="number" name="n" required>

<br><br>

<input type="submit" value="Mostrar sequência">

</form>
<a href="main.html">Voltar para Menu Principal</a>
</body>
</html>