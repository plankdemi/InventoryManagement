
let allInventoriesLatest = [];
let allInventoriesPopular = [];


document.addEventListener("DOMContentLoaded", () => {
    loadInventories();
   
});


async function loadInventories() {
    const tBody = document.getElementById("table-newest-body");
    tBody.innerHTML = "<tr><td colspan='3'>Loading...</td></tr>";

    const tBody2 = document.getElementById("table-newest-body2");
    tBody2.innerHTML = "<tr><td colspan='3'>Loading...</td></tr>";

    try {
        const res = await fetch("/Home/GetAllInventorySortByNewest/");
        if (!res.ok) throw new Error("Newest fetch failed");
        allInventoriesLatest = await res.json();
    } catch (e) {
        allInventoriesLatest = [];
    }

    try {
        const res2 = await fetch("/Home/GetAllInventorySortByPopularity/");
        if (!res2.ok) throw new Error("Popular fetch failed");
        allInventoriesPopular = await res2.json();
    } catch (e) {
        allInventoriesPopular = [];
    }

    renderInventories(allInventoriesLatest, "table-newest-body");
    renderInventories(allInventoriesPopular, "table-newest-body2");
}

function renderInventories(inventories, bodyId) {
    const tBody = document.getElementById(bodyId);

    if (!inventories || inventories.length === 0) {
        tBody.innerHTML = "<tr><td colspan='3'>No inventories found.</td></tr>";
        return;
    }

    
    tBody.innerHTML = inventories.map(i => `
    <tr>
      <td>${i.InventoryId}</td>
      <td>${i.UserId}</td>
      <td>${i.NumOfItems}</td>
    </tr>
  `).join("");
}
