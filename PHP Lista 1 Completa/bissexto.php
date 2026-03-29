<?php

$ano = $_GET["ano"];

if(($ano % 400 == 0) || ($ano % 4 == 0 && $ano % 100 != 0)){
echo "O ano é bissexto";
}else{
echo "O ano não é bissexto";
}

?>

<br><br>

<a href="index10.php">Voltar</a>