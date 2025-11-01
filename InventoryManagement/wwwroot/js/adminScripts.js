let allUsers = [];

document.addEventListener("DOMContentLoaded", () => {
    loadUsers();


});

async function loadUsers(){
    
    const tBody = document.getElementById("users-body")
    tBody.innerHTML = "<tr><td colspan='5'>Loading...</td></tr>";
    
    
    const res = await fetch("Admin/GetAllUsers/")
    allUsers = await res.json()
    
    
    renderUsers(allUsers, tBody)
    
    
}

function renderUsers(users, body){
    if(!users || users.length === 0) {
        body.innerHTML = "<tr><td colspan='5'>No registered users found.</td></tr>";
        return;
    }
    body.innerHTML = users.map((user,index) =>

        `
    <tr>
    
    
    <td><input class="form-check-input mt-0 row-check" type="checkbox" data-id="${user.id}"></td>
    <td>${userStatus(user.userStatus)}</td>
    <td>${user.username}</td>
    <td>${user.inventoriesCreated}</td>
    <td>${user.isAdmin ? "Yes" : "No"}</td>
    <td>${user.createdAt ? new Date(user.createdAt).toLocaleString() : ""}</td>
    </tr>
`).join("");
}

function userStatus(status){
    
   
    switch (status) {
        case 0:
            return `<span class="badge bg-warning text-dark">UNVERIFIED</span>`
        case 1:
            return `<span class="badge bg-success">VERIFIED</span>`
        case 2:
            return `<span class="badge bg-danger">BLOCKED</span>`
    }


}

