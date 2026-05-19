<?php

require_once "config/conexao.php";

/* Busca inicial dos produtos cadastrados */
$sql = $conexao->prepare("SELECT * FROM produtos");
$sql->execute();

$produtos = $sql->fetchAll(PDO::FETCH_ASSOC);

require_once "includes/header.php";
?>

<table>
    <tr>
        <th>Nome</th>
        <th>Fabricante</th>
        <th>Preço</th>
        <th>Estoque</th>
    </tr>

    <?php foreach($produtos as $produto) { ?>

        <!-- Linha criada automaticamente para cada produto -->
        <tr>
            <td><?= $produto['nome'] ?></td>
            <td><?= $produto['fabricante'] ?></td>
            <td>R$ <?= $produto['preco'] ?></td>
            <td><?= $produto['estoque'] ?></td>
        </tr>

    <?php } ?>
</table>

<?php require_once "includes/footer.php"; ?>
