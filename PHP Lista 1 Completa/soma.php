<?php

$n = $_GET["n"];

$total = 0;

for($i=0;$i<=$n;$i++){
$total += $i;
}

echo "<h1>Resultado</h1>";

echo $total;

?>

<br><br>

<a href="index8.php">Voltar</a>