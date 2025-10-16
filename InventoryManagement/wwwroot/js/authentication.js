
    const loginView = document.getElementById("loginView");
    const registerView = document.getElementById("registerView");
    const modalTitle = document.getElementById("authModalLabel");

    document.addEventListener("click", (e) => {
        
        if (e.target.id === "showRegister") {
            e.preventDefault();
            loginView.classList.add("d-none");
            registerView.classList.remove("d-none");
            modalTitle.textContent = "Register";
        }

        
        if (e.target.id === "showLogin") {
            e.preventDefault();
            registerView.classList.add("d-none");
            loginView.classList.remove("d-none");
            modalTitle.textContent = "Login";
        }
    });

