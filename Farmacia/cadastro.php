<?php

require_once "config/conexao.php";

/* Verifica se o formulário foi enviado */
if(isset($_POST['cadastrar'])) {

    $nome = $_POST['nome'];
    $fabricante = $_POST['fabricante'];
    $preco = $_POST['preco'];
    $estoque = $_POST['estoque'];

    /* Prepare evita SQL Injection */
    $sql = $conexao->prepare(
        "INSERT INTO produtos
        (nome, fabricante, preco, estoque)
        VALUES
        (:nome, :fabricante, :preco, :estoque)"
    );

    $sql->execute([
        ':nome' => $nome,
        ':fabricante' => $fabricante,
        ':preco' => $preco,
        ':estoque' => $estoque
    ]);

    header("Location: index.php");
    exit;
}

require_once "includes/header.php";
?>
<form method="POST">

    <!-- Campo nome -->
    <input
        type="text"
        name="nome"
        placeholder="Nome do Produto"
        required
    >

    <!-- Campo fabricante -->
    <input
        type="text"
        name="fabricante"
        placeholder="Fabricante"
        required
    >

    <!-- Campo preço -->
    <input
        type="number"
        step="0.01"
        name="preco"
        placeholder="Preço"
        required
    >

    <!-- Campo estoque -->
    <input
        type="number"
        name="estoque"
        placeholder="Estoque"
        required
    >

    <!-- Botão -->
    <button type="submit" name="cadastrar">
        Cadastrar Produto
    </button>
</form>
<?php require_once "includes/footer.php"; ?>
