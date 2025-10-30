let allInventories = [];

document.addEventListener("DOMContentLoaded", () => {
    loadInventories();

 
});


async function loadInventories() {
    const tBody = document.getElementById("table-newest-body");
    tBody.innerHTML = "<tr><td colspan='5'>Loading...</td></tr>";

    const tBody2 = document.getElementById("table-newest-body2");
    tBody2.innerHTML = "<tr><td colspan='5'>Loading...</td></tr>";
    
    const res =await fetch("/Home/GetAllInventorySortByNewest/");
    let allInventoriesLatest = await res.json();

    const res2 =await fetch("/Home/GetAllInventorySortByPopularity/");
    let allInventoriesPopular = await res2.json();
    
    renderInventories(allInventoriesLatest, "table-newest-body");
    renderInventories(allInventoriesPopular, "table-newest-body2");
}

function renderInventories(inventories, div) {
    const tBody = document.getElementById(div);
    
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


