<?php

require_once 'config/conexao.php';
require_once 'includes/header.php';

/* Busca para todos os produtos cadastrados */
$sql = $pdo->prepare("SELECT * FROM produtos");
$sql->execute();

$produtos = $sql->fetchAll(PDO::FETCH_ASSOC);

/* Contagem para o painel */
$total = count($produtos);

?>

<!-- Banner / Apresentação -->
<div class="topo">

    <h2>📦 Painel de Produtos - FarmaX</h2>

    <p>Total de itens cadastrados: <strong><?= $total ?></strong></p>

</div>

<!-- Listagem de produtos -->
<div class="cards">

<?php foreach($produtos as $produto): ?>

    <div class="card">

        <!-- Nome dos produtos (pós cadastro) -->
        <h3><?= $produto['nome']; ?></h3>

        <!-- Dados dos produtos (pós cadastro) -->
        <p><strong>Fabricante:</strong> <?= $produto['fabricante']; ?></p>
        <p><strong>Preço:</strong> R$ <?= $produto['preco']; ?></p>
        <p><strong>Estoque:</strong> <?= $produto['estoque']; ?></p>

        <!-- Ações -->
        <div class="acoes">

            <a class="btn editar" href="editar.php?id=<?= $produto['id']; ?>">
                ✏ Editar
            </a>

            <a class="btn excluir"
               href="excluir.php?id=<?= $produto['id']; ?>"
               onclick="return confirm('Deseja excluir este produto?')">
                🗑 Excluir
            </a>

        </div>

    </div>

<?php endforeach; ?>

</div>

<?php require_once 'includes/footer.php'; ?>
