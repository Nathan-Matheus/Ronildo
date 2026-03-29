<?php

function media($v){

$soma = 0;

foreach($v as $n){
$soma += $n;
}

return $soma / count($v);

}

$n1 = $_GET["n1"];
$n2 = $_GET["n2"];
$n3 = $_GET["n3"];
$n4 = $_GET["n4"];
$n5 = $_GET["n5"];

$lista = [$n1,$n2,$n3,$n4,$n5];

$resultado = media($lista);

?>

<h1>Resultado</h1>

<p>Média dos números: <?php echo $resultado; ?></p>

<a href="index9.php">Voltar</a>