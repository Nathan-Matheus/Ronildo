<?php
$n1 = $_GET["n1"];

?>
<!DOCTYPE html>

<html lang="pt-br">

<head>
<meta charset="UTF-8">
<title>Resultado (GET)</title>
</head>
<body>

<h1> Resultado </h1>
<p> <?php if ( $n1 > 100 && $n1 < 200 ){
    echo "o número: ", $n1 ," está dentro do intervalo";}

     else{
    echo "o número: ", $n1 ," não esta no intervalo";  }?></p>

<a href="index.php">Voltar</a>

</body>

</html>
