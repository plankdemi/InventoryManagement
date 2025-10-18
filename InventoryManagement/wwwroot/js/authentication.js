
    const loginView = document.getElementById("loginView");
    const registerView = document.getElementById("registerView");
    const modalTitle = document.getElementById("authModalLabel");
    const showRegisterBtn = document.getElementById("showRegister");
    const showLoginBtn = document.getElementById("showLogin");
    const loginForm = document.getElementById("loginForm");
    const registerForm = document.getElementById("registerForm");

    
    if (showRegisterBtn) {
        showRegisterBtn.addEventListener("click", (e) => {
            e.preventDefault();
            loginView.classList.add("d-none");
            registerView.classList.remove("d-none");
            modalTitle.textContent = "Register";
        });
    }

   
    if (showLoginBtn) {
        showLoginBtn.addEventListener("click", (e) => {
            e.preventDefault();
            registerView.classList.add("d-none");
            loginView.classList.remove("d-none");
            modalTitle.textContent = "Login";
        });
    }

    
    if (loginForm) {
        loginForm.addEventListener("submit", async (e) => {
            e.preventDefault();
            const formData = new FormData(loginForm);

            const response = await fetch("/Login", {
                method: "POST",
                body: formData
            });

            if (response.ok) {
                window.location.reload();
            } else {
                alert("Invalid username or password.");
            }
        });
    }

  
    if (registerForm) {
        registerForm.addEventListener("submit", async (e) => {
            e.preventDefault();
            const formData = new FormData(registerForm);

            const response = await fetch("/Register", {
                method: "POST",
                body: formData
            });

            if (response.ok) {
                alert("Registration successful! Please log in.");
                
                registerView.classList.add("d-none");
                loginView.classList.remove("d-none");
                modalTitle.textContent = "Login";
            } else {
                alert("Registration failed. Please try again.");
            }
        });
    }

