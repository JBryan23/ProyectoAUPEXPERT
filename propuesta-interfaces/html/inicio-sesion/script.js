function togglePassword() {
    const passwordInput = document.getElementById("password");
    const showPasswordBtn = document.querySelector(".show-password");
    
    if (passwordInput.type === "password") {
        passwordInput.type = "text";
        showPasswordBtn.textContent = "Ocultar";
    } else {
        passwordInput.type = "password";
        showPasswordBtn.textContent = "Mostrar";
    }
}



