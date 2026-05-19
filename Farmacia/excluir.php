<?php

require_once "config/conexao.php";

/* Verifica se o ID existe */
if(!isset($_GET['id'])) {
    header("Location: index.php");
    exit;
}
$id = $_GET['id'];
/* Exclusão */
$sql = $conexao->prepare(
    "DELETE FROM produtos WHERE id = :id"
);
$sql->execute([
    ':id' => $id
]);
header("Location: index.php");
exit;
