<?php

require_once "config/conexao.php";

$id = $_GET['id'];

/* Busca os dados atuais do produto */
$sql = $conexao->prepare("SELECT * FROM produtos WHERE id = :id");
$sql->execute([':id' => $id]);

$produto = $sql->fetch(PDO::FETCH_ASSOC);

/* Atualização do produto */
if(isset($_POST['editar'])) {

    $nome = $_POST['nome'];
    $fabricante = $_POST['fabricante'];
    $preco = $_POST['preco'];
    $estoque = $_POST['estoque'];

    $editar = $conexao->prepare(
        "UPDATE produtos
        SET nome = :nome,
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
}

require_once "includes/header.php";
?>

<form method="POST">

    <!-- Os values ajudam a mostrar os dados atuais do produto -->
    <input type="text" name="nome" value="<?= $produto['nome'] ?>">

    <input type="text" name="fabricante" value="<?= $produto['fabricante'] ?>">

    <input type="number" step="0.01" name="preco" value="<?= $produto['preco'] ?>">

    <input type="number" name="estoque" value="<?= $produto['estoque'] ?>">

    <button type="submit" name="editar">
        Salvar Alterações
    </button>

</form>

<?php require_once "includes/footer.php"; ?>
