var hamburguer = document.querySelector(".hamburguer");

hamburguer.addEventListener("click", function () {
    document.querySelector(".sidebar").classList.toggle("show-menu");
    document.querySelector(".hamburguer").classList.toggle("show-menu");
});

