document.addEventListener("DOMContentLoaded", async () => {
    const personalTable = document.getElementById("owned-inventories");
    if (!personalTable) return;

    const inventories = await fetchInventories();
    console.log(inventories);

    
    
    const headerSets = [];
    const titles = [];

   
    for (const inv of inventories) {
        const headerSet = new Set();
        for (let i = 1; i <= 3; i++) {
            if (inv[`customSingleStringState${i}`]) headerSet.add(inv[`customSingleStringName${i}`]);
            if (inv[`customMultiStringState${i}`]) headerSet.add(inv[`customMultiStringName${i}`]);
            if (inv[`customIntState${i}`]) headerSet.add(inv[`customIntName${i}`]);
            if (inv[`customBoolState${i}`]) headerSet.add(inv[`customBoolName${i}`]);
            if (inv[`customLinkState${i}`]) headerSet.add(inv[`customLinkName${i}`]);
            
        }
        titles.push(inv.title)
        headerSets.push(headerSet);
    }
    
    
    for (let i = 0; i < headerSets.length; i++) {
        const set = headerSets[i];
        if (!set) continue;

        const table = document.createElement("table");
        table.classList.add("table");
        
        const title = document.createElement("h2");
        title.textContent = titles[i];
        
        
        const headers = [...set].filter(Boolean);
        const colCount = Math.max(1, headers.length);
        const headerCells = headers.map(name => `<th scope="col">${name}</th>`).join("");

        table.innerHTML = `
    <thead>
      <tr>${headerCells}</tr>
    </thead>
    <tbody id="table-newest-body-${i}">
      <tr>
        <td colspan="${colCount}">The inventory is empty...</td>
      </tr>
    </tbody>
  `;
        
        personalTable.appendChild(title);
        personalTable.appendChild(table);
    }



});

async function fetchInventories() {
    try {
        const res = await fetch("/Personal/GetPersonalInventory/");
        if (!res.ok) throw new Error("Fetch failed");
        return await res.json();
    } catch (e) {
        return [];
    }
}

