let allUsers = [];
const deleteUserBtn =document.getElementById("remove-users");
const blockUserBtn =document.getElementById("block-users");
const unblockUserBtn =document.getElementById("unblock-users");
const rmAdminUserBtn =document.getElementById("remove-admin");
const addAdminUserBtn =document.getElementById("add-admin");



addAdminUserBtn.addEventListener("click", async(e) => {

    e.preventDefault();
    await Promise.all(
        [...document.querySelectorAll(".row-check:checked")]
            .map(el => fetch(`/Admin/UpdateAdminStatus/${el.dataset.id}?cmd=ADD_ADMIN`, { method: "PUT" }))
    );
    document.getElementById("check-all").indeterminate = false;
    await loadUsers();
})

rmAdminUserBtn.addEventListener("click", async(e) => {
    e.preventDefault();
    await Promise.all(
        [...document.querySelectorAll(".row-check:checked")]
            .map(el => fetch(`/Admin/UpdateAdminStatus/${el.dataset.id}?cmd=RM_ADMIN`, { method: "PUT" }))
    );
    document.getElementById("check-all").indeterminate = false;
    await loadUsers();
})


unblockUserBtn.addEventListener("click", async(e) => {
    e.preventDefault();
    await Promise.all(
        [...document.querySelectorAll(".row-check:checked")]
            .map(el => fetch(`/Admin/UpdateUserStatus/${el.dataset.id}?cmd=UNBLOCK`, { method: "PUT" }))
    );
    document.getElementById("check-all").indeterminate = false;
    await loadUsers();
    
})


blockUserBtn.addEventListener("click", async(e) => {
    e.preventDefault();
    await Promise.all(
        [...document.querySelectorAll(".row-check:checked")]
            .map(el => fetch(`/Admin/UpdateUserStatus/${el.dataset.id}?cmd=BLOCK`, { method: "PUT" }))
    );
    document.getElementById("check-all").indeterminate = false;
    await loadUsers();
})

deleteUserBtn.addEventListener("click", async (e) => {
    e.preventDefault();
    await Promise.all(
        [...document.querySelectorAll(".row-check:checked")]
            .map(el => fetch(`/Admin/DeleteUser/${el.dataset.id}`, { method: "DELETE" }))
    );
    document.getElementById("check-all").indeterminate = false;
    await loadUsers();
});

document.addEventListener("DOMContentLoaded", () => {
    loadUsers();


});

async function loadUsers(){
    
    const tBody = document.getElementById("users-body")
    tBody.innerHTML = "<tr><td colspan='6'>Loading...</td></tr>";
    
    
    const res = await fetch("/Admin/GetAllUsers/")
    allUsers = await res.json()
    
    
    renderUsers(allUsers, tBody)
    
    
}

function renderUsers(users, body){
    if(!users || users.length === 0) {
        body.innerHTML = "<tr><td colspan='6'>No registered users found.</td></tr>";
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

