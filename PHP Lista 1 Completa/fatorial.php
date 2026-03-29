<?php

function fatorial($n){

$fat = 1;

for($i=1;$i<=$n;$i++){
$fat = $fat * $i;
}

return $fat;
}

$n1 = $_GET["n1"];
$n2 = $_GET["n2"];
$n3 = $_GET["n3"];
$n4 = $_GET["n4"];
$n5 = $_GET["n5"];

$soma = fatorial($n1)+fatorial($n2)+fatorial($n3)+fatorial($n4)+fatorial($n5);

?>

<h1>Resultado</h1>

<p>Soma dos fatoriais: <?php echo $soma; ?></p>

<a href="index5.php">Voltar</a>