// Seleção de elementos
const mainImage = document.querySelector('.product-gallery > img');
const thumbnails = document.querySelectorAll('.gallery-thumbnails img');
const addToCartBtn = document.querySelector('.add-to-cart');
const addToWishlistBtn = document.querySelector('.add-to-wishlist');
const quantityInput = document.querySelector('#quantity');
const priceElement = document.querySelector('.price');
const variationSelect = document.querySelector('#faces');

//trocar pelas miniaturas e atualiza a variação
const variationMap = {
    'img/Camisa_furia.jpg': 'camiasa-furia',
    'img/Logo_furia.jpg': 'logo-furia',
    'img/Costas_camisa_Furia.jpg': 'costas'
};

thumbnails.forEach(thumb => {
    thumb.addEventListener('click', () => {
        mainImage.src = thumb.src; // Troca imagem principal
        const optionValue = variationMap[thumb.getAttribute('src')];
        if (optionValue) {
            variationSelect.value = optionValue; // Muda select
        }
    });
});

// Mudar select -> muda imagem
variationSelect.addEventListener('change', () => {
    const selectedValue = variationSelect.value;
    if (variationMap[selectedValue]) {
        mainImage.src = variationMap[selectedValue];
    }
});

// Função para formatar valor em R$
function formatCurrency(value) {
    return value.toLocaleString('pt-BR', { style: 'currency', currency: 'BRL' });
}

// Adicionar produto ao carrinho
addToCartBtn.addEventListener('click', () => {
    const quantity = parseInt(quantityInput.value);
    const priceText = priceElement.textContent.replace('R$', '').replace('.', '').replace(',', '.').trim();
    const price = parseFloat(priceText);
    const total = quantity * price;

    alert(`✅ Produto adicionado ao carrinho!\nQuantidade: ${quantity}\nTotal: ${formatCurrency(total)}`);
});

// 4. Adicionar produto aos favoritos
addToWishlistBtn.addEventListener('click', () => {
    alert(`❤️ Produto adicionado aos favoritos!`);
});

