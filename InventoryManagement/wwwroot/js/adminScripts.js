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
    <td><input class="form-check-input mt-0" type="checkbox" value="" aria-label="Checkbox for user selection" id="checkbox ${index}"></td>
    <td>${user.username}</td>
      <td>${user.inventoriesCreated}</td>
      <td>${user.isAdmin ? "Yes" : "No"}</td>
      <td>${user.createdAt ? new Date(user.createdAt).toLocaleString() : ""}</td>
`).join("");
}