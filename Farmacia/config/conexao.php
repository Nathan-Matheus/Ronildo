<?php

/* Conexão principal com o banco usando PDO */
$host = "localhost";
$banco = "farmacia";
$usuario = "root";
$senha = "";

try {

    /* PDO segurança e organização das consultas */
    $conexao = new PDO(
        "mysql:host=$host;dbname=$banco;charset=utf8",
        $usuario,
        $senha
    );

    $conexao->setAttribute(
        PDO::ATTR_ERRMODE,
        PDO::ERRMODE_EXCEPTION
    );

} catch(PDOException $erro) {

    die("Erro na conexão: " . $erro->getMessage());
}
