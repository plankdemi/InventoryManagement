let allInventories = [];

document.addEventListener("DOMContentLoaded", () => {
    loadInventories();

 
});


async function loadInventories() {
    const tBody = document.getElementById("table-newest-body");
    tBody.innerHTML = "<tr><td colspan='5'>Loading...</td></tr>";
    
    const res =await fetch("/Home/GetAllInventorySortByNewest/");
    allInventories = await res.json();
    
    renderInventories(allInventories);
}

function renderInventories(inventories) {
    const tBody = document.getElementById("table-newest-body");
    
    if(!inventories || inventories.length === 0) {
        tBody.innerHTML = "<tr><td colspan='5'>No inventories found.</td></tr>";
        return;
    }
    tBody.innerHTML = inventories.map(i => `
    <tr>
    <td>${i.UserId}</td>
    <td>${i.InventoryId}</td>
    <td>${i.NumOfItems}</td>
`).join("");
}



//TODO WHEN TABLE CREATION IS COMPLETE, IMPLEMENT THE OTHER TABLE, AND CHECK IF IT WORKS CORECTLY. COMPLETE THE HOMESCRIPT.JS


