<?php 
$n1 = $_GET["n1"];
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Triângulo</title>
</head>
<body>
   <h1>O triângulo:</h1>
    <?php 
  for ($i = 1; $i <= $n1; $i++) {

     for ($m = 1; $m <= $i; $m++) {
        echo $m . " ";
     }
echo "<br>";
  } 
    
    ?>
<a href="index4.php">Voltar</a>
</body>
</html>