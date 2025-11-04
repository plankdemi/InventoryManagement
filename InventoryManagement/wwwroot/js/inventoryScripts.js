
//TODO ADD NOTIFICATIONS FOR SUCCESSFULLY SET CUSTOM ID AND PUBLIC STATE

const customIdValue = document.getElementById("custom-id-value");
let customId = "";
let iteration = 0
let customIdValues = []
const inventoryId = location.pathname.split('/').filter(Boolean).pop();

const addElementBtn = document.getElementById("add-element-btn");
const updateCustomIdBtn = document.getElementById("update-custom-id-btn");

const inventoryName = document.getElementById("inventory-name");

const isInventoryPublicCheckbox = document.getElementById("is-inventory-public");
const updateInventoryPublicBtn = document.getElementById("update-inventory-public");

document.addEventListener('DOMContentLoaded', async () => {


    inventoryName.innerText = await getInventoryName(inventoryId);
    isInventoryPublicCheckbox.checked = await getIsInventoryPublicState(inventoryId);


    for (let i = 0; i <= 10; i++) {
        const option = document.getElementById(`list-element-${i}-option`);
        const value = document.getElementById(`list-element-${i}-input`);
        const tooltip = document.getElementById(`list-element-${i}-helper`);

        option?.addEventListener('change', e => {

            let result = "";

            console.log(e.target.value);
            switch (e.target.value) {
                case "Fixed":
                    value.disabled = false;
                    resetHelper(value, i);
                    tooltip.innerText = "There are no formatting options for fixed"
                    break;
                case "20bit":
                    value.disabled = false;
                    resetHelper(value, i);
                    result = random20();
                    tooltip.innerText = "X5 or D6"
                    break;
                case "32bit":
                    value.disabled = false;
                    resetHelper(value, i);
                    result = random32();
                    tooltip.innerText = "X8"
                    break;
                case "6digitrand":
                    value.disabled = true;
                    resetHelper(value, i)
                    result = randomNum(6);
                    tooltip.innerText = "There are no formatting options for 6 digit random"
                    break;
                case "9digitrand":
                    value.disabled = true;
                    resetHelper(value, i)
                    result = randomNum(9);
                    tooltip.innerText = "There are no formatting options for 9 digit random"
                    break;
                case "guid":
                    value.disabled = true;
                    resetHelper(value, i)
                    result = generateGUID();
                    tooltip.innerText = "There are no formatting options for GUID"
                    break;
                case "datetime":
                    value.disabled = false;
                    resetHelper(value, i)
                    result = new Date().getFullYear();
                    tooltip.innerText = "You can format in the following ways: 1. yyyymm 2. yyyymmdd"
                    break;
                case "sequence":
                    value.disabled = true;
                    resetHelper(value, i)
                    tooltip.innerText = "There are no formatting options for sequence"
                    break;

            }
            customIdValues[i] = result;
            updateCustomIdValue();
        });

        value?.addEventListener('input', e => {

            switch (option.value) {
                case "Fixed":
                    customIdValues[i] = value.value;
                    updateCustomIdValue()
                    break;
                case "20bit":
                    switch (value.value) {
                        case "X5":
                            customIdValues[i] = random20Hex();
                            updateCustomIdValue()
                            break;
                        case "D6":
                            customIdValues[i] = random206D();
                            updateCustomIdValue()
                            break;
                        default:
                            customIdValues[i] = ""
                            customIdValues[i] = random20()
                            customIdValues[i] += value.value;
                            updateCustomIdValue()
                            break;
                    }

                    break;
                case "32bit":
                    switch (value.value) {
                        case "X8":
                            customIdValues[i] = random32Hex();
                            updateCustomIdValue()
                            break;
                        default:
                            customIdValues[i] = ""
                            customIdValues[i] = random20()
                            customIdValues[i] += value.value;
                            updateCustomIdValue()
                            break;
                    }
                    break;
                case "6digitrand":

                    switch (value.value) {
                    }
                    break;
                case "9digitrand":

                    switch (value.value) {
                    }
                    break;
                case "guid":

                    switch (value.value) {
                    }
                    break;
                case "datetime":

                    switch (value.value) {
                        case "yyyymm":
                            customIdValues[i] = new Date().getFullYear() + "/" + new Date().getMonth();
                            updateCustomIdValue()
                            break;
                        case "yyyymmdd":
                            customIdValues[i] = new Date().getFullYear() + "/" + new Date().getMonth() + "/" + new Date().getDay();
                            updateCustomIdValue()
                            break;
                        default:
                            customIdValues[i] = ""
                            customIdValues[i] = new Date().getFullYear()
                            updateCustomIdValue()
                            break;

                    }
                    break;
            }


        });
    }


});


updateInventoryPublicBtn.addEventListener("click",async e => {
    
    await fetch(`/Inventory/UpdateInventoryPublicState/${inventoryId}?isPublic=${isInventoryPublicCheckbox.checked}`, {method: "PUT"})
    
})

updateCustomIdBtn.addEventListener("click", async e => {
    console.log(customIdValue.innerText)
    await fetch(`/Inventory/UpdateCustomId/${inventoryId}?customId=${customIdValue.innerText}`, {method: "PUT"})
})

async function getInventoryName(inventoryId) {
    try {
        const res = await fetch(`/Home/GetInventoryName/${inventoryId}`);
        if (!res.ok) return String(inventoryId);
        return (await res.text()).trim();
    } catch {
        return String(inventoryId);
    }
}

async function getIsInventoryPublicState(inventoryId) {
    try{
        const res = await fetch(`/Inventory/GetIsInventoryPublicState/${inventoryId}`);
        return await res.json();
    }catch {
        return false;
    }
}

function generateGUID(){
    return crypto.randomUUID(); 
}
function randomNum(numOfDigits){
    let randomNum = ""
    
    while(randomNum.length!==numOfDigits){
        randomNum+= Math.floor(Math.random() * 10);
    }
    return randomNum;
}

function random20() {
    const u32 = new Uint32Array(1);
    crypto.getRandomValues(u32);
    return u32[0] & 0xFFFFF; 
}
function random32(){
    const u32 = new Uint32Array(1);
    crypto.getRandomValues(u32);
    return u32[0];
}

function random32Hex(){
    return random32().toString(16).padStart(8, '0'); 
}
function random20Hex() {
    return random20().toString(16).padStart(5, '0');
}
function random206D() {
  
    const u32 = new Uint32Array(1);
    while (true) {
        crypto.getRandomValues(u32);
        const x = u32[0] & 0xFFFFF; 
        if (x < 1_000_000) {
            return String(x).padStart(6, '0'); 
        }
    }
}



function resetHelper(value, i){
    customIdValues[i] = ""
    updateCustomIdValue()
    value.value = ""
}

function updateCustomIdValue() {
    
    let customId = ""
    for(let value of customIdValues) customId+=value;
    customIdValue.innerText = customId;
    
}





addElementBtn.addEventListener("click", () => {
    
    if(iteration !== 10){
        iteration++
        addElement(iteration)
    }
   
});

function addElement(i) {
    const element = document.getElementById(`list-element-${i}`)
    element.classList.remove("visually-hidden");
    element.classList.add("custom-active");
}
