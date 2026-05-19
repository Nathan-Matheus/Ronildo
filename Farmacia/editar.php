<?php

require_once "config/conexao.php";

/* Verifica se o ID existe */
if(!isset($_GET['id'])) {

    header("Location: index.php");

    exit;
}

$id = $_GET['id'];

/* Busca os dados atuais */
$sql = $conexao->prepare(
    "SELECT * FROM produtos WHERE id = :id"
);

$sql->execute([
    ':id' => $id
]);

$produto = $sql->fetch(PDO::FETCH_ASSOC);

/* Caso produto não exista */
if(!$produto) {

    header("Location: index.php");

    exit;
}

/* Atualização */
if(isset($_POST['editar'])) {

    $nome = $_POST['nome'];

    $fabricante = $_POST['fabricante'];

    $preco = $_POST['preco'];

    $estoque = $_POST['estoque'];

    $editar = $conexao->prepare(
        "UPDATE produtos

        SET
            nome = :nome,
            fabricante = :fabricante,
            preco = :preco,
            estoque = :estoque

        WHERE id = :id"
    );

    $editar->execute([
        ':nome' => $nome,
        ':fabricante' => $fabricante,
        ':preco' => $preco,
        ':estoque' => $estoque,
        ':id' => $id
    ]);

    header("Location: index.php");

    exit;
}

require_once "includes/header.php";
?>

<form method="POST">

    <!-- Nome -->
    <input
        type="text"
        name="nome"
        value="<?= $produto['nome'] ?>"
        required
    >

    <!-- Fabricante -->
    <input
        type="text"
        name="fabricante"
        value="<?= $produto['fabricante'] ?>"
        required
    >

    <!-- Preço -->
    <input
        type="number"
        step="0.01"
        name="preco"
        value="<?= $produto['preco'] ?>"
        required
    >

    <!-- Estoque -->
    <input
        type="number"
        name="estoque"
        value="<?= $produto['estoque'] ?>"
        required
    >

    <!-- Botão -->
    <button type="submit" name="editar">
        Salvar Alterações
    </button>

</form>

<?php require_once "includes/footer.php"; ?>
