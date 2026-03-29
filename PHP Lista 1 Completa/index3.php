<!--
Data: 02/03/2026
Autor: Nathan Nabas e Matheus Theodoro
Objetivo:

Exercício 3 - Calculadora Aritmética
Faça um programa que leia dois números e um operador ("+", "-", "*" ou "/").
O programa deve mostrar o resultado da operação.
-->

<!DOCTYPE html>
<html lang="pt-br">
<head>
<meta charset="UTF-8">
<title>Calculadora (GET)</title>
</head>

<body>

<h1>Calculadora Simples</h1>

<p>Digite dois números e escolha o operador da conta.</p>

<form action="calculadora.php" method="get">

<p>Primeiro número:</p>
<input type="number" name="n1" required>

<p>Operador (+ - * /):</p>
<input type="text" name="op" required>

<p>Segundo número:</p>
<input type="number" name="n2" required>

<br><br>

<input type="submit" value="Calcular">

</form>
<a href="main.html">Voltar para Menu Principal</a>
</body>
</html>