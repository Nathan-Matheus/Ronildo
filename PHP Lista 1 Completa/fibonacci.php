<?php

$n = $_GET["n"];

$a = 0;
$b = 1;

echo "<h1>Sequência</h1>";

echo $a." ".$b." ";

for($i=3;$i<=$n;$i++){

$c = $a + $b;

echo $c." ";

$a = $b;
$b = $c;

}

?>

<br><br>

<a href="index6.php">Voltar</a>