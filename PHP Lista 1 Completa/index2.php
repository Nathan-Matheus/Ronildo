<!--
Data: 02/03/2026
Autor: Nathan Nabas e Matheus Theodoro
Objetivo:

Exercício 2 - Conversão de Temperatura
Faça um programa que leia um caractere "F" ou "C", indicando se o valor informado está em Fahrenheit ou Celsius.
Depois, o programa deve converter para a outra unidade.

Fórmula: C = 5/9 × (F − 32)
-->

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Conversão de Temperatura (GET)</title>
</head>
<body>

    <h1>Conversão de Temperatura </h1>
    
    <form action="temp.php" method="get">

        <label>Digite a unidade de medida de temperatura desejada(C ou F):</label>
        <input type="text" name="temp" step="any" required>
<br><br>

<label>Digite um número, para a temperatura:</label>
<input type="number" name="n1" step="any" required>
        <input type="submit" value="">

    </form>
<a href="main.html">Voltar para Menu Principal</a>
</body>
</html>

