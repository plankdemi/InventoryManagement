document.addEventListener("DOMContentLoaded", async () => {
    const personalTable = document.getElementById("owned-inventories");
    if (!personalTable) return;

    const inventories = await fetchInventories();

    
    const headerSet = new Set();

   
    for (const inv of inventories) {
        for (let i = 1; i <= 3; i++) {
            if (inv[`customSingleStringState${i}`]) headerSet.add(inv[`customSingleStringName${i}`]);
            if (inv[`customMultiStringState${i}`]) headerSet.add(inv[`customMultiStringName${i}`]);
            if (inv[`customIntState${i}`]) headerSet.add(inv[`customIntName${i}`]);
            if (inv[`customBoolState${i}`]) headerSet.add(inv[`customBoolName${i}`]);
            if (inv[`customLinkState${i}`]) headerSet.add(inv[`customLinkName${i}`]);
        }
    }

    const headers = [...headerSet].filter(Boolean);
    const headerCells = headers.map(name => `<th scope="col">${name}</th>`).join("");

    personalTable.innerHTML = `
    <thead>
      <tr>${headerCells}</tr>
    </thead>
    <tbody id="table-newest-body">
    
    <td colspan=${headerCells.length}>The inventory is empty...</td>

    
</tbody>
  `;
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

