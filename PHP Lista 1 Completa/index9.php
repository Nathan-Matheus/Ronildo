<!--
Data: 02/03/2026
Autor: Nathan Nabas e Matheus Theodoro
Objetivo:

Exercício 9 - Média Aritmética com Função
Crie uma função:

function media($v)

Que receba uma lista de números reais e retorne a média aritmética.
-->

<!DOCTYPE html>
<html lang="pt-br">
<head>
<meta charset="UTF-8">
<title>Média Aritmética</title>
</head>

<body>

<h1>Cálculo de Média</h1>

<p>Digite alguns números para calcular a média aritmética.</p>

<form action="media.php" method="get">

<p>Número 1:</p>
<input type="number" name="n1" step="any" required>

<p>Número 2:</p>
<input type="number" name="n2" step="any" required>

<p>Número 3:</p>
<input type="number" name="n3" step="any" required>

<p>Número 4:</p>
<input type="number" name="n4" step="any" required>

<p>Número 5:</p>
<input type="number" name="n5" step="any" required>

<br><br>

<input type="submit" value="Calcular média">

</form>
<a href="main.html">Voltar para Menu Principal</a>
</body>
</html>