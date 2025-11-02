
let allInventoriesLatest = [];
let allInventoriesPopular = [];
let iteration = 0

const customIdValue = document.getElementById("custom-id-value");
let customId = "TESTING";

const list = document.querySelector(".list-group");
const elementToAdd = document.querySelector(".list-group-item");
const addElementBtn = document.getElementById("add-element-btn");


elementToAdd.removeAttribute("id");


addElementBtn.addEventListener("click", () => {
    const clone = elementToAdd.cloneNode(true);
    iteration++;

    const emojis = clone.querySelector("#emojis"); 
    if (emojis) {
        emojis.id = `emojis-${iteration}`;
    }

    list.appendChild(clone);
});


list.addEventListener("change", (e) => {
    if (e.target.matches(".form-select")) {
        
       switch(e.target.value){
           case "Fixed":
       }
        
    }
});

function updateCustomIdValue() {
    customIdValue.innerText = customIdValue.innerText + " " + customId;
}

document.addEventListener("DOMContentLoaded", () => {
    loadInventories();
    updateCustomIdValue();
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
