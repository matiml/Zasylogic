const btnAbrirModal = document.querySelector("#open_modal");

const btnCerrarModal = document.querySelector("#close_modal");

const modal = document.querySelector("#modal");



btnAbrirModal.addEventListener("click", (e) => {
    e.preventDefault();
    modal.showModal();
})

btnCerrarModal.addEventListener("click", () => {
    modal.close();
})










