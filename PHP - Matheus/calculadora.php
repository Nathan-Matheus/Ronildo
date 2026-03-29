<?php

$n1 = $_GET["n1"];
$n2 = $_GET["n2"];
$op = $_GET["op"];

if($op == "+"){
    $resultado = $n1 + $n2;
}
elseif($op == "-"){
    $resultado = $n1 - $n2;
}
elseif($op == "*"){
    $resultado = $n1 * $n2;
}
elseif($op == "/"){
    $resultado = $n1 / $n2;
}
else{
    $resultado = "Operador inválido";
}

?>

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Resultado</title>
</head>

<body>

<h1>Resultado</h1>

<p>Resultado da operação: <?php echo $resultado; ?></p>

<a href="index3.php">Voltar</a>

</body>
</html>