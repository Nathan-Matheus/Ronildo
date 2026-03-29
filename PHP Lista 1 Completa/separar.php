<?php

$positivos = [];
$negativos = [];

for($i=1;$i<=8;$i++){

$num = $_GET["n".$i];

if($num >= 0){
$positivos[] = $num;
}else{
$negativos[] = $num;
}

}

echo "<h2>Positivos</h2>";

foreach($positivos as $p){
echo $p." ";
}

echo "<h2>Negativos</h2>";

foreach($negativos as $n){
echo $n." ";
}

?>

<br><br>

<a href="index7.php">Voltar</a>