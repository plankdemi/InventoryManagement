
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

    await renderInventories(allInventoriesLatest, "table-newest-body");
    await renderInventories(allInventoriesPopular, "table-newest-body2");
}

async function renderInventories(inventories, bodyId) {
    const tBody = document.getElementById(bodyId);

    if (!inventories || inventories.length === 0) {
        tBody.innerHTML = "<tr><td colspan='3'>No inventories found.</td></tr>";
        return;
    }

    const rows = await Promise.all(
        inventories.map(async i => {
            const inventoryName = await getInventoryName(i.inventoryId);
            const username = await getUsername(i.userId);
            return `
        <tr>
          <td>${inventoryName}</td>
          <td>${username}</td>
          <td>${i.numofItems}</td>
        </tr>`;
        })
    );

    tBody.innerHTML = rows.join("");
}

async function getInventoryName(inventoryId) {
    try {
        const res = await fetch(`/Home/GetInventoryName/${inventoryId}`); 
        if (!res.ok) return String(inventoryId);
        return (await res.text()).trim();
    } catch {
        return String(inventoryId);
    }
}
async function getUsername(userId){
    try {
        const res = await fetch(`/Home/GetUsername/${userId}`); 
        if (!res.ok) return String(userId);
        return (await res.text()).trim();
    } catch {
        return String(userId);
    }
}
