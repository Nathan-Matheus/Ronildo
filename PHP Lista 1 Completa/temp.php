<?php
$n1 = $_GET["n1"];
$temp = $_GET["temp"];
if($temp=="C") {
    $CF = ($n1 * 9 / 5) + 32;
 }
else {
    $FC = 5/9 * ($n1-32);


}

?>

<!DOCTYPE html>

<html lang="pt-br">

<head>

<meta charset="UTF-8">

<title>Resultado da Conversão (GET)</title>

</head>

<body>

<h1>Conversão</h1>

<p>Resultado: <?php if($temp=="C") {
    echo "Temperatura em Farenheit: " . $CF;
}
else {
    echo "Temperatura em Celcius: " . $FC;
} 
?></p>


<a href="index2.php">Voltar</a>

</body>

</html>